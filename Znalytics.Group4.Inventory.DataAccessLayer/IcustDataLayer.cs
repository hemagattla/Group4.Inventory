using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.Entities;
namespace Znalytics.Group4.Inventory.DataAccessLayer
{
    class IcustDataLayer
    {
       abstract  void AddCustomer(Customer c);
        abstract void UpDateCustomer(Customer c);
        abstract void DelCustomer(Customer c);
    }
}
