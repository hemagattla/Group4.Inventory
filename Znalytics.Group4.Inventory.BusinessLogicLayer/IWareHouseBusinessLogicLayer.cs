// Created By Nitya

//Importing Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.WareHouseModule.Entities;

namespace Znalytics.Group4.Inventory.IBusinessLogicLayer
{
    /// <summary>
    /// Represents an interface of BusinessLogicLayer
    /// </summary>
   public interface IWareHouseBusinessLogicLayer
    {
        /// <summary>
        /// Method to Add details of WareHouse
        /// </summary>
        /// <param name="warehouse">Represents the object of WareHouse</param>
        void AddWareHouse(WareHouse warehouse);
        
        /// <summary>
        /// Method to Get the list of Warehouses
        /// </summary>
        /// <returns></returns>
        List<WareHouse> GetWareHouses();

        /// <summary>
        /// Method to GetWareHouseByWareHouseID
        /// </summary>
        /// <param name="WareHouseID">Represents WareHouseId</param>
        /// <returns></returns>
        WareHouse GetWareHouseByWareHouseID(string WareHouseID);







    }
}
