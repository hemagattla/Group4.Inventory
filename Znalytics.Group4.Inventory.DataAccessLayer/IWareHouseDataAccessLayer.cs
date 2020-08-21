using System;
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;

namespace Znalytics.Group4.Inventory.DataAccessLayer
{
    interface IWareHouseDataAccessLayer
    {
        void AddWareHouse(WareHouse warehouse);
        List<WareHouse> GetWareHouses();

        WareHouse GetWareHouseByWareHouseID(string WareHouseID);
    }
}
