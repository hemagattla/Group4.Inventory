//Created by Nitya

using static System.Console;
using System.Collections.Generic;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;
using Znalytics.Inventory.AddressModule.BusinessLogicLayer;
using System;
using System.Linq;
using System.Linq.Expressions;
using Znalytics.Group4.Inventory.Entities;

//Created a namespace for PresentationLayer of WareHouse module
namespace Znalytic.Inventory.WareHouseModule.PresentationLayer
{
    /// <summary>
    /// Represents class for Menu
    /// </summary>
    class MenuPrensentor
    {

        /// <summary>
        /// Starting point of the program
        /// </summary>
        static void Main()
        {
            WareHouseMenu();
            ReadKey();
        }

        public static void WareHouseMenu()
        {
            int choice = -1;

            do
            {
                WriteLine("WareHouse Menu:");
                WriteLine("1. Add WareHouse");
                WriteLine("2. Display WareHouse");
                WriteLine("3. Display WareHouse by WareHouseId");
                WriteLine("4. Delete WareHouse");
                WriteLine("5. Update WareHouse");
                WriteLine("6. Add Address");
                WriteLine("7. Display Address");
                WriteLine("8. GetAddressbyAddressid");
                WriteLine("9. GetAddressbywarehouseid");
                WriteLine("10. GetAddressbyLocationName");
                WriteLine("11. Update WareHouse Address");
                WriteLine("12. Remove WareHouse Address");
                WriteLine("13. Exit");

                bool b = int.TryParse(ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddWareHouse(); break;
                        case 2: GetWareHouses(); break;
                        case 3: GetWareHouseByWareHouseID(); break;
                        case 4: RemoveWareHouse(); break;
                        case 5: UpdateWareHouse(); break;
                        case 6: AddAddress(); break;
                        case 7: GetAddresses(); break;
                        case 8: GetAddressByAddressID(); break;
                        case 9: GetAddressByWareHouseID(); break;
                        case 10: GetAddressByLocationName(); break;
                        case 11: UpdateWareHouseAddress(); break;
                        case 12: RemoveWareHouseAddress(); break;

                        default: break;
                    }
                }
            } while (choice != 13);
        }

        //Method to ADD WareHouse details to the list
        public static void AddWareHouse()
        {
            try
            {
                WareHouse n = new WareHouse();
                WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();
                WriteLine("you chose to enter the warehouse details");
                WriteLine("Enter Warehouse Id that starts with WHID and length of 6");
                n.WareHouseId = ReadLine();
                if (wbl.GetWareHouseByWareHouseID(n.WareHouseId) == null)
                {

                    WriteLine("Enter Warehouse Name");
                    n.WareHouseName = ReadLine();

                    WriteLine("Enter Manager Name");
                    n.MangerName = ReadLine();
                    wbl.AddWareHouse(n);
                    WriteLine("WareHouse added successfully");
                }

                else
                {
                    WriteLine(" warehouse id exists already or you've entered invalid fields");
                }
            }


            catch (WareHouseException ex)
            {
                WriteLine(ex.Message);
            }




        }
        // Method to GET the added details
        public static void GetWareHouses()
        {
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();
            List<WareHouse> wareHouseList = wbl.GetWareHouses();

            WriteLine("===============   WareHouse Details=============");
            WriteLine("WareHouseID" + "   " + "WareHouseName" + "  " + "ManagerName");
            WriteLine("-----------------------------------------------------------------------");

            foreach (WareHouse var in wareHouseList)
            {
                WriteLine(var.WareHouseId + "    " + var.WareHouseName + "  " + var.MangerName);// Displaying the products
            }

        }

        //Method to GET WareHouse details by WareHouseId
        public static void GetWareHouseByWareHouseID()
        {
            try
            {
                WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();

                WriteLine("Enter Existing WareHouse ID");
                string whID = ReadLine();
                WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);
                if (ware != null)
                {
                    WriteLine("WareHouseID" + "   " + "WareHouseName" + "  " + "ManagerName");
                    WriteLine(ware.WareHouseId + "  " + ware.WareHouseName + "  " + ware.MangerName);

                }
                else
                {
                    WriteLine("WareHouse doesn't exist");
                }
            }
            catch (WareHouseException ex)
            {
                WriteLine(ex.Message);
            }






        }


        //Method to REMOVE WareHouses
        public static void RemoveWareHouse()
        {
            WareHouse w = new WareHouse();// creating the object for Warehouse class
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();// Creating thhe object for WareHouseBusinessLogic class
            WriteLine("select on which type you want to remove the WareHouse");
            WriteLine("1.on WareHouseId");
            WriteLine("2.on WareHouseName");
            int Option;
            bool a;
            a = int.TryParse(ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1: RemoveWareHouseByID(); break;
                    case 2: RemoveWareHouseByWareHouseName(); break;
                    default: WriteLine("Please Choose enter correct Option"); break;

                }

            }
            else
            {
                WriteLine("Please Enter Correct Option");
            }
            //Method to REMOVE WareHouse  by WareHouseId
            void RemoveWareHouseByID()
            {
                WareHouse n = new WareHouse();
                Write("Enter the WarehouseID to be Deleted:");
                string wareHouseID = ReadLine();
                try
                {
                    if (wbl.GetWareHouseByWareHouseID(n.WareHouseId) == null)
                    {
                        wbl.RemoveWareHouseByID(wareHouseID);
                        WriteLine("Warehouse Removed");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }




            }
            //Method to REMOVE WareHouse  by WareHouseName
            void RemoveWareHouseByWareHouseName()
            {
                WareHouse n = new WareHouse();
                Write("Enter the Warehouse Name:");
                string name = ReadLine();

                try
                {
                    if (wbl.GetWareHouseByWareHouseID(n.WareHouseName) == null)
                    {
                        wbl.RemoveWareHouseByName(name);
                        WriteLine("Warehouse Removed");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }

        //Method to UPDATE WareHouseName
        public static void UpdateWareHouse()
        {

            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();
            WriteLine("1. Update WareHouse Name");
            WriteLine("2. Update Manager Name");


            int Option;
            bool a;

            a = int.TryParse(ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1:
                        UpdateWareHouseName(); break;
                    case 2:
                        UpdateManagerName(); break;
                    default: WriteLine("Enter correct option"); break;

                }
            }

            //Method to UPDATE ManagerName

            void UpdateWareHouseName()
            {


                try
                {
                    WriteLine("Enter Existing WareHouse ID");
                    string whID = ReadLine();

                    WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);
                    if (ware != null)
                    {
                        WriteLine("Enter new name for WareHouse");
                        ware.WareHouseName = ReadLine();

                        wbl.UpdateWareHouseName(ware);
                        WriteLine("WareHouse Name Updated Sucessfully!!!");
                    }
                    else
                    {
                        WriteLine("Warehouse id doesn't exist");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }

            }



            void UpdateManagerName()
            {

                try
                {
                    WriteLine("Enter Existing WareHouse ID");
                    string whID = ReadLine();

                    WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);
                    if (ware != null)
                    {
                        WriteLine("Enter new name for Manager");
                        ware.MangerName = ReadLine();

                        wbl.UpdateWareHouseName(ware);
                        WriteLine("Manager Name Updated Sucessfully!!!");
                    }
                    else
                    {
                        WriteLine("Warehouse id doesn't exist");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }

            }

        }
        public static void AddAddress()
        {
            try
            {
                WareHouseAddress a = new WareHouseAddress();
                WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();

                WriteLine("You chose to add address to the WareHouse");
                WriteLine("Enter Existing WareHouseId");
                List<WareHouseAddress> addresses = wabl.GetAddresses();
                a.WareHouseId = ReadLine();
                foreach (var ad in addresses)
                {

                    if (ad.WareHouseId == a.WareHouseId)
                    {
                        WriteLine("Enter Address id");
                        a.AddressId = ReadLine();
                        WriteLine("Enter Door Number");
                        a.DoorNumber = ReadLine();
                        WriteLine("Enter Location Name");
                        a.LocationName = ReadLine();
                        WriteLine("Enter State");
                        a.State = ReadLine();
                        WriteLine("Enter the Pincode");
                        a.Pincode = ReadLine();
                        wabl.AddAddress(a);


                        WriteLine("Address added successfully");

                    }


                    else
                    {
                        WriteLine("warehouseid doesnot exist");
                        break;
                    }
                }

            }
            catch (WareHouseException ex)
            {
                WriteLine(ex.Message);
            }







        }
        /* public static bool CheckWareHouseID(WareHouseAddress addressDetails)
         {
             WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
             return wabl.CheckWareHouseID(addressDetails);
         }*/
        public static void GetAddresses()
        {
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
            List<WareHouseAddress> addressList = wabl.GetAddresses();

            WriteLine("===============   WareHouse Details=============");
            WriteLine("WareHouseID" + "   " + "AddressID" + "  " + "Door Number" + "  " + "LocationName" + "  " + "State" + "  " + "Pincode");
            WriteLine("-----------------------------------------------------------------------");

            foreach (WareHouseAddress item in addressList)
            {
                WriteLine(item.WareHouseId + "       " + item.AddressId + "     " + item.DoorNumber + "    " + item.LocationName + "     " + item.State + "    " + item.Pincode);
            }

        }
        public static void GetAddressByAddressID()
        {
            try
            {
                WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
                WriteLine("Enter the existing WareHouse Address Id");
                string addressid = ReadLine();
                WareHouseAddress add = wabl.GetAddressByAddressID(addressid);
                if (add != null)
                {
                    WriteLine("WareHouseID" + "   " + "AddressID" + "  " + "Door Number" + "  " + "LocationName" + "  " + "State" + "  " + "Pincode");
                    WriteLine(add.WareHouseId + "    " + add.AddressId + "  " + add.DoorNumber + " " + add.LocationName + "  " + add.State + "  " + add.Pincode);
                }



            }
            catch (WareHouseException ex)
            {
                WriteLine(ex.Message);
            }

        }
        public static void GetAddressByWareHouseID()
        {

            try
            {
                WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
                WriteLine("Enter the existing WareHouse Id");
                string warehouseid = ReadLine();
                WareHouseAddress add = wabl.GetAddressByWareHouseID(warehouseid);
                if (add != null)
                {
                    WriteLine("WareHouseID" + "   " + "AddressID" + "  " + "Door Number" + "  " + "LocationName" + "  " + "State" + "  " + "Pincode");
                    WriteLine(add.WareHouseId + "    " + add.AddressId + "  " + add.DoorNumber + " " + add.LocationName + "  " + add.State + "  " + add.Pincode);
                }



            }
            catch (WareHouseException ex)
            {
                WriteLine(ex.Message);
            }

        }





        public static void GetAddressByLocationName()
        {
            try
            {
                WriteLine("Enter the locationName");
                string locationName = ReadLine();
                WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
                List<WareHouseAddress> addressList = wabl.GetAddressByLocationName(locationName);
                if (addressList != null)
                    foreach (WareHouseAddress item in addressList)
                    {
                        WriteLine(item.WareHouseId + "    " + item.AddressId + "  " + item.DoorNumber + " " + item.LocationName + "  " + item.State + "  " + item.Pincode);// Displaying the products
                    }

            }
            catch (WareHouseException ex)
            {
                WriteLine(ex.Message);
            }


        }


        public static void UpdateWareHouseAddress()
        {
            WareHouseAddress address = new WareHouseAddress();
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
            WriteLine("1. Update Door Number ");
            WriteLine("2. Update Location Name");
            WriteLine("3. Update State");
            WriteLine("4. Update Pincode");


            int Option;
            bool a;

            a = int.TryParse(ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1:
                        UpdateDoorNumber(); break;
                    case 2:
                        UpdateLocationName(); break;
                    case 3:
                        UpdateState(); break;
                    case 4:
                        UpdatePincode(); break;

                    default: WriteLine("Enter correct option"); break;

                }
            }

            void UpdateDoorNumber()
            {

                try
                {
                    WriteLine("Enter Existing Address ID");
                    string adId = ReadLine();
                    WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                    if (wadd != null)
                    {
                        WriteLine("Enter the new Door Number for the WareHouse");
                        wadd.DoorNumber = ReadLine();

                        wabl.UpdateDoorNumber(wadd);
                        WriteLine("Door Number Updated Sucessfully!!!");

                    }
                    else
                    {
                        WriteLine("Address id doesn't exist");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }
            }


            void UpdateLocationName()
            {


                try
                {
                    WriteLine("Enter Existing Address ID");
                    string adId = ReadLine();
                    WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                    if (wadd != null)
                    {
                        WriteLine("Enter the new Location Name for the WareHouse");
                        wadd.LocationName = ReadLine();

                        wabl.UpdateLocationName(wadd);
                        WriteLine("Door Number Updated Sucessfully!!!");

                    }
                    else
                    {
                        WriteLine("Address id doesn't exist");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }

            }


            void UpdateState()
            {

                try
                {
                    WriteLine("Enter Existing Address ID");
                    string adId = ReadLine();
                    WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                    if (wadd != null)
                    {
                        WriteLine("Enter the new State for the WareHouse");
                        wadd.State = ReadLine();

                        wabl.UpdateState(wadd);
                        WriteLine("Door Number Updated Sucessfully!!!");

                    }
                    else
                    {
                        WriteLine("Address id doesn't exist");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }


            }

            void UpdatePincode()
            {

                try
                {
                    WriteLine("Enter Existing Address ID");
                    string adId = ReadLine();
                    WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                    if (wadd != null)
                    {
                        WriteLine("Enter the new Pincode for the WareHouse");
                        wadd.Pincode = ReadLine();

                        wabl.UpdatePincode(wadd);
                        WriteLine("Door Number Updated Sucessfully!!!");

                    }
                    else
                    {
                        WriteLine("Address id doesn't exist");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }


            }
        }

        public static void RemoveWareHouseAddress()
        {
            WareHouseAddress w = new WareHouseAddress();// creating the object for Warehouse class
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();// Creating thhe object for WareHouseBusinessLogic class
            WriteLine("select on which type you want to remove the WareHouse Address");
            WriteLine("1.on WareHouseId");
            WriteLine("2.on AddressId");
            int Option;
            bool a;
            a = int.TryParse(ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1: RemoveAddressByWareHouseID(); break;
                    case 2: RemoveAddressByAddressID(); break;
                    default: WriteLine("Please Choose enter correct Option"); break;

                }

            }
            else
            {
                WriteLine("Please Enter Correct Option");
            }
            void RemoveAddressByWareHouseID()
            {
                Write("Enter the WarehouseID of the Address to be Deleted:");
                string wareHouseID = ReadLine();
                try
                {
                    if (wabl.GetAddressByAddressID(w.WareHouseId) == null)
                    {
                        wabl.RemoveAddressByWareHouseID(wareHouseID);
                        WriteLine("Warehouse Removed");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }

            }





            void RemoveAddressByAddressID()
            {
                Write("Enter the AddressId to be Deleted:");
                string addressId = ReadLine();
                try
                {
                    if (wabl.GetAddressByAddressID(w.AddressId) == null)
                    {
                        wabl.RemoveAddressByAddressID(addressId);
                        WriteLine("Warehouse Removed");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }



    }










}














































/*using System.Collections.Generic;
using Znalytics.Inventory.AddressModule.BusinessLogicLayer;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;
using Znalytics.Inventory.WareHouseModule.Entities;

using static System.Console;
namespace Znalytic.Inventory.WareHouseModule.PresentationLayer
{
    public class MenuPresentor
    {
        public static void Menu()
        {

            WareHouseAddress a = new WareHouseAddress();
            int choice = -1;
            do
            {
                WriteLine("Menu:");
                WriteLine("1. WareHouse");
                WriteLine("2. Products");
                WriteLine("3. Stock");
                WriteLine("4. Raw Materials");
                WriteLine("5. ");
                WriteLine("6. Exit");

                bool b = int.TryParse(ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: WareHouseMenu(); break;
                    }
                }
            } while (choice != 5);
        }
        public static void WareHouseMenu()
        {
            int choice = -1;

            do
            {
                WriteLine("WareHouse Menu:");
                WriteLine("1. Add WareHouse");
                WriteLine("2. Update WareHouse");
                WriteLine("3. Delete WareHouse");
                WriteLine("4. Display WareHouse");
                WriteLine("5. Exit");

                bool b = int.TryParse(ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddWareHouse(); break;
                        //case 2:UpdateWareHouse(); break;
                        //case 3:DeleteWareHouse();break;
                        // case 4:GetWareHouses();break;
                        default: break;
                    }
                }
            } while (choice != 6);
        }
        public static void AddWareHouse()
        {
            WareHouse n = new WareHouse();
            WareHouseAddress whd = new WareHouseAddress();
            WriteLine("you chose to enter the warehouse details");
            WriteLine("Enter Manager Name");
            n.MangerName = ReadLine();
            WriteLine("Enter Warehouse Id");
            n.WareHouseId = ReadLine();
            /*WriteLine("Enter Location Name");
            whd.LocationName = ReadLine();
            WriteLine("Enter Pincode");
            whd.Pincode = ReadLine();
            WriteLine("Enter Warehouse capacity");
            n.WarehouseCapacity = int.Parse(ReadLine());


            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();
            wbl.AddWareHouse(n);




        }
        public static void GetWareHouses()
        {
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();
            List<WareHouse> WareHouseList = wbl.GetWareHouses();

            WriteLine("===============   WareHouse Details=============");
            WriteLine("WareHouseID" + "   " + "WareHouseName" + "  " + "ManagerName");
            WriteLine("-----------------------------------------------------------------------");

            foreach (WareHouse var in WareHouseList)
            {
                WriteLine(var.WareHouseId + "    " + var.WareHouseName + "  " + var.MangerName);// Displaying the products
            }

        }

        public static void GetWareHouseByWareHouseID()
        {
            WriteLine("Enter WareHouseId");
            string warehouseid = ReadLine();
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();
            WareHouse n = wbl.GetWareHouseByWareHouseID(warehouseid);
            WriteLine(n.WareHouseId + " " + n.MangerName);

        }


        public static void RemoveWareHouse()
        {
            WareHouse w = new WareHouse();// creating the object for Warehouse class
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();// Creating thhe object for WareHouseBusinessLogic class
            WriteLine("select on which type you want to remove the WareHouse");
            WriteLine("1.on WareHouseId");
            WriteLine("2.on WareHouseName");
            int Option;
            bool a;
            a = int.TryParse(ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1: RemoveWareHouseByID(); break;
                    case 2: RemoveWareHouseByWareHouseName(); break;
                    default: WriteLine("Please Choose enter correct Option"); break;

                }

            }
            else
            {
                WriteLine("Please Enter Correct Option");
            }
            void RemoveWareHouseByID()
            {
                Write("Enter the WarehouseID to be Deleted:");
                string WareHouseID = ReadLine();

                wbl.RemoveWareHouseByID(WareHouseID);
                WriteLine("Warehouse Removed");


            }
            void RemoveWareHouseByWareHouseName()
            {
                Write("Enter the Warehouse Name:");
                string name = ReadLine();

                wbl.RemoveWareHouseByName(name);
                WriteLine("Warehouse Removed");
            }
        }
        public static void UpdateWareHouse()
        {
            WareHouse wareHouse = new WareHouse();
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();
            WriteLine("1. Update WareHouse Name");
            WriteLine("2. Update Manager Name");


            int Option;
            bool a;

            a = int.TryParse(ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1:
                        UpdateWareHouseName(); break;
                    case 2:
                        UpdateManagerName(); break;
                    default: WriteLine("Enter correct option"); break;

                }
            }

            void UpdateWareHouseName()
            {

                WriteLine("Enter Existing WareHouse ID");
                wareHouse.WareHouseId = ReadLine();
                WriteLine("Enter new name for WareHouse");
                wareHouse.WareHouseName = ReadLine();

                wbl.UpdateWareHouseName(wareHouse);
                WriteLine("WareHouse Name Updated Sucessfully!!!");

            }



            void UpdateManagerName()
            {
                WriteLine("Enter Existing WareHouse ID");
                wareHouse.WareHouseId = ReadLine();
                WriteLine("Enter new Manager Name");
                wareHouse.MangerName = ReadLine();

                wbl.UpdateManagerName(wareHouse);
                WriteLine("Manager Name Updated Sucessfully!!!");
            }

        }
        public static void AddAddress()
        {
            WareHouseAddress a = new WareHouseAddress();
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
            WriteLine("You chose to add address to the WareHouse");
            WriteLine("Enter Existing WareHouseId");
            a.WareHouseId = ReadLine();
            WriteLine("Enter Address id");
            a.AddressId = ReadLine();
            WriteLine("Enter Door Number");
            a.DoorNumber = ReadLine();
            WriteLine("Enter Location Name");
            a.LocationName = ReadLine();
            WriteLine("Enter State");
            a.State = ReadLine();
            WriteLine("Enter the Pincode");
            a.Pincode = ReadLine();
            wabl.AddAddress(a);

            WriteLine("Address added successfully");





        }
        public static void GetAddresses()
        {
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
            List<WareHouseAddress> AddressList = wabl.GetAddresses();

            WriteLine("===============   WareHouse Details=============");
            WriteLine("WareHouseID" + "   " + "AddressID" + "  " + "Door Number" + "  " + "LocationName" + "  " + "State" + "  " + "Pincode");
            WriteLine("-----------------------------------------------------------------------");

            foreach (WareHouseAddress item in AddressList)
            {
                WriteLine(item.WareHouseId + "    " + item.AddressId + "  " + item.DoorNumber + " " + item.LocationName + "  " + item.State + "  " + item.Pincode);// Displaying the products
            }

        }
        public static void GetAddressByAddressID()
        {
            WriteLine("Enter the existing WareHouse Address Id");
            string addressid = ReadLine();
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
            List<WareHouseAddress> addressList = wabl.GetAddressByAddressID(addressid);
            foreach (WareHouseAddress item in addressList)
            {
                WriteLine(item.WareHouseId + "    " + item.AddressId + "  " + item.DoorNumber + " " + item.LocationName + "  " + item.State + "  " + item.Pincode);// Displaying the products
            }



        }
        public static void GetAddressByWareHouseID()
        {
            WriteLine("Enter the existing WareHouse WareHouse Id");
            string warehouseId = ReadLine();
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
            List<WareHouseAddress> addressList = wabl.GetAddressByWareHouseID(warehouseId);
            foreach (WareHouseAddress item in addressList)
            {
                WriteLine(item.WareHouseId + "    " + item.AddressId + "  " + item.DoorNumber + " " + item.LocationName + "  " + item.State + "  " + item.Pincode);// Displaying the products
            }

        }





        public static void GetAddressByLocationName()
        {
            WriteLine("Enter the locationName");
            string locationName = ReadLine();
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
            List<WareHouseAddress> addressList = wabl.GetAddressByLocationName(locationName);
            foreach (WareHouseAddress item in addressList)
            {
                WriteLine(item.WareHouseId + "    " + item.AddressId + "  " + item.DoorNumber + " " + item.LocationName + "  " + item.State + "  " + item.Pincode);// Displaying the products
            }

        }


        public static void UpdateWareHouseAddress()
        {
            WareHouseAddress address = new WareHouseAddress();
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
            WriteLine("1. Update Door Number ");
            WriteLine("2. Update Location Name");
            WriteLine("3. Update State");
            WriteLine("4. Update Pincode");


            int Option;
            bool a;

            a = int.TryParse(ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1:
                        UpdateDoorNumber(); break;
                    case 2:
                        UpdateLocationName(); break;
                    case 3:
                        UpdateState(); break;
                    case 4:
                        UpdatePincode(); break;

                    default: WriteLine("Enter correct option"); break;

                }
            }

            void UpdateDoorNumber()
            {

                WriteLine("Enter Existing Address ID");
                address.AddressId = ReadLine();
                WriteLine("Enter the new Door Number for the WareHouse");
                address.DoorNumber = ReadLine();

                wabl.UpdateDoorNumber(address);
                WriteLine("Door Number Updated Sucessfully!!!");

            }


            void UpdateLocationName()
            {

                WriteLine("Enter Existing Address ID");
                address.AddressId = ReadLine();
                WriteLine("Enter the new Location Name for the WareHouse");
                address.LocationName = ReadLine();

                wabl.UpdateLocationName(address);
                WriteLine("Location Name Updated Sucessfully!!!");

            }


            void UpdateState()
            {

                WriteLine("Enter Existing Address ID");
                address.AddressId = ReadLine();
                WriteLine("Enter the new State for the WareHouse");
                address.State = ReadLine();

                wabl.UpdateState(address);
                WriteLine(" State Updated Sucessfully!!!");

            }

            void UpdatePincode()
            {

                WriteLine("Enter Existing Address ID");
                address.AddressId = ReadLine();
                WriteLine("Enter the new pincode for the WareHouse");
                address.Pincode = ReadLine();

                wabl.UpdatePincode(address);
                WriteLine("Pincode Updated Sucessfully!!!");

            }
        }

        public static void RemoveWareHouseAddress()
        {
            WareHouseAddress w = new WareHouseAddress();// creating the object for Warehouse class
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();// Creating thhe object for WareHouseBusinessLogic class
            WriteLine("select on which type you want to remove the WareHouse Address");
            WriteLine("1.on WareHouseId");
            WriteLine("2.on AddressId");
            int Option;
            bool a;
            a = int.TryParse(ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1: RemoveAddressByWareHouseID(); break;
                    case 2: RemoveAddressByAddressID(); break;
                    default: WriteLine("Please Choose enter correct Option"); break;

                }

            }
            else
            {
                WriteLine("Please Enter Correct Option");
            }
            void RemoveAddressByWareHouseID()
            {
                Write("Enter the WarehouseID:");
                string wareHouseID = ReadLine();

                wabl.RemoveAddressByWareHouseID(wareHouseID);
                WriteLine("Address Removed");


            }
            void RemoveAddressByAddressID()
            {
                Write("Enter the AddressId:");
                string addressID = ReadLine();

                wabl.RemoveAddressByAddressID(addressID);
                WriteLine("Warehouse Removed");
            }

        }
    }
}*/

















/*            
            //Created object of Menu
            Menu m = new Menu();
            int Option;

            //Created object for WareHouse
            WareHouse n = new WareHouse();

            //Created object for BusinessLogicsLayer
            WareHouseBusinessLayer wbl = new WareHouseBusinessLayer();
            wbl.AddWareHouse(n);

            //do-while loop for menu
            do
            {
                Option = m.Show();
                switch (Option)
                {
                    //Add Warehouse
                    case 1:
                        {
                            System.Console.WriteLine("you chose to enter the warehouse details");
                            System.Console.WriteLine("Enter Manager Name");
                            n.MangerName = System.Console.ReadLine();
                            System.Console.WriteLine("Enter Warehouse Id");
                            n.WarehouseId = System.Console.ReadLine();
                            System.Console.WriteLine("Enter Location Name");
                            n.LocationName = System.Console.ReadLine();
                            System.Console.WriteLine("Enter Pincode");
                            n.Pincode = System.Console.ReadLine();
                            System.Console.WriteLine("Enter Warehouse capacity");
                            n.WarehouseCapacity = int.Parse(System.Console.ReadLine());

                            break;
                        }
                    //Display Warehouse Details
                    case 2:
                        {
                            System.Console.WriteLine("you chose to display the warehouse details");
                            System.Console.WriteLine("ManagerName :" + n.MangerName);
                            System.Console.WriteLine("WarehouseId :" + n.WarehouseId);
                            System.Console.WriteLine("LocationName: " + n.LocationName);
                            System.Console.WriteLine("Pincode: " + n.Pincode);
                            System.Console.WriteLine("WarehouseCapacity: " + n.WarehouseCapacity);
                            System.Console.WriteLine("WarehouseStatus: " + n.WarehouseStatus);

                            break;

                        }
                    //Update Warehouse Details
                    case 3:
                        {
                            System.Console.WriteLine("you chose to update the warehouse details");

                            break;
                        }
                    //Delete Warehouse Details
                    case 4:
                        {
                            System.Console.WriteLine("you chose to delete the warehouse details");

                            break;
                        }
                    case 5:
                        {
                            System.Console.WriteLine("you chose to exit ");
                            break;
                        }
                    default:
                        break;


                }

                System.Console.ReadKey();
            } while (Option != 6);
        }


        // Class for Menu
        public class Menu
        {
            public int Choice;
            public int Show()
            {
                //System.Console.Clear();
                System.Console.WriteLine("Please enter your option:\n\n 1.Add new WareHouse\n 2. Display Details\n 3.Update\n 4.Delete  ");

                Choice = int.Parse(System.Console.ReadLine());
                return Choice;


            }

}
}
*/



