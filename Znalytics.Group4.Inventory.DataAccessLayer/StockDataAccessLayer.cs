//created by R.Kruushal


using System.Collections.Generic;
using System.Linq;
using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.CustomException;


namespace Znalytics.Inventory.StockMaintain.DataAccessLayer
{
    /// <summary>
    /// This class represents data access logic for Stock
    /// </summary>
    public class StockDataAccessLogic 
    {
        //creating a List private List property
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
            _stocks = new List<Stock>()// creating the Stock List object
            {
                new Stock(){ StockID="1",WareHouseID="WHID01",AddressID="W1A1",ProductID="PID10",Quantity=10 }

            };

        }

        /// <summary>
        /// used to add stock details into the stocks List
        /// </summary>
        /// <param name="stock">its of Stock class type which contains stock details to be stored into the list</param>
        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);

        }


        /// <summary>
        /// used to calculate total Quantity of product
        /// </summary>
        /// <param name="warehouseID">calculation will be done if the warehouseID exits in the stokcs list</param>
        /// <param name="addressID">calculation will be done if the addressID exits in the stokcs list</param>
        /// <returns></returns>

        public int TotalQuantity(string warehouseID, string addressID)
        {
            bool result = _stocks.Exists(temp => temp.WareHouseID == warehouseID && temp.AddressID == addressID);

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
        /// Displaying the number of Stocks available of product in each ware house
        /// </summary>
        /// <param name="stock">it contains the user entered warehouse id and warehouse adddress</param>
        /// <returns> returns Stock List</returns>
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

        /// <summary>
        /// updating the quantity of the product in the warehouse of particular location
        /// </summary>
        /// <param name="stock"> it has user enterd information to update the warehouse of particular loctaion</param>
       public void UpdateStockQuantity(Stock stock)
       {


        }
    }
}
