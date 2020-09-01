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

/// <summary>
///Created a namespace for PresentationLayer of WareHouse module
/// </summary>
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

            //Created an object for Warehouse class and is stored in a reference variable
            WareHouse ware = new WareHouse();

            //Created an object for Warehouse Business class and is stored in a reference variable
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();

            bool check = false;
            do
            {
                try
                {
                    
                    WriteLine(" You chose to add a warehouse");
                    WriteLine("Enter Warehouse Id that starts with WHID and of length 6.It shouldn't contain special characters");

                    //Reads the WarehouseId
                    ware.WareHouseId = ReadLine();

                    //Condition to check whether the WareHouseid exists or not
                    //The Warehouseid should be unique
                    if (wbl.CheckWareHouseId(ware.WareHouseId) == false)
                    {
                        check = true;
                        WriteLine("Enter Warehouse Name");
                        WriteLine("WareHouse Name shouldn'be null or empty.It shouldn't contain special characters also");
                        //Reads the WareHouseName
                        ware.WareHouseName = ReadLine();

                        WriteLine("Enter Manager Name");
                        WriteLine("Manager Name shouldn'be null or empty.It shouldn't contain special characters also");
                        //Reads the MangerName
                        ware.MangerName = ReadLine();

                        //Calls the AddWareHouse method of WareHouseBusinessLogic
                        wbl.AddWareHouse(ware);
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
            } while (check== false);



        }

        /// <summary>
        ///Method to GET the WareHouse details
        /// </summary>
        public void GetWareHouses()
        {
            WriteLine(" You chose to Get the WareHouse Details");

            //Created an object for Warehouse Business class and is stored in a reference variable
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();

            //Calls the GetWareHouses method of WareHouseBusinessLogic
            List<WareHouse> wareHouseList = wbl.GetWareHouses();

            WriteLine("===============   WareHouse Details=============");
            WriteLine("WareHouseID" + "     " + "WareHouseName" + "    " + "ManagerName");
            WriteLine("-----------------------------------------------------------------------");

            foreach (WareHouse var in wareHouseList)
            {
                WriteLine(var.WareHouseId + "    " + var.WareHouseName + "  " + var.MangerName);// Displaying the products
            }

        }

        //Method to GET WareHouse details by WareHouseId
        public void GetWareHouseByWareHouseID()
        {
            bool check = false;
            do
            {
                try
                {
                    WriteLine(" You chose to get the details of  Warehouse by WareHouseId");
                    //Created an object for Warehouse Business class and is stored in a reference variable
                    WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();

                    WriteLine("Enter Existing WareHouse ID");
                    WriteLine("The Warehouse Id should start with WHID and of length 6.It shouldn't contain special characters");

                    //Reads the WareHouseid and is stored in a reference variable
                    string whID = ReadLine();

                    //Calls the GetWareHouseByWareHouseID of WareHouseBusinessLogic and is stored in Warehouse reference variable
                    WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);

                    // Condition to check whether the WareHouseid exists or not
                    if (ware != null)
                    {
                        check = true;
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
            } while (check == false);
            

        }


        //Method to REMOVE WareHouses
        public  void RemoveWareHouse()
        {
            
            // Created an object for WareHouseBusinessLogic class
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();

            WriteLine("select on which type you want to remove the WareHouse");
            WriteLine("1.on WareHouseId");
            WriteLine("2.on WareHouseName");
            int Option;
            bool a;
            
            //TryParse returns a bool value
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
            //Local Function to REMOVE WareHouse  by WareHouseId
            void RemoveWareHouseByID()
            {
                bool check = false;
                do
                {
                    WriteLine("You chose to Remove the WareHouse by WareHouseId");
                    WriteLine("Enter the WarehouseID to be Deleted");
                    WriteLine("The Warehouse Id should start with WHID and of length 6.It shouldn't contain special characters");

                    //Reads the WareHouseid and is stored in a reference variable
                    string whID = ReadLine();
                    try
                    {
                        //Condition to check whether the warehouse id exists or not
                        WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);
                        if (ware != null)
                        {
                            check = true;

                            //Calls the RemoveWareHouseByWareHouseID method of WareHouseBusiness Logic
                            wbl.RemoveWareHouseByWareHouseID(whID);
                            WriteLine("Warehouse Removed Successfully!");
                        }
                        else
                        {
                            WriteLine("Warehouse id doesn't exist.Please enter existing WareHius");
                        }
                    }
                    catch (WareHouseException ex)
                    {
                        WriteLine(ex.Message);
                    }
                } while (check == false);
           
            }
            //Method to REMOVE WareHouse  by WareHouseName
            void RemoveWareHouseByWareHouseName()
            {
               
                bool check = false;
                do
                {
                    try
                    {
                        WriteLine("You chose to Remove the WareHouse by WareHouse Name");
                        // created the object for Warehouse class
                        WareHouse ware = new WareHouse();

                        Write("Enter the Warehouse Name:");
                        WriteLine("Warehouse Name should neither be null nor contain special characters");
                        //Reads the WareHouseName and is stored in a reference variable
                        string warName = ReadLine();

                        //Condition to check whether the warehouse Name exists or not
                        if (wbl.GetWareHouseByWareHouseID(ware.WareHouseName) == null)
                        {
                            check = true;

                            //Calls the RemoveWareHouseByWareHouseName WareHouseBusiness Logic 
                            wbl.RemoveWareHouseByWareHouseName(warName);
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
                } while (check == false);
            }
        }

        /// <summary>
        ///Method to UPDATE WareHouseName
        /// </summary>
        public void UpdateWareHouse()
        {
            //Created an object for Warehouse Business class and is stored in a reference variable
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

                bool check = false;
                do
                {
                    try
                    {
                        WriteLine("You chose to Update the WareHouse Name");
                        WriteLine("Enter Existing WareHouse ID");
                        WriteLine("The Warehouse Id should start with WHID and of length 6.It shouldn't contain special characters");

                        //Reads the WareHouseid and is stored in a reference variable
                        string whID = ReadLine();

                        //Condition to check whether the warehouse id exists or not
                        WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);
                        if (ware != null)
                        {
                            check = true;
                            WriteLine("Enter new name for WareHouse");
                            WriteLine("WareHouse Name shouldn'be null or empty.It shouldn't contain special characters also");

                            //Reads the WareHouseName and is stored in the object
                            ware.WareHouseName = ReadLine();

                            //Calls the UpdateWareHouseName of WareHouseBusinessLogic
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
                } while (check == false);

            }



            void UpdateManagerName()
            {
                bool check = false;
                do
                {
                    try
                    {
                        WriteLine("You chose to Update the Manager Name");
                        WriteLine("Enter Existing WareHouse ID");
                        WriteLine("The Warehouse Id should start with WHID and of length 6.It shouldn't contain special characters");

                        //Reads the WareHouseid and is stored in a reference variable
                        string whID = ReadLine();

                        //Condition to check whether the warehouse id exists or not
                        WareHouse ware = wbl.GetWareHouseByWareHouseID(whID);
                        //Condition to check whether the warehouse id exists or not
                        if (ware != null)
                        {
                            check = true;
                            WriteLine("Enter new name for Manager");
                            WriteLine("Manager Name shouldn'be null or empty.It shouldn't any contain special characters ");
                            //Reads the MangerName and is stored in the object
                            ware.MangerName = ReadLine();

                            //Calls the UpdateManagerName of WareHouseBusinessLogic
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
                } while (check== false);

            }

        }

        /// <summary>
        ///Method to ADD Address details to the list
        /// </summary>
        public void AddAddress()
        {
            bool check = false;
            do
            {
                try
                {
                    WriteLine("You chose to Add the Address to a WareHouse");
                    //Created an object for WareHouseAddress class and stored it in a reference variable
                    WareHouseAddress address = new WareHouseAddress();

                    //Created an object for WareHouseAddress Business class and stored it in a reference variable
                    WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();

                    WriteLine("You chose to add address to the WareHouse");
                    WriteLine("Enter Existing WareHouseId");
                    WriteLine("The Warehouse Id should start with WHID and of length 6.It shouldn't contain special characters");
                    //Reads the WareHouseid and is stored in the WareHouseAddress object
                    address.WareHouseId = ReadLine();

                    //Condition to check whether WareHouseid exists or not
                    if (CheckWareHouseId(address.WareHouseId) == true)
                    {
                        //Condition to check whether Addressid exists or not
                        if (CheckAddressId(address.AddressId) == false)
                        {
                            check = true;
                            WriteLine("Enter Address id");
                            WriteLine("Addressid must be of length 6 and should contain only alphanumeric values");
                            //Reads the AddressId and is stored in the WareHouseAddress object
                            address.AddressId = ReadLine();

                            WriteLine("Enter Door Number");
                            WriteLine("Door Number shouldn't be null or empty");
                            //Reads the DoorNumber and is stored in the WareHouseAddress object
                            address.DoorNumber = ReadLine();

                            WriteLine("Enter Location Name");
                            WriteLine("Location Name shouldn't be null and should contain alphabets");
                            //Reads the LocationName and is stored in the WareHouseAddress object
                            address.LocationName = ReadLine();

                            WriteLine("Enter State");
                            WriteLine("State shouldn't be null and should contain alphabets");
                            //Reads the State and is stored in the WareHouseAddress object
                            address.State = ReadLine();

                            WriteLine("Enter the Pincode");
                            WriteLine("Pincode must be numeric and length should be exactly 6");
                            //Reads the Pincode and is stored in the WareHouseAddress object
                            address.Pincode = ReadLine();

                            //Calls the AddAddress method of WareHouseAddressBusinessLogic
                            wabl.AddAddress(address);


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
            } while (check == false);
        }


        /// <summary>
        ///  Method to GET the address details
        /// </summary>
        public void GetAddresses()
        {
            WriteLine("You chose to Get all the Addresses");
            //Created an object for WareHouseAddressBusinessLogicLayer and is stored in the reference variable
            WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();

            //Calls the GetAddresses method of WareHouseAddressBusinessLogicLayer
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
            bool check = false;
            do
            {
                try
                {
                    WriteLine("You chose to Get the Address details by AddressId");
                    //Created an object for WareHouseAddressBusinessLogicLayer and is stored in a reference variable
                    WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();

                    WriteLine("Enter the existing WareHouse Address Id");
                    WriteLine("The Address Id should start with W and of length 4.It shouldn't contain special characters");

                    //Reads the AddressId and is stored in a reference variable
                    string addressid = ReadLine();

                    //Calls the GetAddressByAddressID methof of WareHouseAddressBusinessLogicLayer
                    WareHouseAddress add = wabl.GetAddressByAddressID(addressid);

                    //Condition to check whether the address id exists or not
                    if (add != null)
                    {
                        check = true;
                        WriteLine("WareHouseID" + "   " + "AddressID" + "  " + "Door Number" + "  " + "LocationName" + "  " + "State" + "  " + "Pincode");
                        WriteLine(add.WareHouseId + "    " + add.AddressId + "  " + add.DoorNumber + " " + add.LocationName + "  " + add.State + "  " + add.Pincode);
                    }



                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }
            } while (check == false);

        }

        /// <summary>
        /// Method to GET WareHouseAddress details by WareHouseId
        /// </summary>
        public void GetAddressByWareHouseID()
        {
            bool check = false;
            do
            {
                try
                {
                    WriteLine("You chose to Get the Address details byWareHouseId");
                    //Created an object for WarehouseAddress Business class and is stored in a reference variable
                    WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();

                    WriteLine("Enter the existing WareHouse Id");
                    WriteLine("The Warehouse Id should start with WHID and of length 6.It shouldn't contain special characters");
                    //Reads the WareHouseId and is stored in a reference variable
                    string warehouseid = ReadLine();

                    //Calls the GetAddressByAddressID methof of WareHouseAddressBusinessLogicLayer
                    WareHouseAddress add = wabl.GetAddressByWareHouseID(warehouseid);

                    //Condition to check whether the address id exists or not
                    if (add != null)
                    {
                        check = true;
                        WriteLine("WareHouseID" + "   " + "AddressID" + "  " + "Door Number" + "  " + "LocationName" + "  " + "State" + "  " + "Pincode");
                        WriteLine(add.WareHouseId + "    " + add.AddressId + "  " + add.DoorNumber + " " + add.LocationName + "  " + add.State + "  " + add.Pincode);
                    }



                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }
            } while (check == false);

        }




        //Method to GET WareHouseAddress details by LocationName
        public void GetAddressByLocationName()
        {
            bool check = false;
            do
            {
                try
                {
                    WriteLine("You chose to Get Address by Location Name");
                    WriteLine("Enter the locationName");
                    WriteLine("The Location Name should neither be null nor empty.It shouldn't contain any special characters");
                    //Reads the location name and is stored in a reference variable
                    string locationName = ReadLine();

                    //Created an object for WarehouseAddress Business class and is stored in a reference variable
                    WareHouseAddressBusinessLogicLayer wabl = new WareHouseAddressBusinessLogicLayer();

                    //Calls the GetAddressByAddressID methof of WareHouseAddressBusinessLogicLayer
                    List<WareHouseAddress> addressList = wabl.GetAddressByLocationName(locationName);

                    //Condition to check whether the address id exists or not
                    if (addressList != null)
                    {
                        check = true;
                        foreach (WareHouseAddress item in addressList)
                        {
                            WriteLine(item.WareHouseId + "    " + item.AddressId + "  " + item.DoorNumber + " " + item.LocationName + "  " + item.State + "  " + item.Pincode);// Displaying the products
                        }
                    }

                }
                catch (WareHouseException ex)
                {
                    WriteLine(ex.Message);
                }
            } while (check == false);


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
                bool check = false;
                do
                {
                    try
                    {
                        WriteLine("You chose to Update the Door Number of a WareHouse Address");
                        WriteLine("Enter Existing Address ID");
                        WriteLine("The Address Id should start with W and of length 4.It shouldn't contain special characters");
                        //Reads the AddressId and is stored in a reference variable
                        string adId = ReadLine();

                        //Calls the GetAddressByAddressID methof of WareHouseAddressBusinessLogicLayer
                        WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);

                        //Condition to check whether AddressId is null or not
                        if (wadd != null)
                        {
                            check = true;
                            WriteLine("Enter the new Door Number for the WareHouse");
                            WriteLine("Door Number shouldn't be null or empty");

                            //Reads the DoorNumber and is stored in reference variable
                            wadd.DoorNumber = ReadLine();

                            //Calls the UpdateDoorNumber method of WareHouseAddressBusiess Logic
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
                } while (check == false);
            }
            

            //Local Function to UPDATE the Location Name of WareHouse
            void UpdateLocationName()
            {

                bool check = false;
                do
                {
                    try
                    {
                        WriteLine("You chose to Update the LocationName of a WareHouse Address");
                        WriteLine("Enter Existing Address ID");
                        WriteLine("The Address Id should start with W and of length 4.It shouldn't contain special characters");

                        //Reads the AddressId and is stored in a reference variable
                        string adId = ReadLine();

                        //Calls the GetAddressByAddressID methof of WareHouseAddressBusinessLogicLayer
                        WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);

                        //Condition to check whether AddressId is null or not
                        if (wadd != null)
                        {
                            check = true;
                            WriteLine("Enter the new Location Name for the WareHouse");
                            WriteLine("Location name shouldn't be null or empty and special characters are not allowed ");
                            //Reads the LocationName and is stored in reference variable
                            wadd.LocationName = ReadLine();

                            //Calls the UpdateLocationName method of WareHouseAddressBusiess Logic
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
                } while (check == false);

            }

            //Local Function to UPDATE the State of WareHouse
            void UpdateState()
            {
                bool check = false;
                do
                {
                    try
                    {
                        WriteLine("You chose to Update the State of a WareHouse Address");
                        WriteLine("Enter Existing Address ID");
                        WriteLine("The Address Id should start with W and of length 4.It shouldn't contain special characters");

                        //Reads the AddressId and is stored in a reference variable
                        string adId = ReadLine();

                        //Calls the GetAddressByAddressID method of WareHouseAddressBusinessLogicLayer
                        WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                        //Condition to check whether AddressId is null or not
                        if (wadd != null)
                        {
                            check = true;
                            WriteLine("Enter the new State for the WareHouse");
                            WriteLine("State shouldn't be null or empty and special characters are not allowed ");
                            //Reads the State and is stored in an reference variable
                            wadd.State = ReadLine();

                            //Calls the UpdateState method of WareHouseAddressBusinessLogicLayer
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
                } while (check == false);


            }

            //Local Function to UPDATE the Pincode of WareHouse
            void UpdatePincode()
            {
                bool check = false;
                do
                {
                    try
                    {
                        WriteLine("You chose to Update the Pincode of a WareHouse Address");
                        WriteLine("Enter Existing Address ID");
                        WriteLine("The Address Id should start with W and of length 4.It shouldn't contain special characters");

                        //Reads the AddressId and is stored in a reference variable
                        string adId = ReadLine();

                        //Calls the GetAddressByAddressID method of WareHouseAddressBusinessLogicLayer
                        WareHouseAddress wadd = wabl.GetAddressByAddressID(adId);
                        //Condition to check whether AddressId is null or not
                        if (wadd != null)
                        {
                            check = true;
                            WriteLine("Enter the new Pincode for the WareHouse");
                            WriteLine("Numeric values with length 6 are only allowed");
                            //Reads the Pincode and is stored in a reference variable
                            wadd.Pincode = ReadLine();

                            //Calls the UpdatePincode method of WareHouseAddressBusinessLogicLayer
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
                } while (check == false);


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
                bool check = false;
                do
                {
                    WriteLine("You chose to Remove the Address by WareHouseId");
                    Write("Enter the WarehouseID of the Address to be Deleted:");
                    WriteLine("The WareHouse Id should start with WHID and of length 6.It shouldn't contain special characters");
                    //Reads the WarehouseID and is stored in a reference variable
                    string whID = ReadLine();
                    try
                    {
                        WareHouseAddress addr = wabl.GetAddressByWareHouseID(whID);
                        // Condition to check whether WarHouseId exists or not
                        if (addr!=null)
                        {
                            check = true;
                            //Calls the RemoveAddressByWareHouseID method of WareHouseAddressBusinessLogicLayer
                            wabl.RemoveAddressByWareHouseID(whID);
                            WriteLine("Warehouse Removed");
                        }
                    }
                    catch (WareHouseException ex)
                    {
                        WriteLine(ex.Message);
                    }
                } while (check == false);

            }




            //Local function to REMOVE an address of the Warehouse by addressID
            void RemoveAddressByAddressID()
            {
                bool check = false;
                do
                {
                    WriteLine("You chose to Remove the Address by AddressId");
                    Write("Enter the AddressId to be Deleted:");
                    WriteLine("The Address Id should start with W and of length 4.It shouldn't contain special characters");

                    //Reads the entered AddressId
                    string addressId = ReadLine();
                    try
                    {
                        WareHouseAddress addr=wabl.GetAddressByAddressID(addressId);
                        // Condition to check whether AddressId exists or not
                        if (addr!=null)
                        {
                            check = true;
                            //Calls the RemoveAddressByAddressID method of WareHouseAddressBusinessLogicLayer
                            wabl.RemoveAddressByAddressID(addressId);
                            WriteLine("Warehouse Removed");
                        }
                    }
                    catch (WareHouseException ex)
                    {
                        WriteLine(ex.Message);
                    }
                } while (check == false);
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
