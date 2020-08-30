//created bu R.Krushal


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.Entitie;

namespace Znalytics.Inventory.ProductModule.ProductPresentation
{
    class ProductPresentation
    {


        static void Main()
        {

            int choice;
            bool b;
            do
            {
                System.Console.WriteLine("1. Add Product");
                System.Console.WriteLine("2. Show product");
                System.Console.WriteLine("3. Show Product By ID");
                System.Console.WriteLine("4. Delete Product");
                System.Console.WriteLine("5. Update Prroduct");
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



            //local function to add products into List
            void AddProduct()
            {

                Product product = new Product();// creating the object for Product class
                ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class
                bool check1 = false;
                do
                {

                    try
                    {

                        System.Console.WriteLine("enter the ProductId");
                        System.Console.WriteLine("Product ID must start with PID and should be less than 6");
                        product.ProductID = System.Console.ReadLine();


                        if (pb.CheckProductID(product.ProductID) == false) //checking whether the productId avaliable in the list or not to enter unique productId into list
                        {
                            check1 = true;
                            System.Console.WriteLine("enter the ProductName:");
                            System.Console.WriteLine("ProductName must Contain only alphabets");
                            product.ProductName = System.Console.ReadLine();
                            System.Console.WriteLine("enter the Productprice:");
                            product.Price = System.Convert.ToDouble(System.Console.ReadLine());
                            pb.AddProducts(product); //adding the products into the List
                            System.Console.WriteLine("Product Added Sucessfully!!!");


                        }
                    }
                    catch (ProductException e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                } while (check1 == false);



            }

            // Local Function to Dispaly Product Details
            void DisplayProducts()
            {
                ProductBusiness pb = new ProductBusiness();// Creating object for ProductBusiness class
                List<Product> prodts = pb.DispalyProducts();

                System.Console.WriteLine("===============Product Details=============");
                System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "ProductPrice");
                System.Console.WriteLine("-----------------------------------------------------------------------");

                foreach (Product item in prodts)
                {
                    System.Console.WriteLine(item.ProductName + "    " + item.ProductID + "     " + item.Price);// Displaying the products
                }


            }

            // Local function to remove a Product form List
            void RemoveProduct()
            {
                Product Product = new Product();// creating the object fro Product class
                ProductBusiness pb = new ProductBusiness();// Creating object for ProductBusiness class
                bool check1 = false;
                do
                {
                    try
                    {
                        System.Console.Write("Enter the ProductID to be Deleted:");
                        string id = System.Console.ReadLine();
                        if (pb.CheckProductID(id) == true)//checking whether the productId avaliable in the list or not

                        {
                            check1 = true;
                            pb.RemoveProduct(id);
                            System.Console.WriteLine("Product Removed");
                        }
                        else
                        {
                            System.Console.WriteLine("ProductID does not Exixts");
                        }
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                } while (check1 == false);
            }

            // local Function to get details of Product by Id
            void GetProductByID()
            {
                ProductBusiness pb = new ProductBusiness(); // Creating  object for ProductBusiness class
                bool check1 = false;
                do
                {

                    try
                    {
                        System.Console.Write("Enter the ProductID: ");
                        string productID = System.Console.ReadLine();
                        if (pb.CheckProductID(productID))
                        {
                            check1 = true;
                            Product pe = pb.GetProductByProductID(productID);
                            System.Console.WriteLine(pe.ProductID + "     " + pe.ProductName + "      " + pe.Price);
                        }
                        else
                        {
                            throw new ProductException("ProductID Does not Exsits");
                        }
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                } while (check1 == false);



            }

            // local function to update product details
            void UpdateProduct()
            {
                Product product = new Product();// creating the object for Product class
                ProductBusiness pb = new ProductBusiness();// Creating  object for ProductBusiness class

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
                    bool check1 = false;
                    do
                    {
                        try
                        {
                            System.Console.WriteLine("Enter Existing Product ID");
                            product.ProductID = System.Console.ReadLine();
                            if (pb.CheckProductID(product.ProductID))//checking whether the productId avaliable in the list or not
                            {
                                check1 = true;
                                System.Console.WriteLine("Enter new name for Product");
                                product.ProductName = System.Console.ReadLine();

                                pb.UpdateProductName(product);
                                System.Console.WriteLine("ProductName updated!!");

                            }
                            else
                            {
                                throw new ProductException("ProductID does not Exixts");
                            }
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                        }
                    } while (check1 == false);




                }


                // inner function to update a product price by using ProductID
                void UpdateProductPrice()
                {
                    bool check1 = false;
                    do
                    {
                        try
                        {
                            System.Console.WriteLine("Enter Existing Product ID");
                            product.ProductID = System.Console.ReadLine();
                            if (pb.CheckProductID(product.ProductID))//checking whether the productId avaliable in the list or not
                            {
                                check1 = true;
                                System.Console.WriteLine("Enter new Price for Product");
                                product.Price = System.Convert.ToDouble(System.Console.ReadLine());

                                pb.UpdateProductPrice(product);
                                System.Console.WriteLine("Product Price Updated Sucessfully!!!");
                            }
                            else
                            {
                                throw new ProductException("ProductID does not Exixts");
                            }
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                        }
                    } while (check1 == false);
                }

            }
        }
    }
}

