//created by R.Kruushal


using Znalytics.Inventory.StockMaintain.Entities;

using Znalytics.Inventory.StockMaintain.DataAccessLayer;
using System.Collections.Generic;
using Znalytics.Inventory.StockMaintain.CustomException;

//using Znalytics.Group4.Inventory.BusinessLogicLayer;
//using Znalytics.Inventory.ProductModule.BusinessLogicLayer;

//using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;
//using Znalytics.Group4.Inventory.IBusinessLogicLayer;
//using Znalytics.Inventory.AddressModule.BusinessLogicLayer;
//using Znalytics.Inventory.AddressModule.DataAccessLayer;

namespace Znalytics.Inventory.StockMaintain.BusinessLogicLayer
{
    public class StockBusinessLogicLayer
    {
        StockDataAccessLogic stockDataAccesslogic;
        /// <summary>
        /// parameterless Constructor creates an object when Stockbusiness layer object is created
        /// </summary>
        public StockBusinessLogicLayer()
        {
            stockDataAccesslogic = new StockDataAccessLogic();
        }
        /// <summary>
        /// used to add stock details into the list
        /// </summary>
        /// <param name="stock"></param>
        public void AddStock(Stock stock)
        {
            if (stock.AddressID != "" && stock.ProductID != "")
            {
                stockDataAccesslogic.AddStock(stock);
            }
            else
            {
                throw new StockException("no null values allowed");
            }
        }

        public int TotalQuantity(string warehouseID, string addressID, string productID)
        {
            return stockDataAccesslogic.TotalQuantity(warehouseID, addressID, productID);
        }
        /// <summary>
        /// Displaying the Stock details of products in particular warehouse and warehouse Address
        /// </summary>
        /// <param name="stock">gettig details like warehouse and warehouse address from user to dispaly products</param>
        /// <returns></returns>
        public List<Stock> DisplayStock(Stock stock)
        {
            return stockDataAccesslogic.DisplayStock(stock);
        }
        /// <summary>
        /// used to Update the quntity of Stock of Product of Particular WarehouseID and warehouse AddressId
        /// </summary>
        /// <param name="stock">contains user entered information like Warehouseid,warehouse addreesid and Productid</param>
        public  void UpdateStockQuantity(Stock stock)
        {
            stockDataAccesslogic.UpdateStockQuantity(stock);
        }

    }
}