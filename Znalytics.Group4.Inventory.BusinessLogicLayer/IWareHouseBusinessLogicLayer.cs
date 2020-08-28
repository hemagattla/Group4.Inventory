// Created By Nitya
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.WareHouseModule.Entities;

namespace Znalytics.Group4.Inventory.IBusinessLogicLayer
{
    /// <summary>
    /// interface
    /// </summary>
   public interface IWareHouseBusinessLogicLayer
    {
        void AddWareHouse(WareHouse warehouse);
         List<WareHouse> GetWareHouses();

        WareHouse GetWareHouseByWareHouseID(string WareHouseID);







    }
}
