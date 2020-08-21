// Created By Nitya

using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Group4.Inventory.DataAccessLayer;
namespace Znalytics.Inventory.WareHouseModule.DataAccessLayer
{
    /// <summary>
    ///     Represents the class for WareHouse Data
    /// </summary>
    public class WareHouseDataAccessLayer: IWareHouseDataAccessLayer
    {
        //Created a list for WareHouse
        public List<WareHouse> WareHouseList
        {
            set;
            get;
        }
        // Constructor 
        public WareHouseDataAccessLayer()
        {
            WareHouseList = new List<WareHouse>();
        }

        //Method to add details to the list
        public void AddWareHouse(WareHouse warehouse)
        {
            WareHouseList.Add(warehouse);
        }

        // Method to display the added details
        public List<WareHouse> GetWareHouses()
        {
            return WareHouseList;
        }

        public WareHouse GetWareHouseByWareHouseID(string WareHouseID)
        {
            return WareHouseList.Find(temp => temp.WarehouseId == WareHouseID);
        }
    }
}

