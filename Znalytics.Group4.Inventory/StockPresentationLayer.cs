using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.ProductPresentation;
using System.Xml.Serialization;
using System;

namespace Znalytics.Inventory.StockMaintain.PresentationLayer
{
    class StockPresentationLayer
    {
        public void menu()
        {
            int choice;
            bool b;
            do
            {
                System.Console.WriteLine("1. Add Stock");
                System.Console.Write("Enter Your Choice");
               

                b = int.TryParse(System.Console.ReadLine(), out choice);

                if (b == true)
                {
                    try
                    {
                        switch (choice)
                        {
                            case 1:
                                AddStock();
                                break;

                            default:
                                System.Console.WriteLine("Please Enter the Correct Option");
                                break;


                        }
                    }

                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }

                }
                else
                {
                    System.Console.WriteLine("Please Enter the only digits");
                }


            } while (choice != 6);
        }


    
    /// <summary>
    /// Local Function to Add Stock 
    /// </summary>
        public static void AddStock()
        {
            ProductPresentation productPresentation = new ProductPresentation();
            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            System.Console.WriteLine("Enter WareHouseID");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Address Name");
            stock.AddressID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Product ID");
            stock.ProductID = System.Console.ReadLine();
            if (productPresentation.CheckProductID(stock.ProductID) == true)
            {
                System.Console.WriteLine("Enter no of Quantities u want to add");
                stock.EditStock = System.Convert.ToInt32(System.Console.ReadLine());
                stockBusinessLogicLayer.AddStock(stock);
            }
        }
        public static void DeleteStockByWareHouseID()
        {

            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            System.Console.WriteLine("Enter WareHouseID");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Address Name");
            stock.AddressID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Product ID");
            stock.ProductID =System.Console.ReadLine();
            System.Console.WriteLine("Enter no of Quantities u want to add");
            stock.EditStock = System.Convert.ToInt32(System.Console.ReadLine());
            stockBusinessLogicLayer.DeleteStockByWareHouseID(stock);
        }
        public static void ViewQuantity()
        {
            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            System.Console.WriteLine("Enter WareHouseID");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Address Name");
            stock.AddressID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Product ID");
            stock.ProductID =System.Console.ReadLine();
            int c = stockBusinessLogicLayer.ViewQuantity(stock);
            System.Console.WriteLine(c);
        }
    }
}