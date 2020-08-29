using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group4.Inventory
{
    class InventoryMangementSystem
    {
        static void Main()
        {
            System.Console.WriteLine("=============INVENTORY MANAGEMENT SYSTEM=====================");

            int choice;
            do
            {
                System.Console.WriteLine("1. Admin");
                System.Console.WriteLine("2. Customer");
                System.Console.WriteLine("3. Exit");

                bool b = int.TryParse(System.Console.ReadLine(), out choice);

                if (b == true)
                {
                    try
                    {
                        switch (choice)
                        {
                            case 1:
                                Admin();
                                break;
                            case 2:
                                Customer();
                                break;
                            default:
                                System.Console.WriteLine("Please Enter the Correct Option");
                                break;


                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    System.Console.WriteLine("Please Enter the only digits");
                }
            } while (choice != 3);

        }

        public static void Admin()
        {
            System.Console.Write("UserName:");
            string userName = System.Console.ReadLine();
            System.Console.Write("PassWord:");
            string passWord = System.Console.ReadLine();

            if(userName=="Admin"&&passWord=="Admin123")
            {
                int option;
                do
                {
                    System.Console.WriteLine("1. WareHouse");
                    System.Console.WriteLine("2. Customer");
                    System.Console.WriteLine("3. Exit");

                    bool b = int.TryParse(System.Console.ReadLine(), out option);

                    if (b == true)
                    {
                        try
                        {
                            switch (option)
                            {
                                case 1:
                                    Admin();
                                    break;
                                case 2:
                                    Customer();
                                    break;
                                default:
                                    System.Console.WriteLine("Please Enter the Correct Option");
                                    break;


                            }
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Please Enter the only digits");
                    }
                } while (option != 3);

            }

          
        
        }

    }
}