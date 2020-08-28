using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.BusinessLogicLayer;
namespace Znalytics.Inventory.StockMaintain.PresentationLayer
{
    class StockPresentationLayer
    {
        static void Main()
        {
          
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
        /// <summary>
        /// Local Function to Add Stock 
        /// </summary>
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
            stock.EditStock = System.Convert.ToInt32(System.Console.ReadLine());
           
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
            stock.EditStock = System.Convert.ToInt32(System.Console.ReadLine());
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