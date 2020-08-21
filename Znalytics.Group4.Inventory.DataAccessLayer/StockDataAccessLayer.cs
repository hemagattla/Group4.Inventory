
using System.Collections.Generic;
using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Group4.Inventory.StockMaintain.DataAccessLayer;


namespace Znalytics.Inventory.StockMaintain.DataAccessLayer
{
    /// <summary>
    /// This class represents data access logic for Stock
    /// </summary>
    public class StockDataAccessLogic : IStockDataAccessLayer
    {
        //private field
        private static List<Stock> _stocks;

        /// <summary>
        /// Constructor Stock Data Access Logic that initializes collection
        /// </summary>
        static StockDataAccessLogic()
        {
            _stocks = new List<Stock>()
            {
                new Stock() { WareHouseID = "1234", AddressName = "kukatpally", ProductID = "3456", Quantity = 5 },
                new Stock() { WareHouseID = "1234", AddressName = "kukatpally", ProductID = "5678", Quantity = 34}
            };
        }


        /// <summary>
        /// Add method with 4 parameters 

        public void AddStock(Stock stock)
        {
            Stock st = _stocks.Find(temp => temp.WareHouseID == stock.WareHouseID);
            if (st != null)
            {
                Stock a = _stocks.Find(temp => temp.AddressName == stock.AddressName);
                if (a != null)
                {
                    Stock b = _stocks.Find(temp => temp.ProductID == stock.ProductID);
                    if (b != null)
                    {
                        b.Quantity = stock.Quantity;
                    }
                }
            }
        }

        /// <summary>
        /// Delete method with 4 parameters
        /// </summary>

        public void DeleteStockByWareHouseID(Stock stock)
        {
            Stock st = _stocks.Find(temp => temp.WareHouseID == stock.WareHouseID);
            if (st != null)
            {
                Stock a = _stocks.Find(temp => temp.AddressName == stock.AddressName);
                if (a != null)
                {
                    Stock b = _stocks.Find(temp => temp.ProductID == stock.ProductID);
                    if (b != null)
                    {
                        b.Quantity = stock.Quantity;
                    }
                }
            }
        }

        public int ViewQuantity(Stock stock)
        {
            Stock matchingData = _stocks.Find(temp => temp.WareHouseID == stock.WareHouseID && temp.AddressName == stock.AddressName && temp.ProductID == stock.ProductID);
            matchingData.Quantity = stock.Quantity;
            return stock.Quantity;
        }
    }
}
