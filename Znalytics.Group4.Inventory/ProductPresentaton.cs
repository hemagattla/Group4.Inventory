//created bu R.Krushal


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.Entitie;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;
using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;
namespace Znalytics.Inventory.ProductModule.ProductPresentation
{
    class ProductPresentation
    {


        public void menu()
        {
            //creating object for warehouse to get stock avalibility of product in warehouse
            //IWareHouseBusinessLayer wareHouseBusinessLayer = new WareHouseBusinessLogicLayer();


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
                            // getStockQuantity(); break;//caling getstockquantity method declared locally


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


            } while (choice != 7);
        }


            //local function to add products into List
            public void AddProduct()
            {

                Product product = new Product();// creating the object for ProductDeatils class
                ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class

                System.Console.WriteLine("enter the ProductId");
                product.ProductID = System.Console.ReadLine();

                if (product.ProductID.StartsWith("PID") == true)
                {
                    if (CheckProductID(product.ProductID) == false)
                    {

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
                }
                else
                {
                    throw new ProductException("please enter Product Id Starting with PID");

                }


            }

            // Local Function to Dispaly Product Details
            public void DisplayProducts()
            {
                ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class
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
            public void RemoveProduct()
            {
                Product Product = new Product();// creating the object fro ProductDeatils class
                ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class


                System.Console.Write("Enter the ProductID to be Deleted:");
                string id = System.Console.ReadLine();
                if (CheckProductID(id) == true)
                {
                    pb.RemoveProduct(id);
                    System.Console.WriteLine("Product Removed");
                }
                else
                {
                    System.Console.WriteLine("ProductID does not Exixts");
                }
            }

            // local Function to get details of Product by Id
           public  void GetProductByID()
            {
                ProductBusiness pb = new ProductBusiness();
                System.Console.Write("Enter the ProductID: ");
                string productID = System.Console.ReadLine();
                if (CheckProductID(productID))
                {
                    Product pe = pb.GetProductByProductID(productID);
                    System.Console.WriteLine(pe.ProductID + "     " + pe.ProductName + "      " + pe.Price);
                }
                else
                {
                    throw new ProductException("ProductID Does not Exsits");
                }

            }

            // local function to update product details
           public  void UpdateProduct()
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
                    if (CheckProductID(product.ProductID))
                    {
                        System.Console.WriteLine("Enter new name for Product");
                        product.ProductName = System.Console.ReadLine();
                        if (ValidateProductName(product.ProductName))
                        {
                            pb.UpdateProductName(product);
                            System.Console.WriteLine("ProductName updated!!");
                        }
                        else
                        {
                            throw new ProductException("please check Product Name!");
                        }
                    }
                    else
                    {
                        throw new ProductException("ProductID does not Exixts");
                    }



                }


                // inner function to update a product price by using ProductID
                void UpdateProductPrice()
                {
                    System.Console.WriteLine("Enter Existing Product ID");
                    product.ProductID = System.Console.ReadLine();
                    if (CheckProductID(product.ProductID))
                    {
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

            }

            /* void getStockQuantity()
            {
                System.Console.WriteLine("enter the product Id:");
                int pid = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("no of Products Available:" + wareHouseBusinessLayer.getStockQuantity(pid));
            }*/


            // local function to validateproductname
            public bool ValidateProductName(string productName)
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

            //local function to check ProductID in the List
           public  bool CheckProductID(string productID)
            {

                ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class
                bool result = pb.CheckProductID(productID);
                if (result == true)
                {

                    System.Console.WriteLine("ProductID Exits");
                    return result;
                }
                return result;
            }

    }
}
