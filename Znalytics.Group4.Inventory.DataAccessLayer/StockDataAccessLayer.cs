
using System.Collections.Generic;
using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Group4.Inventory.StockMaintain.IDataAccessLayer;

namespace Znalytics.Inventory.StockMaintain.DataAccessLayer
{
    /// <summary>
    /// This class represents data access logic for Stock
    /// </summary>
    public class StockDataAccessLogic : IStockDataAccessLayer
    {
        //private field
        private static List<Stock> _stocks
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor Stock Data Access Logic that initializes collection
        /// </summary>
        static StockDataAccessLogic()
        {
            _stocks = new List<Stock>()
            {
                new Stock() { WareHouseID = "1234", AddressID = "kukatpally", ProductID = "3456", Quantity = 5 },
                new Stock() { WareHouseID = "1234", AddressID = "kukatpally", ProductID = "5678", Quantity = 34}
            };
        }

    
        public  void StockID(Stock stock)
        {
            _stocks.Add(stock);

        }
        public void GetProductID()
        {

        }
        public void GetWareHouseID()
        {

        }

        public void AddStock(Stock stock)
        {
            throw new System.NotImplementedException();
        }

        public int ViewQuantity(Stock stock)
        {
            throw new System.NotImplementedException();
        }
    }
}
