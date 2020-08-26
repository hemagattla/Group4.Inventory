using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.Module.Entities;
namespace Znalytics.Inventory.IDataAccessLayer
{
    interface IcustDataLayer
    {
        void AddCustomer(Customer c);
          void UpdateCustomer(Customer c);
      void DelCustomer(Customer c);
    }
}
