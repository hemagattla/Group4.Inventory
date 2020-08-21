using Znalytics.Inventory.StockMaintain.Entities;
namespace Znalytics.Group4.Inventory.StockMaintain.DataAccessLayer
{
    interface IStockDataAccessLayer
    {
        void AddStock(Stock stock);
        void DeleteStockByWareHouseID(Stock stock);
        int ViewQuantity(Stock stock);
    }
}
