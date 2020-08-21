using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.DataAccessLayer;
using Znalytics.Group4.Inventory.Entities;
namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{
 
        public class CustBusiness
        {
            CustDataLayer d = new CustDataLayer();
            public void AddCustomer(Customer c)
            {
                if (c.CustomerName != null)
                {
                    d.AddCustomer(c);

                }
            }
        public List<Customer> GetCoustomers()
        {
            return _d.Getcustomers();
        }
        public void UpdateCustomer(Customer c)
            {

            }
            public void Delcustomer(Customer c)
            {

            }
        }
    }

