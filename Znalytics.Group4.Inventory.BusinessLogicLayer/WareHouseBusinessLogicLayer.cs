// Created By Nitya
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.DataAccessLayer;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;
namespace Znalytics.Inventory.WareHouseModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents BusinessLogic class of WareHouse
    /// </summary>

    public class WareHouseBusinessLogicLayer : IWareHouseBusinessLogicLayer
    {

        WareHouseDataAccessLayer d;

        public WareHouseBusinessLogicLayer()
        {
            d = new WareHouseDataAccessLayer();
        }

        //Method to add details to the list
        public void AddWareHouse(WareHouse n)
        {
            //WareHouse Id should not be null
            if (n.WarehouseId != null)
            {

                d.AddWareHouse(n);
            }
        }

        // Method to display the added details
        public List<WareHouse> GetWareHouses()
        {
            return d.GetWareHouses();
        }

        //Method to display WareHouse details by WareHouseId
        public WareHouse GetWareHouseByWareHouseID(string WareHouseID)
        {
            return d.GetWareHouseByWareHouseID(WareHouseID);
        }
        public void RemoveWareHouseByID(string WareHouseID)
        {
            if (WareHouseID != null)
            {
                d.RemoveWareHouseByID(WareHouseID);
            }
        }
        public void RemoveWareHouseByName(string wareHouseName)
        {
            if (wareHouseName != null)
            {
                d.RemoveWareHouseByName(wareHouseName);
            }
        }

        public void UpdateWareHouseName(WareHouse wareHouse)// update product Name
        {

            if (wareHouse.WarehouseId != null)
            {
                d.UpdateWareHouseName(wareHouse);
            }
        }
        public void UpdateManagerName(WareHouse wareHouse)// update product Name
        {

            if (wareHouse.WarehouseId != null)
            {
                d.UpdateManagerName(wareHouse);
            }
        }


        public int getStockQuantity()
        {
            return 0;
        }

        public int getStockQuantity(int productID)
        {
            throw new System.NotImplementedException();
        }
    }
}
