using Znalytics.Inventory.StockMaintain.DataAccessLayer;
public class StockBusinessLogicLayer
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

    public void ViewQuantity(Stock stock)
    {
        if ((stock.WareHouseID != null) && (stock.AddressName != null) && (stock.ProductID != null))
        {
            _stockDataAccesslogic.ViewQuantity(stock);
        }
    }
}