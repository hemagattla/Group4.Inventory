using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.ProductPresentation;
using Znalytic.Inventory.WareHouseModule.PresentationLayer;
using System.Xml.Serialization;
using System;

namespace Znalytics.Inventory.StockMaintain.PresentationLayer
{
    class StockPresentationLayer
    {
        public void menu()
        {
            try
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

                        switch (choice)
                        {
                            case 1:
                                AddStock();
                                break;
                            case 2:
                                System.Console.WriteLine("enter StockID");
                                string stockID = System.Console.ReadLine();
                                System.Console.WriteLine(TotalQuantity(stockID));

                                break;

                            default:
                                System.Console.WriteLine("Please Enter the Correct Option");
                                break;


                        }


                    }
                    else
                    {
                        System.Console.WriteLine("Please Enter the only digits");
                    }


                } while (choice != 6);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }



        /// <summary>
        /// Local Function to Add Stock 
        /// </summary>
        public static void AddStock()
        {
            ProductPresentation productPresentation = new ProductPresentation();
            MenuPrensentor wareHousePresentation = new MenuPrensentor();
           StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer(); // creation stockBusinessLogic object
            Stock stock = new Stock();//creation of stock object of entite Layer
            if(wareHousePresentation.)
            System.Console.WriteLine("Enter StockID");
            stock.StockID = System.Console.ReadLine();
            System.Console.WriteLine("Enter WareHouseID");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Address Name");
            stock.AddressID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Product ID");
            stock.ProductID = System.Console.ReadLine();

            System.Console.WriteLine("Enter no of Quantities u want to add");
            stock.quantity = System.Convert.ToInt32(System.Console.ReadLine());
            stockBusinessLogicLayer.AddStock(stock);



            Console.WriteLine("Stock Added Sucessfully!!");

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
            stock.ProductID = System.Console.ReadLine();
            System.Console.WriteLine("Enter no of Quantities u want to add");
            stock.EditStock = System.Convert.ToInt32(System.Console.ReadLine());
            stockBusinessLogicLayer.DeleteStockByWareHouseID(stock);
        }
        public static int TotalQuantity(string stockID)
        {

            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            return stockBusinessLogicLayer.TotalQuantity(stockID);



        }
    }
}