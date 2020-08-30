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
        

        public OrderManagementBusinessLogicLayer()
        {
            dl = new OrderManagementDataLayer();
        }
        IWareHouseBusinessLogicLayer k = new WareHouseBusinessLogicLayer();
        public List<WareHouse> GetWareHouses()
        {
            return k.GetWareHouses();
        }
        IStockBusinessLogicLayer l = new StockBusinessLogicLayer();
        public List<Stock> DisplayStock(Stock stock)
        {

        }

        //Creating Reference Variable for Products in BusinessLogicLayer 
        IProductBusinessLogicLayer i = new ProductBusiness();
        
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
        /// Cancel OrderDetails
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
        public int OrderID()
        {
            return dl.OrderIdGeneration();
        }
        /// <summary>
        /// Update ProductDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateProductDetails(int orderid, List<Product> value)
        {

            dl.UpdateProductDetails(orderid,value);


        }
        /// <summary>
        /// UpdateWareHouse AddressDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>

        public void UpdateWareHouseAddressDetails(int orderid, WareHouseAddress value)
        {
            dl.UpdateWareHouseAddressDetails(orderid, value);

        }
        /// <summary>
        /// Update CustomerAddressDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateCustomerAddressDetails(int orderid, Customer value)
        {
            dl.UpdateCustomerAddressDetails(orderid, value);
        }




    }

}        


    


    

