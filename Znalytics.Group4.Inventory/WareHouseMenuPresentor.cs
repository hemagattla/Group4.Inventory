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
        public void WareHouseMenu()
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

        /// <summary>
        ///Method to ADD WareHouse details to the list
        /// </summary>
        public void AddWareHouse()
        {
            try
            {
                //Created an object for Warehouse class and is stored in a reference variable
                WareHouse n = new WareHouse();

                //Created an object for Warehouse Business class and is stored in a reference variable
                WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();

                WriteLine("you chose to enter the warehouse details");
                WriteLine("Enter Warehouse Id that starts with WHID and length of 6");
                n.WareHouseId = ReadLine();

                //Condition to check whether the WareHouseid exists or not
                //The Warehouseid should be unique
                if (wbl.CheckWareHouseId(n.WareHouseId) == false)
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
                    WriteLine("WareHouse Exists!");
                }
            }


            catch (WareHouseException ex)
            {
                WriteLine(ex.Message);
            }




        }

        /// <summary>
        ///Method to GET the WareHouse details
        /// </summary>
        public void GetWareHouses()
        {
            //Created an object for Warehouse Business class and is stored in a reference variable
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();

            //WareHouse List is stored in a reference variable
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
        public void GetWareHouseByWareHouseID()
        {
            try
            {
                //Created an object for Warehouse Business class and is stored in a reference variable
                WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();

                WriteLine("Enter Existing WareHouse ID");
                string whID = ReadLine();

                //Condition to check whether the WareHouseid exists or not
                WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);
                if (ware != null)
                {
                    WriteLine("===============   WareHouse Details=============");
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
        public  void RemoveWareHouse()
        {
            // created the object for Warehouse class
            WareHouse w = new WareHouse();

            // Created an object for WareHouseBusinessLogic class
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();

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
                string whID = ReadLine();
                try
                {
                    //Condition to check whether the warehouse id exists or not
                    WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);
                    if (ware != null)
                    {
                        wbl.RemoveWareHouseByID(whID);
                        WriteLine("Warehouse Removed");
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
            //Method to REMOVE WareHouse  by WareHouseName
            void RemoveWareHouseByWareHouseName()
            {
                WareHouse n = new WareHouse();
                Write("Enter the Warehouse Name:");
                string name = ReadLine();

                try
                {
                    //Condition to check whether the warehouse Name exists or not
                    if (wbl.GetWareHouseByWareHouseID(n.WareHouseName) == null)
                    {
                        wbl.RemoveWareHouseByName(name);
                        WriteLine("Warehouse Removed");
                    }
                    else
                    {
                        WriteLine("Warehouse doesn't exist by this name");
                    }
                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        ///Method to UPDATE WareHouseName
        /// </summary>
        public void UpdateWareHouse()
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

                    //Condition to check whether the warehouse id exists or not
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

                    //Condition to check whether the warehouse id exists or not
                    WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);
                    if (ware != null)
                    {
                        WriteLine("Enter new name for Manager");
                        ware.MangerName = ReadLine();

                        wbl.UpdateManagerName(ware);
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

        /// <summary>
        ///Method to ADD Address details to the list
        /// </summary>
        public void AddAddress()
        {
            try
            {
                //Created an object for WareHouseAddress class and stored it in a reference variable
                WareHouseAddress a = new WareHouseAddress();

                //Created an object for WareHouseAddress Business class and stored it in a reference variable
                WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();

                WriteLine("You chose to add address to the WareHouse");
                WriteLine("Enter Existing WareHouseId");
                a.WareHouseId = ReadLine();

                //Condition to check whether WareHouseid exists or not
                if (CheckWareHouseId(a.WareHouseId) == true)
                {
                    //Condition to check whether Addressid exists or not
                    if (CheckAddressId(a.AddressId) == false)
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
                        WriteLine("Address id exists already");
                    }
                    
                }
                else
                {
                    WriteLine("WareHouse id doesn't exist or is invalid");
                }


            }
            catch (WareHouseException ex)
            {
                WriteLine(ex.Message);
            }




        }

        /// <summary>
        ///  Method to GET the address details
        /// </summary>
        public void GetAddresses()
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

        /// <summary>
        /// Method to GET WareHouseAddress details by AddressId
        /// </summary>
        public void GetAddressByAddressID()
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

        /// <summary>
        /// Method to GET WareHouseAddress details by WareHouseId
        /// </summary>
        public void GetAddressByWareHouseID()
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
        public void GetAddressByLocationName()
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

        /// <summary>
        /// Method to UPDATE the details of WareHouse Address
        /// </summary>
        public void UpdateWareHouseAddress()
        {
            //Created an object for WareHouseAddress Business class and stored it in a reference variable
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

            //Local Function to UPDATE Door Number of WareHouse
            void UpdateDoorNumber()
            {

                try
                {
                    WriteLine("Enter Existing Address ID");
                    string adId = ReadLine();
                    WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                    //Condition to check whether AddressId is null or not
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

            //Local Function to UPDATE the Location Name of WareHouse
            void UpdateLocationName()
            {


                try
                {
                    WriteLine("Enter Existing Address ID");
                    string adId = ReadLine();
                    WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                    //Condition to check whether AddressId is null or not
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

            //Local Function to UPDATE the State of WareHouse
            void UpdateState()
            {

                try
                {
                    WriteLine("Enter Existing Address ID");
                    string adId = ReadLine();
                    WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                    //Condition to check whether AddressId is null or not
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

            //Local Function to UPDATE the Pincode of WareHouse
            void UpdatePincode()
            {

                try
                {
                    WriteLine("Enter Existing Address ID");
                    string adId = ReadLine();
                    WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                    //Condition to check whether AddressId is null or not
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

        /// <summary>
        /// Method to REMOVE an address of the Warehouse
        /// </summary>
        public void RemoveWareHouseAddress()
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

            //Local function to REMOVE an address of the Warehouse by wareHouseID
            void RemoveAddressByWareHouseID()
            {
                Write("Enter the WarehouseID of the Address to be Deleted:");
                string wareHouseID = ReadLine();
                try
                {
                    // Condition to check whether WarHouseId exists or not
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




            //Local function to REMOVE an address of the Warehouse by addressID
            void RemoveAddressByAddressID()
            {
                Write("Enter the AddressId to be Deleted:");
                string addressId = ReadLine();
                try
                {
                    // Condition to check whether AddressId exists or not
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

        /// <summary>
        /// Method to check whether WareHouseid exists or not
        /// </summary>
        /// <param name="id">Represents WareHouseId</param>
        /// <returns></returns>
        public bool CheckWareHouseId(string id)
        {
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();
            bool result = wbl.CheckWareHouseId(id);

            // Condition to check whether WareHouseId exists or not
            if (result == true)
            {
                WriteLine("WareHouse Exists");
                return result;
            }
            return result;
        }

        /// <summary>
        /// Method to check whether AddressId exists or not
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckAddressId(string id)
        {
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();
            bool result = wabl.CheckAddressId(id);
            // Condition to check whether AddressId exists or not
            if (result == true)
            {
                WriteLine("Address Exists");
                return result;
            }
            return result;
        }



    }










}
