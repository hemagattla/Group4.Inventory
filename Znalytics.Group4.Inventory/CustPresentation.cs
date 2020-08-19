using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.DataAccessLayer;
using Znalytics.Group4.Inventory.BusinessLogicLayer;
namespace Znalytics.Group4.Inventory.PresntationLayer
{
   public class CustPresentation
    {
        public static void Main()
        {
            Customer c = new Customer();

            CustDataLayer d = new CustDataLayer();
            CustBusiness cbl = new CustBusiness();
            System.Console.WriteLine("enter custid");
            c.CustomerId = (int.Parse(System.Console.ReadLine()));
            System.Console.WriteLine("first name");
            c.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("enter last name ");
            c.LastName = System.Console.ReadLine();
            System.Console.WriteLine("enter mblno");
            c.MblNo = System.Console.ReadLine();
            System.Console.WriteLine("enter mail");
            c.Email = System.Console.ReadLine();
            System.Console.WriteLine("enter country");
            c.Country = System.Console.ReadLine();
            System.Console.WriteLine("enter sate");
            c.State = System.Console.ReadLine();
            System.Console.WriteLine("enter city ");
            c.City = System.Console.ReadLine();
            System.Console.WriteLine("enter street");
            c.Street = System.Console.ReadLine();
            System.Console.WriteLine("enter hno");
            c.HNo = System.Console.ReadLine();
            //getting value of customer
            System.Console.WriteLine("custid is:" + c.CustomerId);
            System.Console.WriteLine("fisrt name is:" + c.FirstName);
            System.Console.WriteLine("last name is:" + c.LastName);
            System.Console.WriteLine("emailis:" + c.Email);
            System.Console.WriteLine("mblnois:" + c.MblNo);
            System.Console.WriteLine("country is:" + c.Country);
            System.Console.WriteLine("state is:" + c.State);
            System.Console.WriteLine("city is:" + c.City);
            System.Console.WriteLine("street" + c.Street);
            System.Console.WriteLine("hno is" + c.HNo);
            while (true)
            {
                System.Console.WriteLine("click 1 if u want to add customer");
                System.Console.WriteLine("click 2 if u want to del customer");
                System.Console.WriteLine("click 3 if u want to update details");
                int a = int.Parse(System.Console.ReadLine());
                switch (a)
                {
                    case 1:
                        cbl.AddCustomer(c);
                        break;
                    case 2:
                        cbl.UpDate(c);
                        break;
                    case 3:
                       cbl.Del(c);
                        break;

                }
            }
        }





        }
    }
