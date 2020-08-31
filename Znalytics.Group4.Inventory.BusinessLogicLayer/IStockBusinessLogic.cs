//created by R.Krushal

using Znalytics.Inventory.StockMaintain.Entities;
using System.Collections.Generic;


namespace Znalytics.Inventory.StockMaintain.IDataAccessLayer
{
    interface IStockBusinessLogic
    {
        /// <summary>
        /// add stock abstract method used to add stock details into the list
        /// </summary>
        /// <param name="stock">it has all the data entered by the user to insert into the list</param>
        void AddStock(Stock stock);

        /// <summary>
        /// abstract method used to calculate total Quantity of product and get all stock availability of the product
        /// </summary>
        /// <param name="warehouseID">calculation will be done if the warehouseID exits in the stokcs list</param>
        /// <param name="addressID">calculation will be done if the addressID exits in the stokcs list</param>
        /// <returns>stock details of each product in the warehouse of particular loctaion</returns>

        List<Stock> GetAllStocks(string warehouseID, string addressID);

        /// <summary>
        /// abstract methodused to Update the quntity of Stock of Product of Particular WarehouseID and warehouse AddressId
        /// </summary>
        /// <param name="stock">contains user entered information like Warehouseid,warehouse addreesid and Productid</param>
        void UpdateStockQuantity(Stock stock);

    }
}
