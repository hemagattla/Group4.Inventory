using System.Collections.Generic;
//using System.Znalytics.Group4.Iventory.BusinessLogicLayer

public class DataAccess
{
    public List<WareHouse> wareHouseList
    {
        set;
        get;
    }
    public DataAccess()
    {
        wareHouseList = new List<WareHouse>();
    }

    public void AddWareHouse(WareHouse warehouse)
    {
        wareHouseList.Add(warehouse);
    }
}

