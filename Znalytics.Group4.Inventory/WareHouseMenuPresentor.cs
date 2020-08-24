using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;
using Znalytics.Inventory.WareHouseModule.Entities;

using static System.Console;
namespace Znalytic.Inventory.WareHouseModule.PresentationLayer
{
    class MenuPresentor
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
                        // case 4:DisplayWareHouse();break;
                        default: break;
                    }
                }
            } while (choice != 6);
        }
        public static void AddWareHouse()
        {
            WareHouse n = new WareHouse();
            WriteLine("you chose to enter the warehouse details");
            WriteLine("Enter Manager Name");
            n.MangerName = ReadLine();
            WriteLine("Enter Warehouse Id");
            n.WarehouseId = ReadLine();
            WriteLine("Enter Location Name");
            //n.LocationName = ReadLine();
            WriteLine("Enter Pincode");
           // n.Pincode = ReadLine();
            WriteLine("Enter Warehouse capacity");
            n.WarehouseCapacity = int.Parse(ReadLine());


            WareHouseBusinessLayer wbl = new WareHouseBusinessLayer();
            wbl.AddWareHouse(n);




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



