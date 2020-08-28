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
  abstract class OrderManagmentDataLayerAbstract
    {
       
        
        public abstract List<OrderManagement> GetOrderDetailsByWareHouseID(string value);
        public abstract List<OrderManagement> GetOrderDetailsByProductID(int value);

    }
}
