//created bu R.Krushal


using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Znalytics.Inventory.Product.BusinessLogicLayer;
using Znalytics.Inventory.Product.Entities;

class ProductPresentation
{


    static void Main()
    {




        int Choice;
        bool b;
        do
        {
            System.Console.WriteLine("1. Add Product");
            System.Console.WriteLine("2.Show product");
            System.Console.WriteLine("3.Show Product By ID");
            System.Console.WriteLine("4. Delete Product");
            System.Console.WriteLine("5. Upadte Prroduct");
            System.Console.WriteLine("6.Exit");

            b = int.TryParse(System.Console.ReadLine(), out Choice);

            if (b == true)
            {

                switch (Choice)
                {
                    case 1:
                        AddProduct();
                        break;


                    case 2:
                        DisplayProducts();
                        break;
                    case 3: GetProductByID(); break;
                    case 4: RemoveProduct(); break;


                    case 5:
                        UpdateProduct();
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


        } while (Choice != 6);



        void AddProduct()
        {

            ProductEntitie Product = new ProductEntitie();// creating the object fro ProductDeatils class
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class

            System.Console.WriteLine("enter the ProductName:");
            Product.ProductName = System.Console.ReadLine();
            System.Console.WriteLine("enter the ProductId");
            Product.ProductID = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter the Productprice:");
            Product.Price = System.Convert.ToDouble(System.Console.ReadLine());
            pb.AddProducts(Product); //adding the products into the List

            System.Console.WriteLine("Product Added Sucessfully!!!");

        }

        void DisplayProducts()
        {
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class
            List<ProductEntitie> prodts = pb.DispalyProducts();

            System.Console.WriteLine("===============Product Details=============");
            System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
            System.Console.WriteLine("-----------------------------------------------------------------------");

            foreach (ProductEntitie item in prodts)
            {
                System.Console.WriteLine(item.ProductName + "    " + item.ProductID + "     " + item.Price);// Displaying the products
            }


        }

        void RemoveProduct()
        {
            ProductEntitie Product = new ProductEntitie();// creating the object fro ProductDeatils class
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
            ProductEntitie pe = pb.GetProductByID(productID);
            System.Console.WriteLine(pe.ProductID + "     " + pe.ProductName + "      " + pe.Price);

        }

        void UpdateProduct()
        {
            ProductEntitie Product = new ProductEntitie();// creating the object fro ProductDeatils class
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class

            System.Console.WriteLine("1. Update Product Name");
            System.Console.WriteLine("2. Update Product ID");
            System.Console.WriteLine("3. Update Product Price");





        }




    }


}
