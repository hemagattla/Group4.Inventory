using System;
using System.Collections.Generic;
using Znalytics.Inventory.OrderManagementModule.DataAccessLayer;
using Znalytics.Inventory.AddressModule.BusinessLogicLayer;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.Module.Entities;
using Znalytics.Inventory.ProductModule.Entitie;
using Znalytics.Group4.Inventory.ProductModule.IBusinessLogicLayer;
using System.Linq;
using Znalytics.Group4.Inventory.Entities;
using Znalytics.Group4.Module.IBusinessLogicLayer;
using Znalytics.Inventory.Module.BusinessLogicLayer;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.StockMain.BusinessLogicLayer;
using Znalytics.Inventory.StockMaintain.BusinessLogicLayer;
using Znalytics.Inventory.StockMaintain.Entities;

namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{/// <summary>
/// Represents Class in BusinessLayer and this OrderManagementBusinessLogicLayer class implements IOrderManagementBusinessLayer
/// </summary>
    public class OrderManagementBusinessLogicLayer:IOrderManagementBusinessLayer
    {
        OrderManagementDataLayer dl;
        
        //Represents a Constructor of OrderManagementBusineeLogicLayer Class
        public OrderManagementBusinessLogicLayer()
        {
            dl = new OrderManagementDataLayer();
        }
        //Creating Reference variable for Interface for IWareHouseBusinessLogicLayer
        IWareHouseBusinessLogicLayer k = new WareHouseBusinessLogicLayer();
        /// <summary>
        /// Method for Getting Details of WareHouses
        /// </summary>
        /// <returns></returns>
        public List<WareHouse> GetWareHouses()
        {
            return k.GetWareHouses();
        }
        //Creating Object for StockBusinessLogicLayer
        StockBusinessLogicLayer b = new StockBusinessLogicLayer();
        /// <summary>
        /// Method for Getting All Stocks
        /// </summary>
        /// <param name="warehouseID"></param>
        /// <param name="addressID"></param>
        /// <returns></returns>
        public List<Stock> GetAllStocks(string warehouseID, string addressID)
        {
            return b.GetAllStocks(warehouseID, addressID);
        }
        /// <summary>
        /// Method for Getting Total Quantity
        /// </summary>
        /// <param name="warehouseID"></param>
        /// <param name="addressID"></param>
        /// <param name="productID"></param>
        /// <returns></returns>
        

        //Creating Reference Variable for Interface IProductBusinessLogicLayer
        IProductBusinessLogicLayer i = new ProductBusiness();
        /// <summary>
        /// Metod for Displaying Products
        /// </summary>
        /// <returns></returns>
        public List<Product> DispalyProducts()
        {
            return i.DispalyProducts();
        }
        /// <summary>
        /// Get ProductDetails By productID
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public Product ProductDetails(string ProductID)
        {
            return i.GetProductByProductID(ProductID);

        
        }
        
        IWareHouseAddressBusinessLogicLayer WareHouseAddress = new WareHouseAddressBusinessLogicLayer();
        /// <summary>
        /// Getting WarehouseAddressDetails using interface referance i.e. WareHouseAddress
        /// </summary>
        /// <returns></returns>
        public List<WareHouseAddress> GetWareHouseAddresses()
        {
            return WareHouseAddress.GetAddresses();
        }
        /// <summary>
        /// Getting WareHouse Details by AddressId
        /// </summary>
        /// <param name="AddressID"></param>
        /// <returns></returns>
        public WareHouseAddress GetWareHouseByAddressID(string AddressID)
        {
            return WareHouseAddress.GetAddressByAddressID(AddressID);
        }
        //Creating Reference Variable for CustomerBusinessLogicLayer
        ICustBusinessLogicLayer CustomerAddress = new CustBusiness();
        /// <summary>
        /// Getting CustomerAddress Details By Using CustomerId
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        
        public Customer GetCustomerDetailsByCustomerID(int CustomerId)
        {
            return CustomerAddress.GetCustomerById(CustomerId);
        }

        /// <summary>
        /// Adding OrderDetails to collections
        /// </summary>
        /// <param name="value"></param>
        public void AddOrderDetails(OrderManagement values)
        {
            try
            {

                dl.AddOrderDetails(values);

            }
            catch (Exception e)
            {
                throw;
            
        
           
        }


        

        /// <summary>
        /// Get OrderDetails
        /// </summary>
        /// <returns></returns>
        public List<OrderManagement>GetOrderDetails()
        {

            List<OrderManagement> orderDetails= dl.GetOrderDetails();
            return orderDetails;
        }

        /// <summary>
        /// Cancel OrderDetails By OrderId
        /// </summary>
        /// <param name="value"></param>
        public void CancelOrderDetails(int value)
        {
            dl.CancelOrder(value);
        }
        /// <summary>
        /// Getting Product Details by WareHouseID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderManagement> GetOrderDetailsByAdddressID(string value)
        {
       
            List<OrderManagement> orders= dl.GetOrderDetailsByAddressID(value);
            return orders;
        }
        /// <summary>
        /// Get OrderDetails By ProductID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderManagement> GetOrderDetailsByProductID(string value)
        {
           return dl.GetOrderDetailsByProductID(value);
            
        }/// <summary>
        /// GetOrderDetails By EmployeeId
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
       public List<OrderManagement> GetOrderDetailsByEmployeeID(int value)
        {
            return dl.GetOrderDetailsByCustomerID(value);
                
        }
        /// <summary>
        /// OrderId Generation
        /// </summary>
        /// <returns></returns>
        public int OrderID()
        {
            return dl.OrderIdGeneration();
        }
        /// <summary>
        /// Update ProductDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateProductDetails(int orderid, string value)
        {

            dl.UpdateProductDetails(orderid,value);


        }
        /// <summary>
        /// UpdateWareHouse AddressDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>

        public void UpdateWareHouseAddressDetails(int orderid, string value)
        {
            dl.UpdateWareHouseAddressDetails(orderid, value);

        }
        /// <summary>
        /// Update CustomerAddressDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateCustomerAddressDetails(int orderid, int value)
        {
            dl.UpdateCustomerAddressDetails(orderid, value);
        }
        public void UpdateQuantity(int orderId,int value)
        {
            dl.UpdateQuantity(orderId, value);
        }



    }

}        



    

