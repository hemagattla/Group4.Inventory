using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.BusinessLogicLayer;
namespace Znalytics.Inventory.StockMaintain.PresentationLayer
{
    class StockPresentationLayer
    {
        static void Main()
        {
            StockBusinessLogicLayer stockBusinessLogicLayer;
            Stock stock;
            /*System.Console.WriteLine("1.enter the WareHouseID");
            System.Console.WriteLine("2.enter the AddressID");
            System.Console.WriteLine("3.enter the productID");
            System.Console.WriteLine("4.NOTE:enter (1) (if u want to ADD quantity),enter (2) (if u want to DELETE quantity),enter (3)(if u want to UPDATE)");
            System.Console.WriteLine("5.enter the value u want to add (or) delete. )enter the value (0) if u want to get updated quantity details");
            s.SetWareHouseID(System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()), System.Convert.ToInt32(System.Console.ReadLine()));
            //System.Console.WriteLine("WareHouseID is                      AddressID is                         ProductID is                   Quantity is"  );
            System.Console.WriteLine("WareHouseID is:- " + s.GetWareHouseID() + "           AddressID is:- " + s.GetAddressID() + "             ProductID is:- " + s.GetProductID() + "            Quantity is:- " + s.UpDateQuantity());
            System.Console.ReadKey();*/
            int select;
            bool q;
            string i;
            do
            {
                System.Console.WriteLine("1.Add Quantity");
                System.Console.WriteLine("2.Delete Quantity");
                System.Console.WriteLine("3.Update");
                q = int.TryParse(System.Console.ReadLine(), out select);
                if (q == true)
                {
                    switch (select)
                    {
                        case 1:
                            AddStock();
                            break;
                        case 2:
                            DeleteStockByWareHouseID();
                            break;
                        case 3:
                            ViewQuantity();
                            break;
                    }

                }
                else
                {
                    System.Console.WriteLine("Please Enter the only digits");
                }
                System.Console.WriteLine("u want to add quantity to any other product (Yes/No)");
                i = System.Console.ReadLine();
            } while (i == "Yes");


        }
        public static void AddStock()
        {

            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            System.Console.WriteLine("Enter WareHouseID");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Address Name");
            stock.AddressID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Product ID");
            stock.ProductID = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter no of Quantities u want to add");
            stock.Add = System.Convert.ToInt32(System.Console.ReadLine());
            stockBusinessLogicLayer.AddStock(stock);
        }
        public static void DeleteStockByWareHouseID()
        {

            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            System.Console.WriteLine("Enter WareHouseID");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Address Name");
            stock.AddressID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Product ID");
            stock.ProductID =System.Convert.ToInt32( System.Console.ReadLine());
            System.Console.WriteLine("Enter no of Quantities u want to add");
            stock.Delete = System.Convert.ToInt32(System.Console.ReadLine());
            stockBusinessLogicLayer.DeleteStockByWareHouseID(stock);
        }
        public static void ViewQuantity()
        {
            StockBusinessLogicLayer stockBusinessLogicLayer = new StockBusinessLogicLayer();
            stockBusinessLogicLayer = new StockBusinessLogicLayer();
            Stock stock = new Stock();
            System.Console.WriteLine("Enter WareHouseID");
            stock.WareHouseID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Address Name");
            stock.AddressID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Product ID");
            stock.ProductID =System.Convert.ToInt32( System.Console.ReadLine());
            int c = stockBusinessLogicLayer.ViewQuantity(stock);
            System.Console.WriteLine(c);
        }
    }
}