

class Program
{
    static void Main()
    {
        ShippingAddress s = new ShippingAddress();
        void AddAddressDetails()
        {
            System.Console.WriteLine("Enter productname");
            s.SetProductName(System.Console.ReadLine());
            System.Console.WriteLine("Enter ProductID");
            s.SetProductID(System.Console.ReadLine());
            System.Console.WriteLine("Enter Product price");
            s.SetProductPrice(double.Parse(System.Console.ReadLine()));
            System.Console.WriteLine("Enter Customer Name");
            s.SetCustomerName(System.Console.ReadLine());
            System.Console.WriteLine("Enter Country Name");
            s.SetCountryName(System.Console.ReadLine());
            System.Console.WriteLine("Enter state Name");
            s.SetStateName(System.Console.ReadLine());
            System.Console.WriteLine("Enter District Name");
            s.SetDistrictName(System.Console.ReadLine());
            System.Console.WriteLine("Enter city Name");
            s.SetCityName(System.Console.ReadLine());
            System.Console.WriteLine("Enter colony");
            s.SetColony(System.Console.ReadLine());
            System.Console.WriteLine("Enter HouseNO");
            s.SetHomeNo(System.Console.ReadLine());
            System.Console.WriteLine("Enter pincode");
            s.SetPinCode(System.Console.ReadLine());
            System.Console.WriteLine("Enter Mobile Number");
            s.SetMobileNumber(System.Console.ReadLine());
            System.Console.WriteLine("Enter emailID");
            s.SetEmailID(System.Console.ReadLine());
        }
        void ViewAddressDetails()
        {
            System.Console.Write("ProductName:");
            System.Console.WriteLine(s.GetProductName());
            System.Console.Write("ProductID:");
            System.Console.WriteLine(s.GetProductID());
            System.Console.Write("ProductPrice:");
            System.Console.WriteLine(s.GetProductPrice());
            System.Console.Write("CustomerName:");
            System.Console.WriteLine(s.GetCustomerName());
            System.Console.Write("CountryName:");
            System.Console.WriteLine(s.GetCountryName());
            System.Console.Write("StateName:");
            System.Console.WriteLine(s.GetStateName());
            System.Console.Write("DistrictName:");
            System.Console.WriteLine(s.GetDistrictName());
            System.Console.Write("CityName:");
            System.Console.WriteLine(s.GetCityName());
            System.Console.Write("ColonyName:");
            System.Console.WriteLine(s.Getcolony());
            System.Console.Write("HomeNO:");
            System.Console.WriteLine(s.GetHomeNo());
            System.Console.Write("PinCode:");
            System.Console.WriteLine(s.GetPinCode());
            System.Console.Write("MobileNumber:");
            System.Console.WriteLine(s.GetMobileNumber());
            System.Console.Write("EmailID:");
            System.Console.WriteLine(s.GetEmailID());
        }
        void UpdateAdressDetails()
        {
            System.Console.WriteLine("Enter which details do you want to change");
            System.Console.WriteLine("1.productName,2.ProductID,3.productPrice,4.customerName,5.countryName,6.stateName,7.districtName,8.cityName,9.colony,10.HomeNo,11.pincode12.MobileNumber,13.emailID");
            System.Console.WriteLine("choose above 1 to 13 options depends on the value which you want to update");
            int choice = (int.Parse("System.Console.ReadLine()"));
            switch (choice)
            {
                case 1:
                    s.SetProductName(System.Console.ReadLine());
                    System.Console.WriteLine("Enter ProductName");
                    break;
                case 2:
                    s.SetProductID(System.Console.ReadLine());
                    System.Console.WriteLine("Enter ProductID");
                    break;
                case 3:
                    s.SetProductPrice(double.Parse(System.Console.ReadLine()));
                    System.Console.WriteLine("Enter Product price");
                    break;
                case 4:
                    s.SetCustomerName(System.Console.ReadLine());
                    System.Console.WriteLine("Enter Customer Name");
                    break;
                case 5:
                    s.SetCountryName(System.Console.ReadLine());
                    System.Console.WriteLine("Enter Country Name");
                    break;
                case 6:
                    s.SetStateName(System.Console.ReadLine());
                    System.Console.WriteLine("Enter state Name");
                    break;
                case 7:
                    s.SetDistrictName(System.Console.ReadLine());
                    System.Console.WriteLine("Enter District Name");
                    break;
                case 8:
                    s.SetCityName(System.Console.ReadLine());
                    System.Console.WriteLine("Enter city Name");
                    break;
                case 9:
                    s.SetColony(System.Console.ReadLine());
                    System.Console.WriteLine("Enter colony");
                    break;
                case 10:
                    s.SetHomeNo(System.Console.ReadLine());
                    System.Console.WriteLine("Enter HouseNO");
                    break;
                case 11:
                    s.SetPinCode(System.Console.ReadLine());
                    System.Console.WriteLine("Enter pincode");
                    break;
                case 12:
                    s.SetMobileNumber(System.Console.ReadLine());
                    System.Console.WriteLine("Enter Mobile Number");
                    break;
                case 13:
                    s.SetEmailID(System.Console.ReadLine());
                    System.Console.WriteLine("Enter emailID");
                    break;
                default:
                    System.Console.ReadLine();
                    break;
            }



        }
        while (true)
        {
            System.Console.WriteLine("1.add 2.update 3.view");
            System.Console.WriteLine("enter your coice from 1 to 3");
            int option = (int.Parse(System.Console.ReadLine()));


            switch (option)
            {
                case 1:
                    AddAddressDetails();

                    break;
                case 2:
                    UpdateAdressDetails();
                    break;
                case 3:
                    ViewAddressDetails();

                    break;
            }
        }



    }
}