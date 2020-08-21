// Created By Nitya
using static System.Console;
using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;
using Znalytics.Inventory.WareHouseModule.Entities;

namespace Znalytic.Inventory.WareHouseModule.PresentationLayer
{
    class WareHouseLogin
    {
        static void Main()
        {
            //Login
            WriteLine("INVENTORY MANAGEMENT SYSTEM ");
            WriteLine("==================================");
            Write("\nUsername:");
            string userName = ReadLine();
            System.Console.Write("Password:");
            string password = ReadLine();

            if (userName == "system" && password == "manager")
            {
                MenuPresenter.Menu();
            }

            ReadKey();
        }
    }
}
