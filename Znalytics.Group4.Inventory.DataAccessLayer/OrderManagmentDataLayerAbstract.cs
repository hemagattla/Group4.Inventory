using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.Module.Entities;
using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.ProductModule.Entitie;

namespace Znalytics.Group4.Inventory.DataAccessLayer
{
  public abstract class OrderManagmentDataLayerAbstract
    {
       
        //abstract metod for gettingProductDetails by WarehouseId
        public abstract List<OrderManagement> GetOrderDetailsByAddressID(string value);
        //abstactMethod for getting ProductDetails by ProductId
        public abstract List<OrderManagement> GetOrderDetailsByProductID(string value);

    }
}
