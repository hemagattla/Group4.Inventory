//Written By Dhanasri
using System;
using System.Collections.Generic;
using System.Linq;
using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.AddressModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.Entitie;
using System.Xml.Serialization;

namespace Znalytics.Group4.Inventory
{
   
class OrderManagementPresentationLayer
    {
        static void Main()
        {

            int choice = 0;
            do
            {
                Console.WriteLine("OrdersManagement Menu");
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
                    case 4: viewOrderDetails();break;
                    case 5: Console.WriteLine("Exit");break;

                }
            } while (choice != 5);
        }

        static void AddOrderDetails()
        {
          OrderManagement order = new OrderManagement();/// creating object for business logic layer
            OrderManagementBusinessLogicLayer orderBusiness  = new OrderManagementBusinessLogicLayer();///creating obj for customer class present in entity layer
            Console.WriteLine("======ProductDetails=======");
            List<Product> products=orderBusiness.DispalyProducts();
            Console.WriteLine("The following Products Available :");
            foreach (var product in products)
            {
                Console.WriteLine("ProductName:" +product.ProductName+ "ProductID:"+product.ProductID+"Price:"+product.Price);
            }
            int choice = 0;

            do
            {



                Console.WriteLine("Enter 1 if you want to select one more product otherwise enter 2");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Console.WriteLine("Enter ProductID to select Products that you want to order");
                        int productId = int.Parse(Console.ReadLine());
                        Product Product = orderBusiness.GetProductByProductID(productId);
                        order.Products.Add(Product);
                        break;


                    case 2: Console.WriteLine("Exit"); break;

                }
            } while (choice != 2);
            Console.WriteLine("============WareHouseDetails============");
                
                

           
           
        }
       
           
    }
}

