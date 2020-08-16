class p
{
    static void Main()
    {
        Customer c;
        Adress c1;
        c = new Customer();
        c1 = new Adress();
        System.Console.WriteLine("enter cust id");
        c.SetCustomerId(int.Parse(System.Console.ReadLine()));
        System.Console.WriteLine("enter first name:");
        c.SetFirstName(System.Console.ReadLine());
        System.Console.WriteLine("enter last name");
        c.SetlastName(System.Console.ReadLine());
        System.Console.WriteLine(" enter mblno");
        c.SetMblNo(System.Console.ReadLine());
        System.Console.WriteLine("eneter email");
        c.SetEmail(System.Console.ReadLine());
        //setting customer adress
        System.Console.WriteLine("enter country");
        c1.SetCountry(System.Console.ReadLine());
        System.Console.WriteLine("enter city");
        c1.SetCity(System.Console.ReadLine());
        System.Console.WriteLine("enter state");
        c1.SetState(System.Console.ReadLine());
        System.Console.WriteLine(" enter street");
        c1.SetStreet(System.Console.ReadLine());
        System.Console.WriteLine("enter pinno");
        c1.SetPinNo(int.Parse(System.Console.ReadLine()));
        System.Console.WriteLine("enter hno");
        c1.SetHNo((System.Console.ReadLine()));
        System.Console.WriteLine("custid :" + c.GetCustomerId());
        System.Console.WriteLine("firstname:" + c.GetFirstName());
        System.Console.WriteLine("lastname:" + c.GetLasttName());
        System.Console.WriteLine("mblno:" + c.GetMblNo());
        System.Console.WriteLine("email:" + c.GetEmail());
        System.Console.WriteLine("country:" + c1.GetCountry());
        System.Console.WriteLine("state:" + c1.GetState());
        System.Console.WriteLine("city:" + c1.GetCity());
        System.Console.WriteLine("street:" + c1.GetStreet());
        System.Console.WriteLine("pinno:" + c1.GetPinNo());
        System.Console.WriteLine("hno:" + c1.GetHNo());
    }
}