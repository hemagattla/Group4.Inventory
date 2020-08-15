class   A
{
    static void Main()
    {
        Product p;
        p = new Product();
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
                        System.Console.WriteLine("Enter the ProductName: ");
                        p.AddProductName(System.Console.ReadLine());
                        System.Console.WriteLine("Enter the ProductID: ");
                        p.AddProductID(int.Parse(System.Console.ReadLine()));
                        System.Console.WriteLine("enter the no Products avaliable");
                        p.SetProductAvalability(int.Parse(System.Console.ReadLine()));

                        System.Console.WriteLine("Product Added Sucessfully!!!");

                        break;
                    case 2:
                        System.Console.WriteLine("===============Product Details=============");
                        System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
                        System.Console.WriteLine("-----------------------------------------------------------------------");
                        System.Console.WriteLine(p.GetProduct() + "        " + p.GetProductID() + "        " + p.GetNoofProducts());

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



        }

    }
}
