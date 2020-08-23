//Written By Dhanasri
using Znalytics.Group4.Inventory.Entities;
using Znalytics.Group4.Inventory.BusinessLogicLayer;
using System;
using Znalytics.Inventory.ProductShippingAddressModule.Entities;

namespace Znalytics.Group4.Inventory.PresentationLayer
{
    class AddressDetails
    {
        static void Main()
        {
           
        
            
                int choice = -1;

                do
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Products");
                    Console.WriteLine("2. Warehouse");
                    Console.WriteLine("3. Stock Details");
                    Console.WriteLine("4.ProductShippingAddressMenu");
                    Console.WriteLine("5.Exit");
                    bool b = int.TryParse(Console.ReadLine(), out choice);
                    if (b == true)
                    {
                        switch (choice)
                        {
                            case 4 : ProductShippingAddressMenu(); break;
                        }
                    }
                } while (choice != 5);
            }

            public static void ProductShippingAddressMenu()
            {
                int choice = -1;

                do
                {
                    Console.WriteLine("Customers Menu:");
                    Console.WriteLine("1. Add AddressDetails");
                    Console.WriteLine("2. Delete Address Details");
                    Console.WriteLine("3. View Address Details");
                    Console.WriteLine("4. UpdateAddrerss Details");
                    Console.WriteLine("5. Exit");

                    bool b = int.TryParse(Console.ReadLine(), out choice);
                    if (b == true)
                    {
                        switch (choice)
                        {
                            case 1: AddAddressDetails(); break;
                            case 2: DeleteAddressDetails();break;
                            case 3: ViewAddressDetails();break;
                            case 4: UpdateAddressDetails();break;
                            case 5: Console.WriteLine("Exit"); break;
                        }
                    }
                } while (choice != 5);
            }
             shippingAddressBusinessLogic bl = new shippingAddressBusinessLogic();

            public static void AddAddressDetails()
            {
                ProductShippingAddress p = new ProductShippingAddress();
                Console.Write("Enter customer name: ");
                p.CustomerName = Console.ReadLine();
                System.Console.WriteLine("Enter Country Name");
                 p.CountryName = (System.Console.ReadLine());
                System.Console.WriteLine("Enter state Name");
                p.StateName= (System.Console.ReadLine());
                System.Console.WriteLine("Enter District Name");
                p. DistrictName = (System.Console.ReadLine());
                System.Console.WriteLine("Enter city Name");
               p.CityName  = (System.Console.ReadLine());
                System.Console.WriteLine("Enter colony");
               p.Colony  = (System.Console.ReadLine());
                System.Console.WriteLine("Enter HouseNO");
               p.HomeNo = (System.Console.ReadLine());
                System.Console.WriteLine("Enter pincode");
               p.PinCode = (System.Console.ReadLine());
                System.Console.WriteLine("Enter Mobile Number");
                p.MobileNumber = (System.Console.ReadLine());
                System.Console.WriteLine("Enter emailID");
              p.EmailID= (System.Console.ReadLine());

               
              
               bl.AddAddressDetails(p); //call BL

                Console.WriteLine(p.GetType()); 
                Console.WriteLine(p.ToString()); 

                Console.WriteLine(p.GetHashCode()); 


                
                
            }
        
    
            
               
                
                
               
            
            public static void DeleteAddressDetails() { 
    
        Console.WriteLine("Enter the ProductID which you want to delete");
                int ProductID = int.Parse(Console.ReadLine());
                bl.DeleteAddressDetails(ProductID);
        }
    
            public static void ViewAddressDetails() { 

                System.Console.WriteLine("ProductName:" + bl.ProductName);

                Console.WriteLine("ProductID:" + bl.ProductID);

                Console.WriteLine("ProductPrice:" + bl.ProductPrice);
               
                Console.WriteLine("CustomerName:" + bl.CustomerName);

                Console.WriteLine("CountryName:" + bl.CountryName);
                Console.WriteLine("CityName:" + bl.CityName);  

                Console.Write("ColonyName:" + bl.Colony);

                Console.Write("HomeNO:" + bl.HomeNo);

                Console.Write("PinCode:" +bl.PinCode);

                Console.Write("MobileNumber:" + bl.MobileNumber);

               Console.Write("EmailID:" + bl.EmailID);

            }
            public static void UpdateAddressDetails() { 
            
                /*System.Console.WriteLine("Enter which details do you want to change");
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
                        break;*/
                }



            }
           


        }
    
