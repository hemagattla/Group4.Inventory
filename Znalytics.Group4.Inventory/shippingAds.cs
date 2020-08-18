

class Productshipping
{
    static void Main()
    {
        ShippingAddress s1=new ShippingAddress();
       

        ShippingAddressBusinessLogic s = new ShippingAddressBusinessLogic();
        void AddAddressDetails()
        {
            System.Console.WriteLine("Enter productname");
            string pName = System.Console.ReadLine();
            System.Console.WriteLine("Enter ProductID");
            string pID=(System.Console.ReadLine());
            System.Console.WriteLine("Enter Product price");
            double price=double.Parse(System.Console.ReadLine());
          
            System.Console.WriteLine("Enter Customer Name");
            string cName=(System.Console.ReadLine());
            System.Console.WriteLine("Enter Country Name");
            string countryName=(System.Console.ReadLine());
            System.Console.WriteLine("Enter state Name");
            string sName = (System.Console.ReadLine());
            System.Console.WriteLine("Enter District Name");
            string districtName=(System.Console.ReadLine());
            System.Console.WriteLine("Enter city Name");
            string cityName=(System.Console.ReadLine());
            System.Console.WriteLine("Enter colony");
            string colony=(System.Console.ReadLine());
            System.Console.WriteLine("Enter HouseNO");
            string hNo=(System.Console.ReadLine());
            System.Console.WriteLine("Enter pincode");
            string pinCode=(System.Console.ReadLine());
            System.Console.WriteLine("Enter Mobile Number");
            string mobileNumber=(System.Console.ReadLine());
            System.Console.WriteLine("Enter emailID");
            string emailID=(System.Console.ReadLine());
            ShippingAddress s2 = new ShippingAddress(pName,pID,price,countryName, sName, districtName, cityName, colony, hNo, pinCode,cName,mobileNumber,emailID);
            s.AddProductName(s2);
            s.AddProductID(s2);
            s.AddProductPrice(s2);
            s.AddCustomerName(s2);
            s.AddCountryName(s2);
            s.AddStateName(s2);
            s.AddDistictName(s2);
            s.AddCityName(s2);
            s.AddColonyName(s2);
            s.AddHomeNo(s2);
            s.AddPinCode(s2);
            s.AddMobileNumber(s2);
            s.AddEmailID(s2);
        }
        void ViewAddressDetails()
        {
            System.Console.WriteLine("ProductName:"+s1.ProductName);
          
            System.Console.WriteLine("ProductID:"+s1.ProductID);
           
            System.Console.WriteLine("ProductPrice:"+s1.ProductPrice);
            
            System.Console.WriteLine("CustomerName:"+s1.CustomerName);
           
            System.Console.WriteLine("CountryName:"+s1.CountryName);
        
            System.Console.WriteLine("StateName:"+s1.StateName);
            System.Console.WriteLine("DistrictName:" + s1.DistrictName);
            ;
            System.Console.Write("CityName:"+s1.CityName);
          
            System.Console.Write("ColonyName:"+s1.Colony);
           
            System.Console.Write("HomeNO:"+s1.HomeNo);
          
            System.Console.Write("PinCode:"+s1.PinCode);
            
            System.Console.Write("MobileNumber:"+s1.MobileNumber);
       
            System.Console.Write("EmailID:"+s1.EmailID);
       
        }
        /*void UpdateAdressDetails()
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



        }*/
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
               /* case 2:
                    UpdateAdressDetails();
                    break;*/
                case 3:
                    ViewAddressDetails();

                    break;
            }
        }



    }
}