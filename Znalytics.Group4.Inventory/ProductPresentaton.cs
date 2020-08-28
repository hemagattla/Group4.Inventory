//created bu R.Krushal


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.Entitie;
//using Znalytics.Group4.Inventory.IBusinessLogicLayer;
//using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;

class ProductPresentation
{


    static void Main()
    {
        //creating object for warehouse to get stock avalibility of product in warehouse
        // IWareHouseBusinessLayer wareHouseBusinessLayer = new WareHouseBusinessLogicLayer();


        int choice;
        bool b;
        do
        {
            System.Console.WriteLine("1. Add Product");
            System.Console.WriteLine("2. Show product");
            System.Console.WriteLine("3. Show Product By ID");
            System.Console.WriteLine("4. Delete Product");
            System.Console.WriteLine("5. Update Prroduct");
            System.Console.WriteLine("6. Stock Available");
            System.Console.WriteLine("7. Exit");

            b = int.TryParse(System.Console.ReadLine(), out choice);

            if (b == true)
            {
                try
                {
                    switch (choice)
                    {
                        case 1:
                            AddProduct(); // calling AddProduct Method declared Locally
                            break;
                        case 2:
                            DisplayProducts();// calling DisplayProducts Method declared Locally
                            break;
                        case 3: GetProductByID(); break; // calling GetProductByID Method declared Locally
                        case 4: RemoveProduct(); break;// calling RemoveProduct Method declared Locally

                        case 5:
                            UpdateProduct(); // calling update Method declared Locally
                            break;
                        case 6:
                        //getStockQuantity(); break;//caling getstockquantity method declared locally


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


        } while (choice != 6);



        //local function to add products into List
        void AddProduct()
        {
            bool a = false;
            Product product = new Product();// creating the object for ProductDeatils class
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class

            System.Console.WriteLine("enter the ProductId");
            product.ProductID = System.Console.ReadLine();

            if (product.ProductID.StartsWith("PID") == true)
            {
                a = true;
                System.Console.WriteLine("enter the ProductName:");
                product.ProductName = System.Console.ReadLine();
                if (ValidateProductName(product.ProductName))
                {
                    System.Console.WriteLine("enter the Productprice:");
                    product.Price = System.Convert.ToDouble(System.Console.ReadLine());
                    pb.AddProducts(product); //adding the products into the List
                    System.Console.WriteLine("Product Added Sucessfully!!!");
                }
                else
                {
                    throw new ProductException("please check Product Name!");


                }
            }
            else
            {
                throw new ProductException("please enter Product Id Starting with PID");
            }


        }

        // Local Function to Dispaly Product Details
        void DisplayProducts()
        {
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class
            List<Product> prodts = pb.DispalyProducts();

            System.Console.WriteLine("===============Product Details=============");
            System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
            System.Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Product item in prodts)
            {
                System.Console.WriteLine(item.ProductName + "    " + item.ProductID + "     " + item.Price);// Displaying the products
            }


        }

        // Local function to remove a Product form List
        void RemoveProduct()
        {
            Product Product = new Product();// creating the object fro ProductDeatils class
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class
            System.Console.WriteLine("select on which type you want to remove a product");
            System.Console.WriteLine("1.on ProductId");
            System.Console.WriteLine("2.on ProductName");
            int Option;
            bool a;
            a = int.TryParse(System.Console.ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1: RemoveProductByID(); break;
                    case 2: RemoveProductByProductName(); break;
                    default: System.Console.WriteLine("Please Choose enter correct Option"); break;

                }

            }
            else
            {
                System.Console.WriteLine("Please Enter Correct Option");
            }

            // Inner function to remove product from List by using Product ID
            void RemoveProductByID()
            {
                System.Console.Write("Enter the ProductID to be Deleted:");
                string id = System.Console.ReadLine();

                pb.RemoveProductByID(id);
                System.Console.WriteLine("Product Removed");


            }

            //Inner Function to remove product from List by using Product name
            void RemoveProductByProductName()
            {
                System.Console.Write("Enter the ProductName:");
                string name = System.Console.ReadLine();

                pb.RemoveProductByName(name);
                System.Console.WriteLine("Product Removed");
            }




        }

        // local Function to get details of Product by Id
        void GetProductByID()
        {

            System.Console.Write("Enter the ProductID: ");
            string productID = System.Console.ReadLine();
            ProductBusiness pb = new ProductBusiness();
            Product pe = pb.GetProductByProductID(productID);
            System.Console.WriteLine(pe.ProductID + "     " + pe.ProductName + "      " + pe.Price);

        }

        // local function to update product details
        void UpdateProduct()
        {
            Product product = new Product();// creating the object fro ProductDeatils class
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class

            System.Console.WriteLine("1. Update Product Name");
            System.Console.WriteLine("2. Update Product Price");


            int option;
            System.Console.Write("enter your Choice: ");
            option = int.Parse(System.Console.ReadLine());

            switch (option)
            {
                case 1:
                    UpdateProductName(); break;

                case 2:
                    UpdateProductPrice(); break;

            }

            // inner function to update a product name by using productID
            void UpdateProductName()
            {

                System.Console.WriteLine("Enter Existing Product ID");
                product.ProductID = System.Console.ReadLine();
                System.Console.WriteLine("Enter new name for Product");
                product.ProductName = System.Console.ReadLine();
                if (ValidateProductName(product.ProductName))
                {
                    pb.UpdateProductName(product);
                }



            }


            // inner function to update a product price by using ProductID
            void UpdateProductPrice()
            {
                System.Console.WriteLine("Enter Existing Product ID");
                product.ProductID = System.Console.ReadLine();
                System.Console.WriteLine("Enter new Price for Product");
                product.Price = System.Convert.ToDouble(System.Console.ReadLine());

                pb.UpdateProductPrice(product);
                System.Console.WriteLine("Product Price Updated Sucessfully!!!");
            }

        }

        /*  void getStockQuantity()
          {
              System.Console.WriteLine("enter the product Id:");
              int pid = int.Parse(System.Console.ReadLine());
              System.Console.WriteLine("no of Products Available:" + wareHouseBusinessLayer.getStockQuantity(pid));
          }
        */

        bool ValidateProductName(string productName)
        {
            bool check = false;
            for (int i = 0; i < productName.Length; i++)
            {
                if (productName[i] >= 'a' && productName[i] <= 'z' || productName[i] >= 'A' && productName[i] <= 'Z' || productName[i] == ' ')
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }

            }


            return check;

        }









    }


}
