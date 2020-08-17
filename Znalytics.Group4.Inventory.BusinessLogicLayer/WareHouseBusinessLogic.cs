public class WareHouseBusinessLayer
{
    public void AddWareHouse(WareHouse n)
    {
        if (n.WarehouseId != null)
        {
            DataAccess d = new DataAccess();
            d.AddWareHouse(n);
        }
    }

    public void DisplayWareHouse(WareHouse n)
    {
        DataAccess d = new DataAccess();
        d.DisplayWareHouse(n);

    }
}