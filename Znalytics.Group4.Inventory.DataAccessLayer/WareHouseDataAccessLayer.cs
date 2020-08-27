// Created By Nitya
//Importing statements
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;

//Created a namespace for DataAccess Layer of WareHouse Module
namespace Znalytics.Inventory.WareHouseModule.DataAccessLayer
{
    /// <summary>
    ///     Represents the class for WareHouse Data
    /// </summary>
    public class WareHouseDataAccessLayer
    {
        //Created a list for WareHouse
        private static List<WareHouse> _wareHouseList
        {
            set;
            get;
        }
        // Constructor 
        static WareHouseDataAccessLayer()
        {
            _wareHouseList = new List<WareHouse>();
        }

        //Method to add details to the list
        public void AddWareHouse(WareHouse warehouseDetails)
        {
            _wareHouseList.Add(warehouseDetails);
        }

        // Method to display the added details
        public List<WareHouse> GetWareHouses()
        {
            return _wareHouseList;
        }

        //Method to get the WareHouse by WareHouseID
        public WareHouse GetWareHouseByWareHouseID(string WareHouseID)
        {
            WareHouse w;
            w = _wareHouseList.Find(temp => temp.WarehouseId == WareHouseID);
            return w;
        }

        public void RemoveWareHouseByID(string wareHouseID) //Removing a Product by using PWareHouse ID
        {
            _wareHouseList.RemoveAll(n => n.WarehouseId == wareHouseID);

        }
        public void RemoveWareHouseByName(string wareHouseName)// Removing a Product By using WareHouse Name
        {
            _wareHouseList.RemoveAll(n => n.WareHouseName == wareHouseName);
        }

        public void UpdateWareHouseName(WareHouse wareHouse)// update WareHouse Name
        {
            WareHouse w = _wareHouseList.Find(n => n.WarehouseId == wareHouse.WarehouseId);
            if (w != null)
            {
                w.WareHouseName = wareHouse.WareHouseName;


            }
        }


        public void UpdateManagerName(WareHouse wareHouse)// update product Name
        {
            WareHouse w = _wareHouseList.Find(n => n.WarehouseId == wareHouse.WarehouseId);
            if (w != null)
            {
                w.MangerName = wareHouse.MangerName;
            }
        }
    }
}
