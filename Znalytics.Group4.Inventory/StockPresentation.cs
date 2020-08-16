class StockDetails
{
    static void Main()
    {
        Stock s;
        s = new Stock();
        System.Console.WriteLine("enter wareHouse,AddressID,ProductId");
        //s.SetWareHouseID(System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()));
        s.WearHouseID(System.Convert.ToInt32(System.Console.ReadLine))
        System.Console.WriteLine("WearHouseID,AddresssID,ProdctID");
        System.Console.WriteLine(s.GetWareHouseID());
        System.Console.WriteLine(s.GetAddressID());
        System.Console.WriteLine(s.GetProductID());
        System.Console.WriteLine("enter the noof quanties u want to add to the productID" + s.ProductID);
        System.Console.WriteLine(s.AddQuantity(System.Convert.ToInt32(System.Console.ReadLine())));
        System.Console.WriteLine("enter the noof quanties u want to delete to the productID" + s._productID);
        System.Console.WriteLine(s.DeleteQuantity(System.Convert.ToInt32(System.Console.ReadLine())));
        System.Console.WriteLine("quantity available in the productID" + s._productID);
        System.Console.WriteLine(s.UpdateQuantity());
        System.Console.ReadKey();
    }
}