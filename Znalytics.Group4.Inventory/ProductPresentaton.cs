//created bu R.Krushal


using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.Entitie;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;
using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;

class ProductPresentation
{


    static void Main()
    {
        //creating object for warehouse to get stock avalibility of product in warehouse
        IWareHouseBusinessLayer wareHouseBusinessLayer = new WareHouseBusinessLogicLayer();


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
                      getStockQuantity();break;//caling getstockquantity method declared locally


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



        void AddProduct()
        {

            Product product = new Product();// creating the object fro ProductDeatils class
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class

            System.Console.WriteLine("enter the ProductName:");
            product.ProductName = System.Console.ReadLine();
            System.Console.WriteLine("enter the ProductId");
            product.ProductID = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter the Productprice:");
            product.Price = System.Convert.ToDouble(System.Console.ReadLine());
            pb.AddProducts(product); //adding the products into the List

            System.Console.WriteLine("Product Added Sucessfully!!!");

        }

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
            void RemoveProductByID()
            {
                System.Console.Write("Enter the ProductID to be Deleted:");
                int id = int.Parse(System.Console.ReadLine());

                pb.RemoveProductByID(id);
                System.Console.WriteLine("Product Removed");


            }
            void RemoveProductByProductName()
            {
                System.Console.Write("Enter the ProductName:");
                string name = System.Console.ReadLine();

                pb.RemoveProductByName(name);
                System.Console.WriteLine("Product Removed");
            }




        }


        void GetProductByID()
        {

            System.Console.Write("Enter the ProductID: ");
            int productID = int.Parse(System.Console.ReadLine());
            ProductBusiness pb = new ProductBusiness();
            Product pe = pb.GetProductByProductID(productID);
            System.Console.WriteLine(pe.ProductID + "     " + pe.ProductName + "      " + pe.Price);

        }

        void UpdateProduct()
        {
            Product product = new Product();// creating the object fro ProductDeatils class
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class

            System.Console.WriteLine("1. Update Product Name");
            System.Console.WriteLine("2. Update Product Price");


            int option;

            option = int.Parse("enter your Choice: "+ System.Console.ReadLine());

            switch(option)
            {
                case 1:
                    UpdateProductName();break;
                
                case 2:
                    UpdateProductPrice();break;
                   
            }

            void UpdateProductName()
            {

                System.Console.WriteLine("Enter Existing Product ID");
                product.ProductID = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter new name for Product");
                product.ProductName = System.Console.ReadLine();

                pb.UpdateProductName(product);
            
            }

           

            void UpdateProductPrice()
            {
                System.Console.WriteLine("Enter Existing Product ID");
                product.ProductID = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter new Price for Product");
                product.Price = System.Convert.ToDouble(System.Console.ReadLine());

                pb.UpdateProductPrice(product);
                System.Console.WriteLine("Product Price Updated Sucessfully!!!");
            }

        }

        void getStockQuantity()
        {
            System.Console.WriteLine("enter the product Id:");
            int pid = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("no of Products Available:"+ wareHouseBusinessLayer.getStockQuantity(pid));
        }



    }


}
