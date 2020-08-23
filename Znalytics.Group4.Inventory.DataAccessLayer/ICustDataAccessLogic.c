using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group4.Inventory.DataAccessLayer
{
    class ICustDataAccessLogic//creating an interface 
    {
    abstract void AddCustomer(Customer c);
    abstract void DelCustomer(Customer c);
    abstract void UpDateCustomer(Customer c);
    }
}
