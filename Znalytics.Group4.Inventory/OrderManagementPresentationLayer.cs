//Written By Dhanasri
using System;
using System.Collections.Generic;
using System.Linq;
using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.AddressModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.Entitie;

using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.Module.Entities;
using Znalytics.Group4.Inventory.BusinessLogicLayer;
using Znalytics.Inventory.ProductShippingAddressModule.Entities;

namespace Znalytics.Group4.Inventory
{
    /// <summary>
    /// Represents PresentationLayer of OrderManagement
    /// </summary>
     class OrderManagementPresentationLayer
    {
        static void Menu()
        {

            int choice = 0;
            do
            {
                Console.WriteLine(" OrdersManagement Menu");
                Console.WriteLine("1. Add OrderDetails");
                Console.WriteLine("2. Update OrderDetails");
                Console.WriteLine("3. Cancel OrderDetails");
                Console.WriteLine("4. view OrderDetails");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddOrderDetails(); break;
                    case 2: UpdateOrderDetails(); break;
                    case 3: CancelOrderDetails(); break;
                    case 4: viewOrderDetails(); break;
                    case 5: Console.WriteLine("Exit"); break;

                }
            } while (choice != 5);
        }
        /// <summary>
        /// Method for Adding OrderDetails to List
        /// </summary>
        static void AddOrderDetails()
        {
            try
            {
                OrderManagement order = new OrderManagement();
                OrderManagementBusinessLogicLayer orderBusiness = new OrderManagementBusinessLogicLayer();///creating obj for customer class present in entity layer
                Console.WriteLine("======ProductDetails=======");
                List<Product> products = orderBusiness.DispalyProducts();
                Console.WriteLine("The following Products Available :");
                foreach (var product in products)
                {
                    Console.WriteLine("ProductName:" + product.ProductName + "ProductID:" + product.ProductID + "Price:" + product.Price);
                }
                int choice = 0;
                order.Price = 0;

                do
                {



                    Console.WriteLine("Enter 1 if you want to select products for Order otherwise enter 2");
                    Console.Write("Enter choice: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter ProductID to select Products that you want to order");
                            string productId = (Console.ReadLine());
                            Product product = orderBusiness.ProductDetails(productId);

                            order.Products.Add(product);
                            order.Price += product.Price;
                            break;


                        case 2: Console.WriteLine("Exit"); break;

                    }
                } while (choice != 2);
                Console.WriteLine("============WareHouseDetails============");
                List<WareHouseAddress> wareHouseAddresses = orderBusiness.GetWareHouseAddresses();
                foreach (var warehouseaddress in wareHouseAddresses)
                {
                    Console.WriteLine(wareHouseAddresses);
                }
                Console.WriteLine("Enter AddressID That You Want choose as a warehouseAddress");
                string AddressId = Console.ReadLine();
                WareHouseAddress houseAddress = orderBusiness.GetWareHouseByAddressID(AddressId);
                order.WareHouseAddress = houseAddress;
                Console.WriteLine("==========AddressDetails================");
                Console.WriteLine("Enter your CustomerId to Choose your Address");
                int CustomerId = int.Parse(Console.ReadLine());
                Customer customerAddress = orderBusiness.GetCustomerDetailsByCustomerID(CustomerId);
                Console.WriteLine("price for Selected Products is:" + order.Price);
                Console.WriteLine("Enter 1 if You want to conform your Order");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    order.OrderID = orderBusiness.OrderID();
                    Console.WriteLine("Your OrderID Is:" + order.OrderID);
                }
                else
                {
                    Console.WriteLine(" you are not sure about orders");
                }
                orderBusiness.AddOrderDetails(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Represents a staticmethod for updating orderDetails
        /// </summary>
        static void UpdateOrderDetails()
        {
            OrderManagementBusinessLogicLayer orderBusiness = new OrderManagementBusinessLogicLayer();
            int choice = 0;
            do
            {
                Console.WriteLine(" Choose among following which details do you want to update");
                Console.WriteLine("1. Product Details");
                Console.WriteLine("2. WareHouse Details");
                Console.WriteLine("3. Customer AddressDetails");
                Console.WriteLine("4. Exit");
                
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter OrderId");
                int orderId = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        List<Product> products = new List<Product>();
                        do
                        {
                            Console.WriteLine("Enter ProductID");
                            string ProductId = (Console.ReadLine());
                            Product p = orderBusiness.ProductDetails(ProductId);
                            
                            products.Add(p);

                            Console.WriteLine("Enter 1 if you want to Update one more product otherwise enter 2");
                            Console.Write("Enter choice: ");
                            choice = int.Parse(Console.ReadLine());

                           
                        } while (choice== 1);
                       
                        orderBusiness.UpdateProductDetails(orderId, products);
                        break;
                    case 2:
                        
                        Console.WriteLine("Enter AddressID");
                        string AddressID = (Console.ReadLine());
                        WareHouseAddress houseAddress = orderBusiness.GetWareHouseByAddressID(AddressID);
                        orderBusiness.UpdateWareHouseAddressDetails(orderId,houseAddress);
                        break;
                    case 3:
                        Console.WriteLine("Enter CustomerID");
                        int customerId = int.Parse(Console.ReadLine());
                        Customer customerAddress = orderBusiness.GetCustomerDetailsByCustomerID(customerId);
                        orderBusiness.UpdateCustomerAddressDetails(orderId, customerAddress);
                        break;
                   
                    case 4: Console.WriteLine("Exit"); break;

                }
            } while (choice != 4);
        }
        /// <summary>
        /// Represents a Static Method for cancel order Details
        /// </summary>
        static void CancelOrderDetails()
        {
            Console.WriteLine("Enter OrderId");
            int orderId = int.Parse(Console.ReadLine());
            OrderManagementBusinessLogicLayer orderBusiness = new OrderManagementBusinessLogicLayer();

            orderBusiness.CancelOrderDetails(orderId);
        }
        /// <summary>
        /// Represents a Method for view OrderDetails
        /// </summary>
        static void viewOrderDetails()
        {
            OrderManagementBusinessLogicLayer orderBusiness = new OrderManagementBusinessLogicLayer();
            Console.WriteLine("Enter EmployeeId");
            int orderId = int.Parse(Console.ReadLine());
            orderBusiness.GetOrderDetailsByEmployeeID(orderId);
        }



    }
}

