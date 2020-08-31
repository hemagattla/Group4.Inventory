using System;
using System.Collections.Generic;
using Znalytics.Inventory.Module.BusinessLogicLayer;
using Znalytics.Inventory.Module.Entities;
namespace CustPresentationLayer
{
    class CustPresentation
    {
        public void menu()
        {

            int choice = 0;
            do
            {
                Console.WriteLine("Customer MENU");
                Console.WriteLine("1. Add customer");
                Console.WriteLine("2. GetCustomer");
                Console.WriteLine("3. logincustomer");
                Console.WriteLine("4.update customer");
                Console.WriteLine("5. del customer");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                bool b = int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1: AddCustomer(); break;
                    case 2: GetCustomers(); break;
                    case 3: LoginCustomer(); break;
                    case 4: UpdateCustomer(); break;
                    case 5:DelCustomer();break;
                    case 6:GetCustomerByID();
                         break;
                      
                }
            } while (choice != 7);
        }

        static void AddCustomer()
        {
            CustBusiness cbl = new CustBusiness();/// creating object for business logic layer
            Customer c = new Customer();///creating obj for customer class present in entity layer

            Console.Write("Enter cust ID: ");
            c.CustomerId = int.Parse(Console.ReadLine());
            Console.Write("Enter cust id: ");
            c.CustomerName = Console.ReadLine();
            Console.Write("Enter phno ");
            c.MblNo = Console.ReadLine();
            Console.WriteLine("enter email");
            c.Email = Console.ReadLine();
            Console.WriteLine("enter Country");
            c.Country = Console.ReadLine();
            Console.WriteLine("enter state");
            c.State = Console.ReadLine();
            Console.WriteLine("enter city");
            c.City = Console.ReadLine();
            Console.WriteLine("enter pinno");
            c.PinNo = Console.ReadLine();
            Console.WriteLine("enter hno");
            c.HNo = Console.ReadLine();

            cbl.AddCustomer(c);///call's the business logic layer of AddCustomer method///
            Console.WriteLine("customer details are  Added.\n");
        }
        public static void GetCustomers()
        {
            CustBusiness cbl = new CustBusiness();
            List<Customer> customers = cbl.GetCustomers();

            Console.WriteLine("===============   customer Details=============");
            Console.WriteLine("customerID" + "   " + "customerName" + "  " + "mail");
            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Customer item in customers)
            {
                Console.WriteLine(item.CustomerId + " " + item.CustomerName + " " + item.Email + " " + item.PassWord + " " + item.MblNo + " " + item.Country + " " + item.State + " " + item.City + " " + item.HNo + " " + item.PinNo);// Displaying the products
            }

        }
        static void LoginCustomer()
        {
            Console.WriteLine("  =======login form=======");
            Console.WriteLine("===========");
            System.Console.WriteLine("enter name");
            string CustomerName = System.Console.ReadLine();
            System.Console.WriteLine("enter password");
            string PassWord = System.Console.ReadLine();
            CustBusiness cbl = new CustBusiness();
            Tuple<string, string> tuple = new Tuple<string, string>(CustomerName, PassWord);
            Tuple<string, string> e = cbl.LoginCustomer(CustomerName, PassWord);
            Console.WriteLine("valid user");
        }
        static void UpdateCustomer()
        {
            CustBusiness cbl = new CustBusiness();
            Customer c = new Customer();

            Console.Write("Enter Existing customer ID: ");/// updating name and city by using primary key as customerid///
            c.CustomerId = int.Parse(Console.ReadLine());
            Console.Write("enter customer name");
            c.CustomerName = Console.ReadLine();
            cbl.UpdateCustomer(c);
            Console.WriteLine("Customer  Updated");
        }
        static void DelCustomer()
        {
            CustBusiness cbl = new CustBusiness();
            Customer c = new Customer();
            Console.Write("enter customer id");
            c.CustomerId = int.Parse(Console.ReadLine());
            cbl.DelCustomer(c);
            Console.WriteLine("customer has deleted");
        }
        static void GetCustomerByID()
        {

            System.Console.Write("Enter the ProductID: ");
            int CustomerId = int.Parse(System.Console.ReadLine());
            CustBusiness cbl = new CustBusiness();
            Customer b = cbl.GetCustomerById(CustomerId);
            System.Console.WriteLine(b.CustomerId + " " + b.CustomerName + " " + b.MblNo + " " + b.Email + " " + b.City + " " + b.Country + " " + b.HNo + " " + b.State + " " + b.PinNo);


        }

    }
}
