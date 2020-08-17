using System;
using System.CodeDom;
using System.Xml.Serialization;

class Product
{


    static void Main()
    {
        ProductDetails p = new ProductDetails();


        int Choice;
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
                        System.Console.WriteLine("enter the ProductName:");
                        p.ProductName = System.Console.ReadLine();
                        System.Console.WriteLine("enter the ProductId");
                        p.ProductID = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter the Productprice:");
                        p.Price = System.Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Product Added Sucessfully!!!");

                        break;
                    
       
                    case 2:
                        System.Console.WriteLine("===============Product Details=============");
                        System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
                        System.Console.WriteLine("-----------------------------------------------------------------------");
                        System.Console.WriteLine(p.ProductName + "    " + p.ProductID+"     "+p.Price);

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
