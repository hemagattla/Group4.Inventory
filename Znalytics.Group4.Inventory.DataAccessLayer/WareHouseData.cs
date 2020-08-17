using System.Collections.Generic;

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
}

