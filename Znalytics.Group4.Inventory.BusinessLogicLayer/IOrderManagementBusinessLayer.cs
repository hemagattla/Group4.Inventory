using System;
using System.Collections.Generic;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.ProductModule.Entitie;

namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{
    interface IOrderManagementBusinessLayer
    {
        //View Order Details
         List<OrderManagement> ViewOrderDetails();
        //view OrderDetails by ProductID
         List<OrderManagement> GetOrderDetailsByProductID(Product value);
        //View OrderDetails by WareHouseID
         List<OrderManagement> GetOrderDetailsByWareHouseID(WareHouseAddress value);
    }
}
