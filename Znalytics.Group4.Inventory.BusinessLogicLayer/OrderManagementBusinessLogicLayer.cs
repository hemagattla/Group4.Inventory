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
namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{/// <summary>
/// Represents Class in BusinessLayer and this OrderManagementBusinessLogicLayer class implements IOrderManagementBusinessLayer
/// </summary>
    class OrderManagementBusinessLogicLayer:IOrderManagementBusinessLayer
    {
        OrderManagementDataLayer dl;


        public OrderManagementBusinessLogicLayer()
        {
            dl = new OrderManagementDataLayer();
        }

        IProductBusinessLogicLayer i = new ProductBusiness();
        /// <summary>
        /// Get ProductDetails By product
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
        public List<Customer> GetCustomerDetails()
        {

        }

        /// <summary>
        /// Adding OrderDetails to collections
        /// </summary>
        /// <param name="value"></param>
        public void AddOrderDetails(OrderManagement values)
        {
            if (values.Products != null)
            {
                dl.AddOrderDetails(values);
            }
            else
            {
                throw new System.Exception("Select Atleast one product");
            }
            /// <summary>
            /// Add WareHouseAddress to the Collections
            /// </summary>
            /// <param name="value"></param>

            if (values.WareHouseAddress != null)
            {
                dl.AddOrderDetails(values);
            }
            else { throw new System.Exception("Select Warehouse Address"); }


            /// <summary>
            /// Add CustomerAdddress to the Collections
            /// </summary>
            /// <param name="value"></param>

            if (values.CustomerAddress != null)
            {
                dl.AddOrderDetails(values);
            }
            else throw new System.Exception("Select Customer Address");

            /// <summary>
            /// Add Price to Collections
            /// </summary>
            /// <param name="value"></param>

            if (values.Price > 0)
            {
                dl.AddOrderDetails(values);
            }
            else throw new System.Exception("Please Caluclate the Price Correctly ");

            /// <summary>
            /// Add Shipping Status To the Collections
            /// </summary>
            /// <param name="value"></param>


            if (values.ShippingStatus == true || values.ShippingStatus == false)
            {
                dl.AddOrderDetails(values);
            }
            else throw new System.Exception("Enter either true or False");
            OrderManagement o = new OrderManagement();
            if (values.OrderID.Length == 10 && ! values.OrderID.Contains(o.OrderID))
            {
                dl.AddOrderDetails(values);
            }

        }


        //Delete OrderDetails
        public void DeleteOrderDetails(OrderManagement values)
        {
            dl.DeleteOrder(values);
        }


        //View OrderDetails
        public List<OrderManagement> ViewOrderDetails()
        {

            List<OrderManagement> orderDetails= dl.ViewOrderDetails();
            return orderDetails;
        }
        
        //Cancel OrderDetails
        public void CancelOrderDetails(OrderManagement value)
        {
            dl.CancelOrder(value);
        }
        //View OrderDetails by WareHouseID
        public List<OrderManagement> GetOrderDetailsByWareHouseID(WareHouseAddress value)
        {
       
            List<OrderManagement> orders= dl.GetOrderDetailsByWareHouseID(value);
            return orders;
        }
        //View OrderDetails By ProductID
        public List<OrderManagement> GetOrderDetailsByProductID(Product value)
        {
            List<OrderManagement> orders = dl.GetOrderDetailsByProductID(value);
            return orders;
        }
    }

}        


    


    

