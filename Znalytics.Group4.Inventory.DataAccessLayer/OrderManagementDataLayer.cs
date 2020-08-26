
//Written By Dhanasri
using System.Collections.Generic;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.ProductModule.Entitie;
using System.Linq;
namespace Znalytics.Inventory.OrderManagementModule.DataAccessLayer
{/// <summary>
///  Represents the OrderManagement Details in DataLayer
/// </summary>
    public class OrderManagementDataLayer
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
        public List<OrderManagement> ViewOrderDetails()
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
        /// Delete the Order
        /// </summary>
        /// <param name="values"></param>
        public void DeleteOrder(OrderManagement values)
        {
            foreach (var order in _orders)
            {
                if (order.ShippingStatus == true)
                {
                    _orders.Remove(values);
                }
            }
        }

        /// <summary>
        /// Get OrderDetails by WareHouseID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderManagement> GetOrderDetailsByWareHouseID(WareHouseAddress value)
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
        public List<OrderManagement> GetOrderDetailsByProductID(Product value)
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


    }
}
                   

                

          

            



    


