class StockDetails
{
    static void Main()
    {
        Stock s = new Stock();
        /*System.Console.WriteLine("1.enter the WareHouseID");
        System.Console.WriteLine("2.enter the AddressID");
        System.Console.WriteLine("3.enter the productID");
        System.Console.WriteLine("4.NOTE:enter (1) (if u want to ADD quantity),enter (2) (if u want to DELETE quantity),enter (3)(if u want to UPDATE)");
        System.Console.WriteLine("5.enter the value u want to add (or) delete. )enter the value (0) if u want to get updated quantity details");
        s.SetWareHouseID(System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()));
        //System.Console.WriteLine("WareHouseID is                      AddressID is                         ProductID is                   Quantity is"  );
        System.Console.WriteLine("WareHouseID is:- " + s.GetWareHouseID() + "           AddressID is:- " + s.GetAddressID() + "             ProductID is:- " + s.GetProductID() + "            Quantity is:- " + s.UpDateQuantity());
        System.Console.ReadKey();*/
        int select;
        bool q;
        string i;
        do
        {
            System.Console.WriteLine("1.Add Quantity");
            System.Console.WriteLine("2.Delete Quantity");
            System.Console.WriteLine("3.Update");
            q = int.TryParse(System.Console.ReadLine(), out select);
            if (q == true)
            {
                switch (select)
                {
                    case 1:
                        System.Console.WriteLine("Enter WareHouseID");
                        int w = System.Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Enter Address ID");
                        int a = System.Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Enter Product ID");
                        int p = System.Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Enter no of Quantities u want to add");
                        int add = System.Convert.ToInt32(System.Console.ReadLine());
                        s.AddQuantity(WHID: w, AID: a, PID: p, ADD: add);
                        break;
                    case 2:
                        System.Console.WriteLine("Enter WareHouseID");
                        int b = System.Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Enter Address ID");
                        int c = System.Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Enter Product ID");
                        int d = System.Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Enter no of Quantities u want to substract");
                        int sub = System.Convert.ToInt32(System.Console.ReadLine());
                        s.DeleteQuantity(WHID: b, AID: c, PID: d, SUB: sub);
                        break;
                    case 3:
                        System.Console.WriteLine("Enter WareHouseID");
                        int e = System.Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Enter Address ID");
                        int f = System.Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Enter Product ID");
                        int g = System.Convert.ToInt32(System.Console.ReadLine());
                        s.UpDateQuantity(WHID: e, AID: f, PID: g);
                        System.Console.WriteLine("WareHouseID:- " + e + "             AddressID" + f + "              ProductID" + g + "           Quantity" + s.UpDate);
                        break;
                    default:
                        System.Console.WriteLine("Please Enter the Correct Option from 1  to 3");
                        break;
                }

            }
            else
            {
                System.Console.WriteLine("Please Enter the only digits");
            }
            System.Console.WriteLine("u want to add quantity to any other product (Yes/No)");
            i = System.Console.ReadLine();
        } while (i == "Yes");


    }
}