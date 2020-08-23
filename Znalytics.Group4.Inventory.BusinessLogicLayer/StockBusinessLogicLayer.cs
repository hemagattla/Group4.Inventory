using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.DataAccessLayer;

using Znalytics.Group4.Inventory.BusinessLogicLayer;
using Znalytics.Inventory.Product.BusinessLogicLayer;

using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;

namespace Znalytics.Inventory.StockMaintain.BusinessLogicLayer
{
    public class StockBusinessLogicLayer
    {
        StockDataAccessLogic _stockDataAccesslogic;
        public StockBusinessLogicLayer()
        {
            _stockDataAccesslogic = new StockDataAccessLogic();
        }

        public void AddStock(Stock stock)
        {
            if ((stock.WareHouseID != null) && (stock.AddressID != null) && (stock.ProductID != 0) && (stock.Add != 0))
            {
                IWareHouseBusinessLayer wareHouseBusinessLayer = new WareHouseBusinessLayer();
                IProductBusinessLogicLayer productBusinessLogicLayer = new ProductBusiness();
                if (wareHouseBusinessLayer.GetWareHouseByWareHouseID(stock.WareHouseID)!=null)
                {
                    if(productBusinessLogicLayer.GetProductByProductID(stock.ProductID)!=0)
                    {
                        _stockDataAccesslogic.AddStock(stock);
                    }

                }
               
                
                
                    _stockDataAccesslogic.AddStock(stock);
                
            }
        }

        public void DeleteStockByWareHouseID(Stock stock)
        {
            if ((stock.WareHouseID != null) && (stock.AddressName != null) && (stock.ProductID != null) && (stock.Delete != 0))
            {
                _stockDataAccesslogic.DeleteStockByWareHouseID(stock);
            }
        }

        public int ViewQuantity(Stock stock)
        {
            if ((stock.WareHouseID != null) && (stock.AddressName != null) && (stock.ProductID != null))
            {
               return _stockDataAccesslogic.ViewQuantity(stock);
            }
            else
            {
                throw new System.Exception(" ");
            }
        }

    }
}