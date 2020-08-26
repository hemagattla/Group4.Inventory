
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

        //Add OrderDetails

        public void AddOrderDetails(OrderManagement values)
        {
            _orders.Add(values);
        }

        //ViewOrderDetails
        public List<OrderManagement> ViewOrderDetails()
        {
            return _orders;
        }

        //Cancel the Order
        public void CancelOrder(OrderManagement values)
        {
            foreach (var order in _orders)
            {

                if (order.Products == values.Products)


                    _orders.Remove(values);


            }
        }
        //Delete the Order
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
        //Get OrderDetails by WareHouseID
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
        //Get OrderDetails by ProductID
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
                   

                

          

            



    


