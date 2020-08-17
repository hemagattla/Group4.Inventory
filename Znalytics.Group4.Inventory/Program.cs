//Created by R.Krushal
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Xml.Serialization;

class Inventory
{


    static void Main()
    {
        
        Product p;// creating a referecnce varibale for product
        p = new Product();
        int Choice;// choice varibale for user input
        bool b;
        while (true)
        {
            System.Console.WriteLine("1. Add Product");
            System.Console.WriteLine("2.Show product");
            System.Console.WriteLine("3. Delete Product");

            b = int.TryParse(System.Console.ReadLine(), out Choice);

            if (b == true)
            {

                switch (Choice)
                {
                    case 1:
                        System.Console.WriteLine("Enter the ProductName: ");
                        string a = System.Console.ReadLine();//reading inputs from user to enter the product name
                        System.Console.WriteLine("Enter the ProductID: ");
                        int c = int.Parse(System.Console.ReadLine());//reading inputs from user to enter the productID
                        p.AddProduct(productname: a, productId: c);//passing the values to set productName and ProductID\
                        System.Console.WriteLine("Product Added Sucessfully!!!");
                        break;
                    case 2:
                        System.Console.WriteLine("===============Product Details=============");
                        System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
                        System.Console.WriteLine("-----------------------------------------------------------------------");
                        System.Console.WriteLine(p.ProductName + "    " + p.ProductID);// printing the Product Details

                        break;

                    default:
                        System.Console.WriteLine("Please Enter the Correct Option");
                        break;


                }
                System.Collections.Generic.List<Product> products = new System.Collections.Generic.List<Product>();
                products.Add(p);


            }
            else
            {
                System.Console.WriteLine("Please Enter the only digits");
            }



        }

    }
}
