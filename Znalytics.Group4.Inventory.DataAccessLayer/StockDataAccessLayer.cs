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
        List<Stock> _stocks;

        /// <summary>
        /// Constructor Stock Data Access Logic that initializes collection
        /// </summary>
        public StockDataAccessLogic()
        {
            _stocks = new List<Stock>();
        }

        /// <summary>
        /// Add method with 4 parameters 
        /// </summary>
        /// <param name="WHID">Represents WareHouseID</param>
        /// <param name="AID">Represents AddressID</param>
        /// <param name="PID">Represents ProductID</param>
        /// <param name="ADD">Represents the no.of quantity u want to add</param>
        public void AddStock(Stock st)
        {
            _stocks.Add(st);
        }

        /// <summary>
        /// Delete method with 4 parameters
        /// </summary>
        /// <param name="WHID">Represents WareHouseID</param>
        /// <param name="AID">Represents AddressID</param>
        /// <param name="PID">Represents ProductID</param>
        /// <param name="SUB">Represents the no.of quamtities u want to delete</param>
        public void DeleteStockByWareHouseID(string WareHouseID, string AddressID)
        {
            _stocks.RemoveAll(temp => temp.WareHouseID == WareHouseID && temp.AddressID == AddressID);
        }


        /// <summary>
        /// Update method with 3 parameters
        /// </summary>
        /// <param name="WHID">Represents WareHouseID</param>
        /// <param name="AID">Represents AddressID</param>
        /// <param name="PID">Represents ProductID</param>
        public void UpDateQuantitys(Stock stock)
        {
            Stock matchingData = _stocks.Find(temp => temp.WareHouseID == stock.WareHouseID && temp.AddressID == stock.AddressID && temp.ProductID == stock.ProductID);
            matchingData.Quantity = stock.Quantity;
        }
    }
}
