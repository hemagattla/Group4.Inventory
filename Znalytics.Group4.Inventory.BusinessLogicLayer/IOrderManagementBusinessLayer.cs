using System;
using System.Collections.Generic;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.Module.Entities;
using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.ProductModule.Entitie;

namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{
    interface IOrderManagementBusinessLayer
    {
        //Get Order Details
         List<OrderManagement> GetOrderDetails();
        //Get OrderDetails by ProductID
         List<OrderManagement> GetOrderDetailsByProductID(Product value);
        //Get OrderDetails by WareHouseID
         List<OrderManagement> GetOrderDetailsByWareHouseID(WareHouseAddress value);
        //Get OrderDetails By EmployeeID
         List<OrderManagement> GetOrderDetailsByEmployeeID(Customer value);
    }
}
