

using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
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
            System.Console.WriteLine("Manager Name ={0},WareHouse Id ={1},Location Name ={2},pincode ={3},warehouse capacity ={4}, stock status= {5}", n.MangerName, n.WarehouseId, n.LocationName, n.Pincode, n.WarehouseCapacity, n.WarehouseStatus);
        }


    }
}


