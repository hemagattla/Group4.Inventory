//created by R.Kruushal

using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytic.Inventory.WareHouseModule.PresentationLayer;
using Znalytics.Inventory.StockMaintain.CustomException;
using Znalytics.Inventory.ProductModule.ProductPresentation;
using System.Xml.Serialization;

using System;
using System.Collections.Generic;
using System.Linq;

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
                    System.Console.WriteLine("2. DisplayStock");
                    System.Console.WriteLine("3. Update Stock");
                    System.Console.WriteLine("4. Exit");
                    System.Console.Write("Enter Your Choice: ");
                    


                    b = int.TryParse(System.Console.ReadLine(), out choice);

                    if (b == true)
                    {

                        switch (choice)
                        {
                            case 1:
                                AddStock();
                                break;
                            case 2: DisplayStock();
                                break;
                            case 3:
                                UpdateStockQuantity();
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


                } while (choice != 4);
          
        }



        /// <summary>
        /// Local Function to Add Stock 
        /// </summary>
        public static void AddStock()
        {
            ProductBusiness productBusinessLogic=new ProductBusiness();
            MenuPrensentor wareHousePresentation = new MenuPrensentor();
            try
            {
                StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer(); // creation stockBusinessLogic object
                Stock stock = new Stock();//creation of stock object of entite Layer

                System.Console.WriteLine("Enter StockID");
                stock.StockID = System.Console.ReadLine();

                System.Console.WriteLine("Enter WareHouseID");
                stock.WareHouseID = System.Console.ReadLine();
                if (wareHousePresentation.CheckWareHouseId(stock.WareHouseID) == true)
                {
                    System.Console.WriteLine("Enter Address Name");
                    stock.AddressID = System.Console.ReadLine();
                    if (wareHousePresentation.CheckAddressId(stock.AddressID))
                    {
                        System.Console.WriteLine("Enter Product ID");
                        stock.ProductID = System.Console.ReadLine();
                       if (productBusinessLogic.CheckProductID(stock.ProductID))
                       {

                            System.Console.WriteLine("Enter no of Quantities u want to add");
                            stock.Quantity = System.Convert.ToInt32(System.Console.ReadLine());

                            stockBusinessLogicLayer.AddStock(stock);
                            Console.WriteLine("Stock Added Sucessfully!!");

                        }
                    }
                }
            }
            catch(StockException e)
            {
                System.Console.WriteLine(e.Message);
            }

          
        }
        /// <summary>
        /// local static funtion that calculates product stock of particular warehouseid and warehouse addressid of a product
        /// </summary>
        /// <param name="warehouseID">parameter that accepts warehouseid of string type</param>
        /// <param name="addressID">parameter that accepts Address of string type</param>
        /// <returns> total stock availability of stock of a product</returns>
        public static int TotalQuantity(string warehouseID, string addressID, string productID)
        {

            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            return stockBusinessLogicLayer.TotalQuantity(warehouseID, addressID, productID);
        }

        /// <summary>
        /// used to display all the stock details of a product in the particular warehouse id and addressid 
        /// </summary>
        public static void DisplayStock()
        {
            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            System.Console.WriteLine("Enter WareHouseID");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Address Name");
            stock.AddressID = System.Console.ReadLine();
            List<Stock> stocks = stockBusinessLogicLayer.DisplayStock(stock);
            List<string> ProductIDs = stocks.Select(temp => temp.ProductID).Distinct().ToList();
            System.Console.WriteLine("ProductID     " + "      " + "StockAvalibale");
            foreach (string item in ProductIDs)
            {
               
                System.Console.WriteLine(item + "  " + TotalQuantity(stock.WareHouseID, stock.AddressID, item));
            }

        }


        /// <summary>
        /// used to update the stock of the product 
        /// </summary>
        public void UpdateStockQuantity()
        {
            try
            {


                StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
                Stock stock = new Stock();
                System.Console.WriteLine("enter to which WarehouseId you want to update the quantity:");
                stock.WareHouseID = System.Console.ReadLine();
                System.Console.WriteLine("enter to which WarehouseAddress you want to update the quantity:");
                stock.AddressID = System.Console.ReadLine();
                System.Console.WriteLine("enter to which ProductID you want to update the quantity");
                stock.AddressID = System.Console.ReadLine();

                System.Console.WriteLine("enter the quantity to be updated:");
                stock.Quantity = System.Convert.ToInt32(System.Console.ReadLine());

                stockBusinessLogicLayer.UpdateStockQuantity(stock);
                System.Console.WriteLine("Stock quntity Updated Sucessfully");
            }
            catch(StockException e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}