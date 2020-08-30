/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.Module.DataAccessLayer;//importing dataaccesslayer by using keyword///
using Znalytics.Inventory.Module.Entities;
using Znalytics.Group4.Module.IBusinessLogicLayer;
namespace Znalytics.Inventory.Module.BusinessLogicLayer///namespace is nothing bt collection of classes///
{

    public class CustBusiness:ICustBusinessLogicLayer                                                                  
    {
        CustDataLayer d = new CustDataLayer();
        public void AddCustomer( Customer c)///these method is called from presentation layer///
        {
            if (c.CustomerName != null)///validating the condition///
            {
                d.AddCustomer(c);///these calls the method of dataaccess layer///

            }
        }

            public List<Customer> GetCustomers()
            {
                return d.GetCustomers();// return to presentation layer
            }
        public List<Customer> LoginCustomer(string CustomerName,String Password)                                        
        {
            if(CustomerName!=null&&Password!=null)
            {
                return d.LoginCustomer(CustomerName, Password);
            }
        }
        public void UpdateCustomer(Customer c)
            {
            if(c.CustomerName!=null)
            {
                d.UpdateCustomer(c);
            }
            }
        public void DelCustomer(Customer c)
            {
            d.DelCustomer(c);
            }
       public Customer GetCustomerById(int CustomerId)
        {
            return d.GetCustomerById(CustomerId);

        }

    }
}*/

