using System.Collections.Generic;
//using System.Znalytics.Group4.Iventory.BusinessLogicLayer

public class DataAccess
{
    public List<WareHouse> WareHouseList
    {
        set;
        get;
    }
    public DataAccess()
    {
        WareHouseList = new List<WareHouse>();
    }

    public void AddWareHouse(WareHouse warehouse)
    {
        WareHouseList.Add(warehouse);
    }
    public void DisplayWareHouse(WareHouse wareHouse)
    {
        for (int i = 0; i < WareHouseList.Count; i++)
        {
            WareHouse n = WareHouseList[i];
            System.Console.WriteLine("Manager Name ={0},WareHouse Id ={1},Location Id={2},Location Name ={3},pincode ={4},warehouse capacity ={5}, stock status= {6}", n.MangerName, n.WarehouseId, n.LocationId, n.LocationName, n.Pincode, n.WarehouseCapacity, n.WarehouseStatus);
        }


    }
}

