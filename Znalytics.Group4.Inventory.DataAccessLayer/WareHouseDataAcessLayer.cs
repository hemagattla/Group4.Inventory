using System.Collections.Generic;
using Znalytics.Inventory.Group4.WareHouse.Entities;
//using System.Znalytics.Group4.Iventory.BusinessLogicLayer
/// <summary>
/// Represents Data for WareHouse
/// </summary>
namespace Znalytics.Inventory.Group4.WareHouse.DataAccessLayer
{
    public class WareHouseDataAccessLayer
    {
        //Created a list for WareHouse
        public List<WareHouse> WareHouseList
        {
            set;
            get;
        }
        // Constructor 
        public WareHouseDataAccessLayer()
        {
            WareHouseList = new List<WareHouse>();
        }

        //Method to add details to the list
        public void AddWareHouse(WareHouse warehouse)
        {
            WareHouseList.Add(warehouse);
        }

        // Method to display the added details
        public void DisplayWareHouse(WareHouse wareHouse)
        {
            for (int i = 0; i < WareHouseList.Count; i++)
            {
                WareHouse n = WareHouseList[i];
                System.Console.WriteLine("Manager Name ={0},WareHouse Id ={1},Location Id={2},Location Name ={3},pincode ={4},warehouse capacity ={5}, stock status= {6}", n.MangerName, n.WarehouseId, n.LocationId, n.LocationName, n.Pincode, n.WarehouseCapacity, n.WarehouseStatus);
            }


        }
    }
}

