// Created By Nitya

//Importing statements
using System;
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;

//Created a namespace for DataAccess Layer of WareHouse Module
namespace Znalytics.Inventory.WareHouseModule.DataAccessLayer
{
    /// <summary>
    /// Represents the class for WareHouse Data
    /// </summary>
    public class WareHouseDataAccessLayer
    {
        //Created a list for WareHouse
        private static List<WareHouse> _wareHouseList
        {
            set;
            get;
        }
        
        //Static  Constructor 
        static WareHouseDataAccessLayer()
        {
            _wareHouseList = new List<WareHouse>()
            {
                new WareHouse(){WareHouseId="WHID01",WareHouseName="ABC",MangerName="NITYA"},
                new WareHouse(){WareHouseId="WHID02",WareHouseName="ABCD",MangerName="HEMA"},
                new WareHouse(){WareHouseId="WHID03",WareHouseName="ABCDE",MangerName="DHANASRI"},
                new WareHouse(){WareHouseId="WHID04",WareHouseName="ABCDEF",MangerName="KRUSHAL"}

            };
        }

        //Method to ADD details to the list
        public void AddWareHouse(WareHouse warehouseDetails)
        {

            if (_wareHouseList.Exists(temp => temp.WareHouseId == warehouseDetails.WareHouseId))
            {
                _wareHouseList.Add(warehouseDetails);
            }
            else
            {
                throw new Exception("Warehouse already exists");
            }


        }

        // Method to GET the added details
        public List<WareHouse> GetWareHouses()
        {
            return _wareHouseList;
        }

        //Method to GET the WareHouse by WareHouseID
        public WareHouse GetWareHouseByWareHouseID(string WareHouseID)
        {
            WareHouse w;
            w = _wareHouseList.Find(temp => temp.WareHouseId == WareHouseID);
            return w;
        }

        //Method to REMOVE WareHouse by WareHouseID
        public void RemoveWareHouseByID(string wareHouseID) 
        {
            _wareHouseList.RemoveAll(n => n.WareHouseId == wareHouseID);

        }

        //Method to REMOVE WareHouse by WareHouse Name
        public void RemoveWareHouseByName(string wareHouseName)
        {
            _wareHouseList.RemoveAll(n => n.WareHouseName == wareHouseName);
        }

        // Method to UPDATE the WareHouse Name
        public void UpdateWareHouseName(WareHouse wareHouse)
        {
            WareHouse w = _wareHouseList.Find(n => n.WareHouseId == wareHouse.WareHouseId);
            if (w != null)
            {
                w.WareHouseName = wareHouse.WareHouseName;


            }
        }

        // Method to UPDATE the Manager Name
        public void UpdateManagerName(WareHouse wareHouse)
        {
            WareHouse w = _wareHouseList.Find(n => n.WareHouseId == wareHouse.WareHouseId);
            if (w != null)
            {
                w.MangerName = wareHouse.MangerName;
            }
        }
    }
}
