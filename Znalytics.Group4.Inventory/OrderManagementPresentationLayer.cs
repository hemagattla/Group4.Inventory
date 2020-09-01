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
                string addressId = Console.ReadLine();
                order.WareHouseAddressId = addressId;
               


                System.Console.WriteLine("Enter WareHouseID");
                string wareHouseID = System.Console.ReadLine();
              
                List<Stock> stocks = orderBusiness.GetAllStocks(wareHouseID,addressId);
                
                System.Console.WriteLine("ProductID     " + "      " + "StockAvalibale");
                foreach (var item 
                    in stocks)
                {

                    System.Console.WriteLine(item.ProductID + "  " + item.TotalQuantity);
                }
                System.Console.WriteLine("ProductID     " + "      " + "StockAvalibale");
               
            

                //Calling the Method from BusinessLogicLyer to Display the Details of Products and quatity of Products
         
                Console.WriteLine("======ProductDetails=======");

              Console.WriteLine("Enter ProductID to select Products that you want to order");
                             order.ProductId = (Console.ReadLine());
                            Console.WriteLine("Enter Quantity");
                            int quantity = int.Parse(Console.ReadLine());
                            order.Quantity = quantity;
             Product p = orderBusiness.ProductDetails(order.ProductId);
             order.TotalPrice +=  p.Price* quantity;
                            
                           


                        

                  



                Console.WriteLine("==========AddressDetails Of Customer================");
                Console.WriteLine("Enter your CustomerId to Choose your Address");
                int customerId = int.Parse(Console.ReadLine());
                Customer customerAddress = orderBusiness.GetCustomerDetailsByCustomerID(customerId);
                order.CustomerAddressId = customerId;
                
                Console.WriteLine("price for Selected Products is:" + order.TotalPrice);
                Console.WriteLine("Enter 1 if You want to conform your Order");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    
                    Console.WriteLine("Your OrderID Is:" + orderBusiness.OrderID());
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
                        
                        
                            Console.WriteLine("Enter new ProductID");
                            string ProductId = (Console.ReadLine());
                        
                        orderBusiness.UpdateProductDetails(orderId,ProductId);
                        break;
                    case 2:
                      
                        Console.WriteLine("Enter Quantity");
                        int quantity = int.Parse(Console.ReadLine());
                        orderBusiness.UpdateQuantity(orderId, quantity);
                        break;
                    case 3:

                        Console.WriteLine("Enter AddressID");
                        string AddressID = (Console.ReadLine());
                       
                        orderBusiness.UpdateWareHouseAddressDetails(orderId, AddressID);
                        break;
                    case 4:
                        Console.WriteLine("Enter CustomerID");
                        int customerId = int.Parse(Console.ReadLine());
                     
                        orderBusiness.UpdateCustomerAddressDetails(orderId, customerId);
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



                System.Console.WriteLine("ProductId:"+order.ProductId);
                System.Console.WriteLine("WareHouseId:"+order.WareHouseAddressId);
                System.Console.WriteLine("CustomerAddressId:"+order.CustomerAddressId);
            
                Console.WriteLine("TotalPrice:"+order.TotalPrice);
                Console.WriteLine("Quantity:"+order.Quantity);
            }

        }


    }
}



