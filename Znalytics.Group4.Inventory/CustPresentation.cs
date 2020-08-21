using System;
using System.Collections.Generic;
using Znalytics.Group4.Inventory.BusinessLogicLayer;
using Znalytics.Group4.Inventory.Entities;

class Program
{
    static void Main()
    {

        int choice = 0;
        do
        {
            Console.WriteLine("Customer MENU");
            Console.WriteLine("1. Add customer");
            Console.WriteLine("2. View customer");
            Console.WriteLine("3. Update customer");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: AddCustomer(); break;
                case 2: DelCustomer(); break;
                case 3: UpdateCustomer(); break;
            }
        } while (choice != 4);
    }

    static void AddCustomer()
    {
        CustBusiness cbl = new CustBusiness();
        Customer c = new Customer();

        Console.Write("Enter Emp ID: ");
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


        cbl.AddCustomer(c);///call's the business logic layer of AddCustomer method///
        Console.WriteLine("customer  Added.\n");
    }
    static void UpdateCustomer()
    {

    }
    static void DelCustomer()
    {

    }
}