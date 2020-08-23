// Created By Nitya
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.DataAccessLayer;
using Znalytics.Group4.Inventory.BusinessLogicLayer;
namespace Znalytics.Inventory.WareHouseModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents BusinessLogic class of WareHouse
    /// </summary>

    public class WareHouseBusinessLayer: IWareHouseBusinessLayer
    {

        WareHouseDataAccessLayer d = new WareHouseDataAccessLayer();

        
        
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
            return d.WareHouseList;
        }
        
        //Method to display WareHouse details by WareHouseId
        public WareHouse GetWareHouseByWareHouseID(string WareHouseID)
        {
            return d.WareHouseList.Find(temp => temp.WarehouseId == WareHouseID);
        }


    }
}
     /*  public string getStockStatus()
        {
            return null;
        }
       public int getStockQuantity()
        {
            return 0;
        }
    }*/

