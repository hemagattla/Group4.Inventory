﻿using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.DataAccessLayer;
using Znalytics.Group4.Inventory.StockMain.BusinessLogicLayer;
using Znalytics.Group4.Inventory.BusinessLogicLayer;
using Znalytics.Inventory.Product.BusinessLogicLayer;

namespace Znalytics.Inventory.StockMaintain.BusinessLogicLayer
{
    public class StockBusinessLogicLayer: IStockBusinessLogicLayer
    {
        StockDataAccessLogic _stockDataAccesslogic;
        public StockBusinessLogicLayer()
        {
            _stockDataAccesslogic = new StockDataAccessLogic();
        }

        public void AddStock(Stock stock)
        {
            if ((stock.WareHouseID != null) && (stock.AddressName != null) && (stock.ProductID != null) && (stock.Add != 0))
            {
                IProductBusinessLogicLayer productBusinessLogicLayer = new ProductBusiness();
                if (productBusinessLogicLayer.GetProductByProductID(stock.ProductID) != null)
                {
                    _stockDataAccesslogic.AddStock(stock);
                }
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