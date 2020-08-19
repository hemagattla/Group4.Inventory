using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.WareHouseModule.Entities;

namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{
   public interface IWareHouseBusinessLayer
    {
        void AddWareHouse(WareHouse warehouse);
         List<WareHouse> GetWareHouses();

        WareHouse GetWareHouseByWareHouseID(string WareHouseID);






        //string getStockStatus();
        // int getStockQuantity();

    }
}
