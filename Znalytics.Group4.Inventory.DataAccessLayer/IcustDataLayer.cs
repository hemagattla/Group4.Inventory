using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.Module.Entities;
namespace Znalytics.Inventory.IDataAccessLayer
{
    class IcustDataLayer
    {
       abstract public void AddCustomer(Customer c);
        abstract public  void UpDateCustomer(Customer c);
        abstract public void DelCustomer(Customer c);
    }
}
