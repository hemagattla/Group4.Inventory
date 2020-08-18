/// <summary>
/// Represents BusinessLogic of WareHouse
/// </summary>
public class WareHouseBusinessLayer
{

    //Method to add details to the list
    public void AddWareHouse(WareHouse n)
    {
        //WareHouse Id should not be null
        if (n.WarehouseId != null)
        {
            DataAccess d = new DataAccess();
            d.AddWareHouse(n);
        }
    }

    // Method to display the added details
    public void DisplayWareHouse(WareHouse n)
    {
        DataAccess d = new DataAccess();
        d.DisplayWareHouse(n);

    }
}