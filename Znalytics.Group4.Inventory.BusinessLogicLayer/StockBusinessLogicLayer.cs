//created by R.Kruushal


using Znalytics.Inventory.StockMaintain.Entities;

using Znalytics.Inventory.StockMaintain.DataAccessLayer;
using System.Collections.Generic;
using Znalytics.Inventory.StockMaintain.CustomException;



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
        /// <param name="stock">it has all the data entered by the user to insert into the list</param>
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
        /// <summary>
        /// used to calculate total Quantity of product and get all stock availability of the product
        /// </summary>
        /// <param name="warehouseID">calculation will be done if the warehouseID exits in the stokcs list</param>
        /// <param name="addressID">calculation will be done if the addressID exits in the stokcs list</param>
        /// <returns>stock details of each product in the warehouse of particular loctaion</returns>
        public List<Stock> GetAllStocks(string warehouseID, string addressID)
        {
            return stockDataAccesslogic.GetAllStocks(warehouseID, addressID);
        }


        /// <summary>
        /// used to Update the quntity of Stock of Product of Particular WarehouseID and warehouse AddressId
        /// </summary>
        /// <param name="stock">contains user entered information like Warehouseid,warehouse addreesid and Productid</param>
        public void UpdateStockQuantity(Stock stock)
        {
            stockDataAccesslogic.UpdateStockQuantity(stock);
        }

    }
}