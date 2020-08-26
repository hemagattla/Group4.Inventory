
//Written By Dhanasri
using System.Collections.Generic;

using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.ProductModule.Entitie;

namespace Znalytics.Inventory.OrderManagementModule.DataAccessLayer
{
   public class OrderManagementDataLayer
    {
         private static List<OrderManagement> _orders;
            public OrderManagementDataLayer()
            {
                _orders = new List<OrderManagement>();//creating List for OrderManagement
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
                
                    if(values.Products==values.Products)
                   
                        
                        _orders.Remove(values);
                    
                
            }
        }
            //Delete the Order
            public void DeleteOrder(OrderManagement values)
            {
            foreach(var order in _orders)
            {
                if (order.ShippingStatus == true)
                {
                    _orders.Remove(values);
                }
            }
            }

        
    }
}

