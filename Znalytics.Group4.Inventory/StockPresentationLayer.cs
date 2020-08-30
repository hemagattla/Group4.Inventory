﻿using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytic.Inventory.WareHouseModule.PresentationLayer;
using System.Xml.Serialization;

using System;
using System.Collections.Generic;

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
                    System.Console.Write("2. DisplayStock");
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
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }



        /// <summary>
        /// Local Function to Add Stock 
        /// </summary>
        public static void AddStock()
        {
            ProductBusiness productBusiness=new ProductBusiness();
            MenuPrensentor wareHousePresentation = new MenuPrensentor();
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
                    if (productBusiness.CheckProductID(stock.ProductID))
                    {

                        System.Console.WriteLine("Enter no of Quantities u want to add");
                        stock.Quantity = System.Convert.ToInt32(System.Console.ReadLine());
                        
                        stockBusinessLogicLayer.AddStock(stock);
                        Console.WriteLine("Stock Added Sucessfully!!");
                        
                    }
                }
                else
                {
                    throw new StockException("Ware address Does not Exits");
                }

            }
            else
            {
                throw new StockException("Warehouse ID Does not exist");
            }
        }
       
        public static int TotalQuantity(string stockID)
        {

            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            return stockBusinessLogicLayer.TotalQuantity(stockID);
        }

        public static void DisplayStock()
        {
            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            System.Console.WriteLine("Enter WareHouseID");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("Enter AddressID");
            stock.AddressID = System.Console.ReadLine();
            List<Stock> stocks = stockBusinessLogicLayer.DisplayStock(stock);
            foreach (Stock item in stocks)
            {
                System.Console.WriteLine("ProductID     " + "      " + "StockAvalibale");
                System.Console.WriteLine(item.ProductID + "  " + item.TotalQuantity);
            }
           
        }
       


        public void UpdateStockQuantity()
        {
            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            System.Console.WriteLine("enter to which WarehouseId you want to update the quantity:");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("enter to which WarehouseAddress you want to update the quantity:");
            stock.AddressID = System.Console.ReadLine();
            System.Console.WriteLine("enter the quantity to be updated:");
            stock.Quantity = System.Convert.ToInt32(System.Console.ReadLine());

            stockBusinessLogicLayer.UpdateStockQuantity(stock);
            System.Console.WriteLine("Stock quntity Updated Sucessfully");



        }
    }
}