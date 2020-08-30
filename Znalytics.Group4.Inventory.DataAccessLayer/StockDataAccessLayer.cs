
using System.Collections.Generic;
using System.Linq;
using Znalytics.Inventory.StockMaintain.Entities;
//using Znalytics.Group4.Inventory.StockMaintain.IDataAccessLayer;
using Znalytics.Inventory.StockMaintain.CustomException;
using System.CodeDom;

namespace Znalytics.Inventory.StockMaintain.DataAccessLayer
{
    /// <summary>
    /// This class represents data access logic for Stock
    /// </summary>
    public class StockDataAccessLogic// : IStockDataAccessLayer
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
            _stocks = new List<Stock>();

        }


        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);

        }


        public int TotalQuantity(string stockID)
        {
            bool result = _stocks.Exists(temp => temp.StockID == stockID);

            if (result == true)
            {
                return _stocks.Select(x => x.Quantity).Sum();
            }
            else
            {
                throw new StockException("no stock id");
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stock"></param>
        /// <returns></returns>
        public List<Stock> DisplayStock(Stock stock)
        {
            bool result = _stocks.Exists(temp => temp.WareHouseID == stock.WareHouseID && temp.AddressID == stock.AddressID);
            if (result == true)
            {
                return _stocks;
            }
            else
            {
                throw new StockException("invlaid WarehouseID or AdressID");
            }
        }

    }
}
