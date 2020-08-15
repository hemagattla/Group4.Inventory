class program
{
    static void Main()
    {
        rawmaterials r;
        r = new rawmaterials();

        System.Console.WriteLine("Enter RawmaterialID");
        r.SetRawmaterialID(System.Convert.ToInt32(System.Console.ReadLine()));
        System.Console.WriteLine(r.GetRawmaterialID());

        System.Console.WriteLine("Enter RawmaterialName");
        r.SetRawmaterialName(System.Console.ReadLine());
        System.Console.WriteLine(r.GetRawmaterialName());

        System.Console.WriteLine("Enter Quantity");
        r.Setquantity(System.Convert.ToDouble(System.Console.ReadLine()));
        System.Console.WriteLine(r.GetQuantity());

        System.Console.WriteLine("Enter unitsused");
        r.SetUnitsused(System.Convert.ToDouble(System.Console.ReadLine()));
        System.Console.WriteLine(r.GetUnitsused());

        System.Console.WriteLine("Available units are");
        r.SetAvailableunits();
        System.Console.WriteLine(System.Convert.ToDouble(r.GetAvailableunits()));


        System.Console.WriteLine("Enter Price");
        r.SetPrice(System.Convert.ToDouble(System.Console.ReadLine()));
        System.Console.WriteLine(r.GetPrice());

        System.Console.ReadKey();



















    }

}
