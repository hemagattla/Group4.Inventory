//Created by Nitya

//Importing statements
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
            
        }
        

        public static void WareHouseMenu()
        {
            int choice = -1;

            do
            {
                WriteLine("WareHouse Menu:");
                WriteLine("1. Add WareHouse");
                WriteLine("2. Get WareHouses");
                WriteLine("3. Get WareHouse by WareHouseId");
                WriteLine("4. Delete WareHouse");
                WriteLine("5. Update WareHouse");
                WriteLine("6. Add Address");
                WriteLine("7. Get WareHouse Addresses");
                WriteLine("8. Get Address by AddressId");
                WriteLine("9. Get Address by WarehouseId");
                WriteLine("10. Get Address by LocationName");
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

        //Method to ADD Address details to the list
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

        // Method to GET the added  address details
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

        //Method to GET WareHouseAddress details by AddressId
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

        //Method to GET WareHouseAddress details by WareHouseId
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




        //Method to GET WareHouseAddress details by LocationName
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

        // //Method to UPDATE the details of WareHouse
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

            //Method to UPDATE Door Number of WareHouse
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

            //Method to UPDATE the Location Name of WareHouse
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

            //Method to UPDATE the State of WareHouse
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

            //Method to UPDATE the Pincode of WareHouse
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

        //Method to REMOVE an address of the Warehouse
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

            //Method to REMOVE an address of the Warehouse by wareHouseID
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




            //Method to REMOVE an address of the Warehouse by addressID
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
