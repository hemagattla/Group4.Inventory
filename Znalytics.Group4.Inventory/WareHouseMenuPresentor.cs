using System.Collections.Generic;
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
            n.WarehouseId = ReadLine();
            /*WriteLine("Enter Location Name");
            whd.LocationName = ReadLine();
            WriteLine("Enter Pincode");
            whd.Pincode = ReadLine();
            WriteLine("Enter Warehouse capacity");
            n.WarehouseCapacity = int.Parse(ReadLine());*/


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
                WriteLine(var.WarehouseId + "    " + var.WareHouseName + "  " + var.MangerName);// Displaying the products
            }

        }

        public static void GetWareHouseByWareHouseID()
        {
            WriteLine("Enter WareHouseId");
            string warehouseid = ReadLine();
            WareHouseBusinessLogicLayer wbl = new WareHouseBusinessLogicLayer();
            WareHouse n = wbl.GetWareHouseByWareHouseID(warehouseid);
            WriteLine(n.WarehouseId + " " + n.MangerName);

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
                wareHouse.WarehouseId = ReadLine();
                WriteLine("Enter new name for WareHouse");
                wareHouse.WareHouseName = ReadLine();

                wbl.UpdateWareHouseName(wareHouse);
                WriteLine("WareHouse Name Updated Sucessfully!!!");

            }



            void UpdateManagerName()
            {
                WriteLine("Enter Existing WareHouse ID");
                wareHouse.WarehouseId = ReadLine();
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
            a.WarehouseId = ReadLine();
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
                WriteLine(item.WarehouseId + "    " + item.AddressId + "  " + item.DoorNumber + " " + item.LocationName + "  " + item.State + "  " + item.Pincode);// Displaying the products
            }

        }

    }
    }

















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



