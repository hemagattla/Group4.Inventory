class StockDetails
{
    static void Main()
    {
        Stock s = new Stock();
        System.Console.WriteLine("1.enter the WareHouseID");
        System.Console.WriteLine("2.enter the AddressID");
        System.Console.WriteLine("3.enter the productID");
        System.Console.WriteLine("4.NOTE:enter (1) (if u want to ADD quantity),enter (2) (if u want to DELETE quantity),enter (3)(if u want to UPDATE)");
        System.Console.WriteLine("5.enter the value u want to add (or) delete. )enter the value (0) if u want to get updated quantity details");
        s.SetWareHouseID(System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()));
        //System.Console.WriteLine("WareHouseID is                      AddressID is                         ProductID is                   Quantity is"  );
        System.Console.WriteLine("WareHouseID is:- " + s.GetWareHouseID() + "           AddressID is:- " + s.GetAddressID() + "             ProductID is:- " + s.GetProductID() + "            Quantity is:- " + s.UpDateQuantity());
        System.Console.ReadKey();
    }
}