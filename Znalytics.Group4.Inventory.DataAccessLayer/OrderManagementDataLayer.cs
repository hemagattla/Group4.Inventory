
//Written By Dhanasri
using System.Collections.Generic;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.ProductModule.Entitie;
using System.Linq;
using Znalytics.Inventory.Module.Entities;
using Znalytics.Group4.Inventory.DataAccessLayer;
using System;

namespace Znalytics.Inventory.OrderManagementModule.DataAccessLayer
{/// <summary>
///  Represents the OrderManagement Details in DataLayer
/// </summary>
    public class OrderManagementDataLayer : OrderManagmentDataLayerAbstract
    {
        private static List<OrderManagement> _orders;
        public OrderManagementDataLayer()
        {
            _orders = new List<OrderManagement>();
        }

        /// <summary>
        /// Add OrderDetails
        /// </summary>
        /// <param name="values"></param>

        public void AddOrderDetails(OrderManagement values)
        {
            _orders.Add(values);
        }

        /// <summary>
        /// ViewOrderDetails
        /// </summary>
        /// <returns></returns>
        public List<OrderManagement> GetOrderDetails()
        {
            return _orders;
        }

       /// <summary>
       /// Cancel OrderDetails By OrderID
       /// </summary>
       /// <param name="values"></param>
        public void CancelOrder(OrderManagement values)
        {
          OrderManagement order= _orders.Find(temp => temp.OrderID == values.OrderID);
            _orders.Remove(order);
        }
        

        /// <summary>
        /// Get OrderDetails by WareHouseID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override List<OrderManagement> GetOrderDetailsByWareHouseID(WareHouseAddress value)
        {
            List<OrderManagement> order = new List<OrderManagement>();
            foreach (var orders in _orders)
            {
                if (orders.WareHouseAddress.AddressId == value.AddressId)
                {

                    order.Add(orders);
                }

            }

            return order;
        }
        /// <summary>
        /// Get OrderDetails by ProductID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override List<OrderManagement> GetOrderDetailsByProductID(Product value)
        {
            List<OrderManagement> order = new List<OrderManagement>();
            foreach (var orders in _orders)
            {
                foreach (var products in orders.Products)
                {
                    if (products.ProductID == value.ProductID)
                    {
                        order.Add(orders);
                    }
                }

            }
            return order;
        }
        /// <summary>
        /// Get OrderDetails By CustomerID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderManagement> GetOrderDetailsByCustomerID(Customer value)
        {
            List<OrderManagement> order = new List<OrderManagement>();


            foreach (var orders in _orders)
            {
                if (orders.CustomerAddress.CustomerId == value.CustomerId)
                {
                    order.Add(orders);
                }

            }

            return order;
        }
        /// <summary>
        /// OrderID Generation
        /// </summary>
        /// <returns></returns>
        public int OrderIdGeneration()
        {
           int orderid= _orders.Max(temp => temp.OrderID);
            return orderid++;
        }
        /// <summary>
        /// Update ProductDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateProductDetails(OrderManagement orderid,OrderManagement value)
        {
            OrderManagement order = _orders.Find(temp => temp.OrderID == orderid.OrderID);
            
                order.WareHouseAddress = value.WareHouseAddress;
            }
        /// <summary>
        /// UpdateWareHouse AddressDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
  
        public void UpdateWareHouseAddressDetails(OrderManagement orderid, OrderManagement value)
        {
            OrderManagement order = _orders.Find(temp => temp.OrderID == orderid.OrderID);
            order.Products = value.Products;

        }
        /// <summary>
        /// Update CustomerAddressDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateCustomerAddressDetails(OrderManagement orderid, OrderManagement value)
        {
            OrderManagement order = _orders.Find(temp => temp.OrderID == orderid.OrderID);
            order.CustomerAddress = value.CustomerAddress;
        }




    }
}













