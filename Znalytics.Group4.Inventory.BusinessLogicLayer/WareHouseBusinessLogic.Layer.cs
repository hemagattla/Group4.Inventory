using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Group4.Inventory.WareHouseModule.DatAcessLayer;
namespace Znalytics.Inventory.WareHouseModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents BusinessLogic class of WareHouse
    /// </summary>

    public class WareHouseBusinessLayer
    {

        //Method to add details to the list
        public void AddWareHouse(WareHouse n)
        {
            //WareHouse Id should not be null
            if (n.WarehouseId != null)
            {
                WareHouseDataAccessLayer d = new WareHouseDataAccessLayer();
                d.AddWareHouse(n);
            }
        }

        // Method to display the added details
        public void DisplayWareHouse(WareHouse n)
        {
            WareHouseDataAccessLayer d = new WareHouseDataAccessLayer();
            d.DisplayWareHouse(n);

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
}
