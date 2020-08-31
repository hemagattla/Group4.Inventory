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
using Znalytics.Inventory.ProductModule.ProductPresentation;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.StockMaintain.PresentationLayer;
using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.BusinessLogicLayer;

namespace Znalytics.Group4.Inventory.PresentationLayer
{
    /// <summary>
    /// Represents PresentationLayer of OrderManagement
    /// </summary>
    class OrderManagementPresentationLayer
    {
       

        public void Menu()
        {

            int choice = 0;
            do
            {
                Console.WriteLine(" OrdersManagement Menu");
                Console.WriteLine("1. Place Order");
                Console.WriteLine("2. Update OrderDetails");
                Console.WriteLine("3. Cancel Order");
                Console.WriteLine("4. view OrderDetails");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1: PlaceOrder(); break;
                    case 2: UpdateOrderDetails(); break;
                    case 3: CancelOrder(); break;
                    case 4: viewOrderDetails(); break;
                    case 5: Console.WriteLine("Exit"); break;

                }
            } while (choice != 5);
        }
        /// <summary>
        /// Method for Adding OrderDetails to List
        /// </summary>


        public void PlaceOrder()
        {
            try
            {

                OrderManagement order = new OrderManagement();
                OrderManagementBusinessLogicLayer orderBusiness = new OrderManagementBusinessLogicLayer();

                //Displaying WareHouse Details
                Console.WriteLine("==========WareHouseDetails=======");
                List<WareHouse> wareHouses = orderBusiness.GetWareHouses();
                foreach (WareHouse var in wareHouses)
                {
                    Console.WriteLine("WareHouseId:" + var.WareHouseId + "    " + "WareHouseName" + var.WareHouseName + "ManagerName" + "  " + var.MangerName);
                }

                //Displaying WreHouseAddress Details

                Console.WriteLine("============WareHouseAddressDetails============");
                List<WareHouseAddress> wareHouseAddresses = orderBusiness.GetWareHouseAddresses();
                Console.WriteLine("WareHouseID" + "   " + "AddressID" + "  " + "Door Number" + "  " + "LocationName" + "  " + "State" + "  " + "Pincode");
                Console.WriteLine("-----------------------------------------------------------------------");

                foreach (WareHouseAddress item in wareHouseAddresses)
                {
                    Console.WriteLine(item.WareHouseId + "       " + item.AddressId + "     " + item.DoorNumber + "    " + item.LocationName + "     " + item.State + "    " + item.Pincode);
                }

                Console.WriteLine("Enter AddressID of WareHouse Address From where you want Products");
                string AddressId = Console.ReadLine();
               
                Stock stock = new Stock();
                System.Console.WriteLine("Enter WareHouseID");
                stock.WareHouseID = System.Console.ReadLine();
                System.Console.WriteLine("Enter AddressId");
                stock.AddressID = System.Console.ReadLine();
                List<Stock> stocks = orderBusiness.DisplayStock(stock);
                List<string> ProductIDs = stocks.Select(temp => temp.ProductID).Distinct().ToList();
                System.Console.WriteLine("ProductID     " + "      " + "StockAvalibale");
                foreach (string item in ProductIDs)
                {

                    System.Console.WriteLine(item + "  " + orderBusiness.TotalQuantity(stock.WareHouseID, stock.AddressID, item));
                }

            

                //Calling the Method from BusinessLogicLyer to Display the Details of Products and quatity of Products
         
                Console.WriteLine("======ProductDetails=======");

                int choice = 0;
               


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
                            Console.WriteLine("Enter Quantity");
                            int quantity = int.Parse(Console.ReadLine());
                            Dictionary<string, int> PIdQuantity = new Dictionary<string, int>();
                            PIdQuantity[productId] = quantity;
                            order.PIdQuantity = PIdQuantity;
                            Product p = new Product();
                           p= orderBusiness.ProductDetails(productId);
                           
                            order.Products.Add(p);
                            Stock s = new Stock();
                            s.Quantity -= order.PIdQuantity[productId];
                            order.TotalPrice += p.Price * quantity;
                            order.TotalQuantity += quantity;
                            break;


                        case 2: Console.WriteLine("Exit"); break;

                    }
                } while (choice == 1);



                Console.WriteLine("==========AddressDetails Of Customer================");
                Console.WriteLine("Enter your CustomerId to Choose your Address");
                int CustomerId = int.Parse(Console.ReadLine());
                Customer customerAddress = orderBusiness.GetCustomerDetailsByCustomerID(CustomerId);
                Console.WriteLine("price for Selected Products is:" + order.TotalPrice);
                Console.WriteLine("Enter 1 if You want to conform your Order");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    order.OrderID = orderBusiness.OrderID();
                    Console.WriteLine("Your OrderID Is:" + order.OrderID);
                    orderBusiness.AddOrderDetails(order);
                }
                else
                {
                    Console.WriteLine(" you are not Conform your orders, Please TryAgain");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        private string TotalQuantity(object wareHouseID, object addressID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Represents method for updating orderDetails
        /// </summary>
        static void UpdateOrderDetails()
        {
            OrderManagementBusinessLogicLayer orderBusiness = new OrderManagementBusinessLogicLayer();
            int choice = 0;
            do
            {
                Console.WriteLine(" Choose among following which details do you want to update");
                Console.WriteLine("1. Product Details");
                Console.WriteLine("2. Quantity");
                Console.WriteLine("3. WareHouse Details");
                Console.WriteLine("4. Customer AddressDetails");
                Console.WriteLine("5. Exit");


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


                        } while (choice == 1);

                        orderBusiness.UpdateProductDetails(orderId, products);
                        break;
                    case 2:
                        OrderManagement order = new OrderManagement();
                        Console.WriteLine("Enter ProductId");
                        string productid = (Console.ReadLine());
                        Console.WriteLine("Enter the  Quantity that you want to Replace With Existing Quantity");
                        int Quantity = int.Parse(Console.ReadLine());
                        order.PIdQuantity[productid] = Quantity;
                        break;
                    case 3:

                        Console.WriteLine("Enter AddressID");
                        string AddressID = (Console.ReadLine());
                        WareHouseAddress houseAddress = orderBusiness.GetWareHouseByAddressID(AddressID);
                        orderBusiness.UpdateWareHouseAddressDetails(orderId, houseAddress);
                        break;
                    case 4:
                        Console.WriteLine("Enter CustomerID");
                        int customerId = int.Parse(Console.ReadLine());
                        Customer customerAddress = orderBusiness.GetCustomerDetailsByCustomerID(customerId);
                        orderBusiness.UpdateCustomerAddressDetails(orderId, customerAddress);
                        break;

                    case 5: Console.WriteLine("Exit"); break;

                }
            } while (choice != 4);
        }
        /// <summary>
        /// Represents a  Method for cancel order Details
        /// </summary>
        static void CancelOrder()
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
            int EmployeeId = int.Parse(Console.ReadLine());
            List<OrderManagement> orders = orderBusiness.GetOrderDetailsByEmployeeID(EmployeeId);
            foreach (var order in orders)
            {
                foreach (var product in order.Products)
                {

                    Product p = orderBusiness.ProductDetails(product.ProductID);
                    System.Console.WriteLine(p.ProductID + "     " + p.ProductName + "      " + p.Price);
                    Console.WriteLine("Quantity" + order.PIdQuantity[p.ProductID]);
                }
                Console.WriteLine(order.WareHouseAddress.WareHouseId + "       " + order.WareHouseAddress.AddressId + "     " + order.WareHouseAddress.DoorNumber + "    " + order.WareHouseAddress.LocationName + "     " + order.WareHouseAddress.State + "    " + order.WareHouseAddress.Pincode + "     ");
                Console.WriteLine(order.CustomerAddress.CustomerId + "    " + order.CustomerAddress.CustomerName + "  " + order.CustomerAddress.Email + "     " + order.CustomerAddress.Country + "    " + order.CustomerAddress.State + "  " + order.CustomerAddress.City + "    " + order.CustomerAddress.PinNo + "  " + order.CustomerAddress.HNo);
                Console.WriteLine(order.TotalPrice);

            }

        }


    }
}



