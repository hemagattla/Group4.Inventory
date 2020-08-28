// Created by Nitya
using System;
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;

namespace Znalytics.Group4.Inventory.DataAccessLayer
{
   public abstract class IWareHouseDataAccessLayer
    {
        //Method to ADD WareHouse details to the list
        public abstract void AddWareHouse(WareHouse warehouse);

        // Method to GET the added details
        public abstract List<WareHouse> GetWareHouses();

        //Method to GET the WareHouse by WareHouseID
        public abstract WareHouse GetWareHouseByWareHouseID(string WareHouseID);
    }
}
