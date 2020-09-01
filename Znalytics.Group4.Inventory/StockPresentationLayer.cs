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
                            case 2:
                            GetAllStocks();
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
           
            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer(); // creation stockBusinessLogic object
            Stock stock = new Stock();//creation of stock object of entite Layer
            bool check = false;
            
                System.Console.WriteLine("Enter StockID");
                stock.StockID = System.Console.ReadLine();
                
                
             do
             {
                try
                {
                    bool check1 = false;
                        System.Console.WriteLine("Enter WareHouseID");
                        System.Console.WriteLine("It should not contain spaces and length be exactly 6");
                        stock.WareHouseID = System.Console.ReadLine();
                        if (wareHousePresentation.CheckWareHouseId(stock.WareHouseID) == true)
                        {
                            do
                            {
                            try
                            {
                                check = true;
                                System.Console.WriteLine("Enter Address ID");
                                System.Console.WriteLine("It should not contain spaces or Special Characters and length should be exactly 4");
                                stock.AddressID = System.Console.ReadLine();
                                if (wareHousePresentation.CheckAddressId(stock.AddressID))
                                {
                                    bool check2 = false;
                                    check1 = true;
                                    do
                                    {
                                        try
                                        {
                                            System.Console.WriteLine("Enter Product ID");
                                            System.Console.WriteLine("Product ID Should not NULL and ProductID Should Start with PID and 0-9 number and length should be 6");
                                            stock.ProductID = System.Console.ReadLine();
                                            if (productBusinessLogic.CheckProductID(stock.ProductID))
                                            {
                                                check2 = true;

                                                System.Console.WriteLine("Enter no of Quantities u want to add");
                                                stock.Quantity = System.Convert.ToInt32(System.Console.ReadLine());

                                                stockBusinessLogicLayer.AddStock(stock);
                                                Console.WriteLine("Stock Added Sucessfully!!");

                                            }
                                        }

                                        catch (StockException e)
                                        {
                                            System.Console.WriteLine(e.Message);
                                        }
                                    } while (check2 == false);
                                }
                            }
                            catch (StockException e)
                            {
                                System.Console.WriteLine(e.Message);
                            }

                        } while (check1 == false);

                        }
                    }
                catch (StockException e)
                {
                    System.Console.WriteLine(e.Message);
                }

            } while (check == false);
           

          
        }
        /// <summary>
        /// local static funtion that calculates product stock of particular warehouseid and warehouse addressid of a product
        /// </summary>
        /// <param name="warehouseID">parameter that accepts warehouseid of string type</param>
        /// <param name="addressID">parameter that accepts Address of string type</param>
        /// <returns> total stock availability of stock of a product</returns>
        public static void  GetAllStocks()
        {
                ProductBusiness productBusinessLogic = new ProductBusiness();
                MenuPrensentor wareHousePresentation = new MenuPrensentor();
                StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
                Stock stock = new Stock();
                bool check = false;
                do
                {

                try
                {
                    System.Console.WriteLine("Enter WareHouseID");
                    System.Console.WriteLine("It should not contain spaces and length be exactly 6");
                    stock.WareHouseID = System.Console.ReadLine();
                    if (wareHousePresentation.CheckWareHouseId(stock.WareHouseID));
                    {
                        bool check1 = false;
                        check = true;
                        do
                        {
                            try
                            {
                                System.Console.WriteLine("Enter Address ID");
                                System.Console.WriteLine("It should not contain spaces or Special Characters and length should be exactly 4");
                                stock.AddressID = System.Console.ReadLine();
                                if (wareHousePresentation.CheckAddressId(stock.AddressID))
                                {
                                    check1 = true;
                                    List<Stock> stocks = stockBusinessLogicLayer.GetAllStocks(stock.WareHouseID, stock.AddressID);

                                    System.Console.WriteLine("ProductID     " + "      " + "StockAvalibale");
                                    foreach (Stock item in stocks)
                                    {

                                        System.Console.WriteLine(item.ProductID + "  " + item.TotalQuantity);
                                    }
                                }
                            }
                            catch (StockException e)
                            {
                                System.Console.WriteLine(e.Message);
                            }
                        } while (check1 == false);
                    } 
                }
                catch (StockException e)
                {
                    System.Console.WriteLine(e.Message);
                }
            } while (check == false);
           
        }

      


        /// <summary>
        /// used to update the stock of the product 
        /// </summary>
        public void UpdateStockQuantity()
        {
            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            ProductBusiness productBusinessLogic = new ProductBusiness();
            MenuPrensentor wareHousePresentation = new MenuPrensentor();
            bool check = false;
            do
            {
                try
                {

                    System.Console.WriteLine("enter to which WarehouseId you want to update the quantity:");
                    System.Console.WriteLine("It should not contain spaces and length be exactly 6");
                    stock.WareHouseID = System.Console.ReadLine();
                    if (wareHousePresentation.CheckWareHouseId(stock.WareHouseID)) ;
                    {
                        bool check1 = false;
                        check = true;
                        do
                        {
                            try
                            {
                                System.Console.WriteLine("enter to which WarehouseAddress you want to update the quantity:");
                                System.Console.WriteLine("It should not contain spaces or Special Characters and length should be exactly 4");
                                stock.AddressID = System.Console.ReadLine();
                                if (wareHousePresentation.CheckAddressId(stock.AddressID))
                                {
                                    bool check2 = false;
                                    check1 = true;
                                    do
                                    {
                                        try
                                        {
                                            System.Console.WriteLine("enter to which ProductID you want to update the quantity");
                                            System.Console.WriteLine("Product ID Should not NULL and ProductID Should Start with PID and 0-9 number and length should be 6");
                                            stock.ProductID = System.Console.ReadLine();
                                            if (productBusinessLogic.CheckProductID(stock.ProductID))
                                            {
                                                check2 = true;
                                                System.Console.WriteLine("enter the quantity to be updated:");
                                                stock.Quantity = System.Convert.ToInt32(System.Console.ReadLine());

                                                stockBusinessLogicLayer.UpdateStockQuantity(stock);
                                                System.Console.WriteLine("Stock quntity Updated Sucessfully");
                                            }
                                        }
                                        catch (StockException e)
                                        {
                                            System.Console.WriteLine(e.Message);
                                        }
                                    } while (check2 == false);
                                }
                            }
                            catch (StockException e)
                            {
                                System.Console.WriteLine(e.Message);
                            }
                        } while (check1 == false);
                    }
                }
                catch (StockException e)
                {
                    System.Console.WriteLine(e.Message);
                }
            } while (check== false);

        }
    }
}