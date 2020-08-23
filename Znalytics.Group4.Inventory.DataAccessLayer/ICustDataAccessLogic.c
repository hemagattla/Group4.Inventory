using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using znalytics.Group4.Inventory.Entities;
namespace Znalytics.Group4.Inventory.IDataAccessLayer
{
   interface IcustDataAccessLayer//creating an interface 
    {
    abstract void AddCustomer(Customer c);
    abstract void DelCustomer(Customer c);
    abstract void UpDateCustomer(Customer c);
    }
}
