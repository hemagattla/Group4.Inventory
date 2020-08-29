using Znalytics.Inventory.StockMaintain.Entities;
namespace Znalytics.Group4.Inventory.StockMaintain.IDataAccessLayer
{
    interface IStockDataAccessLayer
    {
        void AddStock(Stock stock);
        
        int ViewQuantity(Stock stock);
    }
}
