using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.Module.DataAccessLayer;//importing dataaccesslayer by using keyword///
using Znalytics.Inventory.Module.Entities;
namespace Znalytics.Inventory.Module.BusinessLogicLayer///namespace is nothing bt collection of classes///
{

    public class CustBusiness
    {
        CustDataLayer d = new CustDataLayer();
        public void AddCustomer( Customer c)///these method is called from presentation layer///
        {
            if (c.CustomerName != null)///validating the condition///
            {
                d.AddCustomer(c);///these calls the method of dataaccess layer///

            }
        }

            public List<Customer> GetCoustomers()
            {
                return d.GetCustomers();// return to presentation layer
            }
        
        public void UpdateCustomer(Customer c)
            {
            if(c.CustomerName!=null)
            {
                d.UpdateCustomer(c);
            }
            }
        public List<Customer> GetCust()
        {
            return d.GetCust();
        }
        public void DelCustomer(Customer c)
            {
            d.DelCustomer(c);
            }
        }
    }

