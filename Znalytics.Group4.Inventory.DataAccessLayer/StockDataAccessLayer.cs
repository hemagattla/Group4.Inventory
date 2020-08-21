using System.Collections.Generic;
using Znalytics.Inventory.StockMaintain.Entities;


namespace Znalytics.Inventory.StockMaintain.DataAccessLayer
{
    /// <summary>
    /// This class represents data access logic for Stock
    /// </summary>
    public class StockDataAccessLogic
    {
        //private field
        private static List<Stock> _stocks;

        /// <summary>
        /// Constructor Stock Data Access Logic that initializes collection
        /// </summary>
        static StockDataAccessLogic()
        {
            _stocks = new List<Stock>();
            {
                new Stock() { WareHouseID = "1234", AddressName = "2345", ProductID = "3456", Quantity = 5 },
                new Stock() { WareHouseID = "1234", AddressName = "2345", ProductID = "5678", Quantity = 34}
            };
        }
     

        /// <summary>
        /// Add method with 4 parameters 
       
        public void AddStock(Stock stock)
        {
            Stock st=_stocks.Find(temp=>temp.T)
            _stocks.Add(stock);
        }

        /// <summary>
        /// Delete method with 4 parameters
        /// </summary>
        
        public void DeleteStockByWareHouseID(Stock stock)
        {
            
        }


        /// <summary>
        /// Update method with 3 parameters
        /// </summary>
        
        public void ViewQuantitys(Stock stock)
        {
            Stock matchingData = _stocks.Find(temp => temp.WareHouseID == stock.WareHouseID && temp.AddressName == stock.AddressName && temp.ProductID == stock.ProductID);
            matchingData.Quantity = stock.Quantity;
        }
    }
}
