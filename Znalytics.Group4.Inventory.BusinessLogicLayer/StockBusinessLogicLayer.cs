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
        StockDataAccessLogic _stockDataAccesslogic;
        public StockBusinessLogicLayer()
        {
            _stockDataAccesslogic = new StockDataAccessLogic();
        }

        public void AddStock(Stock stock)
        {
            if ((stock.WareHouseID != null) && (stock.AddressID != null) && (stock.ProductID != 0) && (stock.EditStock != 0))
            {
                IWareHouseBusinessLayer wareHouseBusinessLayer = new WareHouseBusinessLogicLayer();
                IWareHouseAddressBusinessLogicLayer aid = new WareHouseAddressBusinessLogicLayer();
                IProductBusinessLogicLayer productBusinessLogicLayer = new ProductBusiness();
                if (wareHouseBusinessLayer.GetWareHouseByWareHouseID(stock.WareHouseID)!=null)
                    if(aid.GetAddressByAddressID(stock.AddressID)!=null)
                {
                    {
                      if (productBusinessLogicLayer.GetProductByProductID(stock.ProductID) != 0)
                      {
                           _stockDataAccesslogic.AddStock(stock);
                      }
                    }
                }
            }
        }

        public void DeleteStockByWareHouseID(Stock stock)
        {
            if ((stock.WareHouseID != null) && (stock.AddressID != null) && (stock.ProductID != 0) && (stock.Delete != 0))
            {
                if ((stock.WareHouseID != null) && (stock.AddressID != null) && (stock.ProductID != 0) && (stock.EditStock != 0))
                {
                    IWareHouseBusinessLayer wareHouseBusinessLayer = new WareHouseBusinessLogicLayer();
                    IWareHouseAddressBusinessLogicLayer aid = new WareHouseAddressBusinessLogicLayer();
                    IProductBusinessLogicLayer productBusinessLogicLayer = new ProductBusiness();
                    if (wareHouseBusinessLayer.GetWareHouseByWareHouseID(stock.WareHouseID) != null)
                        if (aid.GetAddressByAddressID(stock.AddressID) != null)
                        {
                            {
                                if (productBusinessLogicLayer.GetProductByProductID(stock.ProductID) != 0)
                                {
                                    _stockDataAccesslogic.DeleteStock(stock);
                                }
                            }
                        }
                }
            }
        }

        public int ViewQuantity(Stock stock)
        {
            if ((stock.WareHouseID != null) && (stock.AddressID != null) && (stock.ProductID != 0))
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