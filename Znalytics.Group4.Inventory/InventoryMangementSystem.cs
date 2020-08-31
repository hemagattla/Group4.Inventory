using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytic.Inventory.WareHouseModule.PresentationLayer;
using Znalytics.Inventory.ProductModule.ProductPresentation;
using Znalytics.Group4.Inventory.RawMaterialModule.PresentationLayer;
using Znalytics.Inventory.StockMaintain.PresentationLayer;
using Znalytics.Group4.Inventory.PresentationLayer;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.PresentationLayer;
using CustPresentationLayer;
using Newtonsoft.Json;


namespace Znalytics.Group4.Inventory
{
    class InventoryMangementSystem
    {
        static void Main()
        {
            System.Console.WriteLine("=============INVENTORY MANAGEMENT SYSTEM=====================");

            int choice;
            do
            {
                System.Console.WriteLine("1. Admin");
                System.Console.WriteLine("2. Customer");
                System.Console.WriteLine("3. Exit");

                bool b = int.TryParse(System.Console.ReadLine(), out choice);

                if (b == true)
                {
                    try
                    {
                        switch (choice)
                        {
                            case 1:
                                Admin();
                                break;
                            case 2:
                                Customer();
                                break;
                            default:
                                System.Console.WriteLine("Please Enter the Correct Option");
                                break;


                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    System.Console.WriteLine("Please Enter the only digits");
                }
            } while (choice != 3);

        }

        public static void Admin()
        {
            System.Console.Write("UserName:");
            string userName = System.Console.ReadLine();
            System.Console.Write("PassWord:");
            string passWord = System.Console.ReadLine();

            if (userName == "Admin" && passWord == "Admin123")
            {
                MenuPrensentor wareHousePresntation = new MenuPrensentor();
                ProductPresentation productPresentation = new ProductPresentation();
                RawMaterialPresentationLayer rawMaterialPresentation = new RawMaterialPresentationLayer();
                StockPresentationLayer stockPresentationLayer = new StockPresentationLayer();
                ProductRawMaterialPresentation productRawMaterialPresentation = new ProductRawMaterialPresentation();
                int option;
                do
                {
                    System.Console.WriteLine("1. WareHouse");
                    System.Console.WriteLine("2. Add Product");
                    System.Console.WriteLine("3. RawMaterialsDetails");
                    System.Console.WriteLine("4. Stock");
                    System.Console.WriteLine("5.Add Product RawMaterial");

                    System.Console.WriteLine("6. Exit");

                    bool b = int.TryParse(System.Console.ReadLine(), out option);

                    if (b == true)
                    {
                        try
                        {
                            switch (option)
                            {
                                case 1:
                                    wareHousePresntation.WareHouseMenu();
                                    break;
                                case 2:
                                    productPresentation.menu();
                                    break;
                                case 3:
                                    rawMaterialPresentation.RawMaterialMenu();
                                    break;
                                case 4:
                                    stockPresentationLayer.menu();
                                    break;
                                case 5:
                                    productRawMaterialPresentation.ProductRawMaterialMenu();
                                    break;
                                default:
                                    System.Console.WriteLine("Please Enter the Correct Option");
                                    break;


                            }
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Please Enter the only digits");
                    }
                } while (option != 3);

            }
            else
            {
                System.Console.WriteLine("Entered UserName/password is invalid (Username contains only Alphabets,password is combination of alphabets & digits and starting letter should be uppercase)");
            }
        }

        public static void Customer()
        {
            int option;
            do
            {
                OrderManagementPresentationLayer orderManagement = new OrderManagementPresentationLayer();
                CustPresentation custpresentation = new CustPresentation();
                System.Console.WriteLine("1. customer details");
                System.Console.WriteLine("2.warehouse details");
                System.Console.WriteLine("3 Display Products");
                System.Console.WriteLine("4 show stock");
                System.Console.WriteLine("5.order");
                 System.Console.WriteLine("6. Exit");

                bool b = int.TryParse(System.Console.ReadLine(), out option);

                if (b == true)
                {
                    try
                    {
                        switch (option)
                        {
                            case 1:custpresentation.menu();

                                break;
                            case 2:

                                break;
                            case 3: break;
                            case 4:break;
                            case 5: orderManagement.Menu();break;
                            default:
                                System.Console.WriteLine("Please Enter the Correct Option");
                                break;


                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    System.Console.WriteLine("Please Enter the only digits");
                }
            } while (option != 3);

        }

    }
}