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

namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{/// <summary>
/// Represents Class in BusinessLayer and this OrderManagementBusinessLogicLayer class implements IOrderManagementBusinessLayer
/// </summary>
    class OrderManagementBusinessLogicLayer:IOrderManagementBusinessLayer
    {
        OrderManagementDataLayer dl;
        

        public OrderManagementBusinessLogicLayer()
        {//Creating Object for DataManagementLayer
            dl = new OrderManagementDataLayer();
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
        public Product ProductDetails(int ProductID)
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
        public List<WareHouseAddress> GetWareHouseByWareHouseID(string WareHouseID)
        {
            return WareHouseAddress.GetAddressByWareHouseID(WareHouseID);
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
            catch(Exception e)
            {
                throw;
            }
            /// <summary>
            /// Add WareHouseAddress to the Collections
            /// </summary>
            /// <param name="value"></param>
            try { 
           
                dl.AddOrderDetails(values);
            }
           catch(Exception e)
            {
                throw;
            }


            /// <summary>
            /// Add CustomerAdddress to the Collections
            /// </summary>
            /// <param name="value"></param>

            try
            {
                dl.AddOrderDetails(values);
            }
            catch (Exception e) { throw; }

            /// <summary>
            /// Add Price to Collections
            /// </summary>
            /// <param name="value"></param>

            try
            {
                dl.AddOrderDetails(values);
            }
            catch (Exception e) { throw; }
            /// <summary>
            /// Add Shipping Status To the Collections
            /// </summary>
            /// <param name="value"></param>


            try
            {
                dl.AddOrderDetails(values);
            }
            catch (Exception e)
            {
                throw;
            }
            OrderManagement o = new OrderManagement();
            if (values.OrderID.Length == 10 && ! values.OrderID.Contains(o.OrderID))
            {
                dl.AddOrderDetails(values);
            }

        }


        /// <summary>
        /// Delete OrderDetails
        /// </summary>
        /// <param name="values"></param>
        public void DeleteOrderDetails(OrderManagement values)
        {
            dl.DeleteOrder(values);
        }


        /// <summary>
        /// View OrderDetails
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
        public void CancelOrderDetails(OrderManagement value)
        {
            dl.CancelOrder(value);
        }
        /// <summary>
        /// Getting Product Details by WareHouseID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderManagement> GetOrderDetailsByWareHouseID(WareHouseAddress value)
        {
       
            List<OrderManagement> orders= dl.GetOrderDetailsByWareHouseID(value);
            return orders;
        }
        /// <summary>
        /// Get OrderDetails By ProductID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderManagement> GetOrderDetailsByProductID(Product value)
        {
           return dl.GetOrderDetailsByProductID(value);
            
        }/// <summary>
        /// GetOrderDetails By EmployeeId
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
       public List<OrderManagement> GetOrderDetailsByEmployeeID(Customer value)
        {
            return dl.GetOrderDetailsByCustomerID(value);
        }


    }

}        


    


    

