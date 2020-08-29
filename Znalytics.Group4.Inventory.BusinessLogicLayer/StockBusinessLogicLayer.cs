using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.DataAccessLayer;

using Znalytics.Group4.Inventory.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;

using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;
using Znalytics.Inventory.AddressModule.BusinessLogicLayer;
using Znalytics.Inventory.AddressModule.DataAccessLayer;

namespace Znalytics.Inventory.StockMaintain.BusinessLogicLayer
{
    public class StockBusinessLogicLayer
    {
        StockDataAccessLogic stockDataAccesslogic;
        public StockBusinessLogicLayer()
        {
            stockDataAccesslogic = new StockDataAccessLogic();
        }

        public void AddStock(Stock stock)
        {
            if (stock.AddressID != "" && stock.ProductID != "")
            {
                stockDataAccesslogic.AddStock(stock);
            }
        }

        public void DeleteStockByWareHouseID(Stock stock)
        {
            
        }

        public int ViewQuantity(Stock stock)
        {
            return 0;
        }

    }
}