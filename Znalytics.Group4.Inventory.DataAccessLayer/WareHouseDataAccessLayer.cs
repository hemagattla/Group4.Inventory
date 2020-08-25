// Created By Nitya

using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
//using Znalytics.Group4.Inventory.DataAccessLayer;
namespace Znalytics.Inventory.WareHouseModule.DataAccessLayer
{
    /// <summary>
    ///     Represents the class for WareHouse Data
    /// </summary>
    public class WareHouseDataAccessLayer
    {
        //Created a list for WareHouse
        private static List<WareHouse> WareHouseList
        {
            set;
            get;
        }
        // Constructor 
        static WareHouseDataAccessLayer()
        {
            WareHouseList = new List<WareHouse>();
        }

        //Method to add details to the list
        public void AddWareHouse(WareHouse warehouseDetails)
        {
            WareHouseList.Add(warehouseDetails);
        }

        // Method to display the added details
        public List<WareHouse> GetWareHouses()
        {
            return WareHouseList;
        }

        //Method to get the WareHouse by WareHouseID
        public WareHouse GetWareHouseByWareHouseID(string WareHouseID)
        {
            WareHouse w;
            w = WareHouseList.Find(temp => temp.WarehouseId == WareHouseID);
            return w;
        }

        public void RemoveWareHouseByID(string wareHouseID) //Removing a Product by using PWareHouse ID
        {
            WareHouseList.RemoveAll(n => n.WarehouseId == wareHouseID);

        }
        public void RemoveWareHouseByName(string wareHouseName)// Removing a Product By using WareHouse Name
        {
            WareHouseList.RemoveAll(n => n.WareHouseName == wareHouseName);
        }

        public void UpdateWareHouseName(WareHouse wareHouse)// update WareHouse Name
        {
            WareHouse w = WareHouseList.Find(n => n.WarehouseId == wareHouse.WarehouseId);
            if (w != null)
            {
                w.WareHouseName = wareHouse.WareHouseName;


            }
        }


        public void UpdateManagerName(WareHouse wareHouse)// update product Name
        {
            WareHouse w = WareHouseList.Find(n => n.WarehouseId == wareHouse.WarehouseId);
            if (w != null)
            {
                w.MangerName = wareHouse.MangerName;
            }
        }
    }
}
