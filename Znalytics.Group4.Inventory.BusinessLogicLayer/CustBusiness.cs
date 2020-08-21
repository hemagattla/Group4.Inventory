using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.DataAccessLayer;
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
            public void UpDate(Customer c)
            {

            }
            public void Del(Customer c)
            {

            }
        }
    }

