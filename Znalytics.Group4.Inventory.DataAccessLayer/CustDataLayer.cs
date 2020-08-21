using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.Entities;
namespace Znalytics.Group4.Inventory.DataAccessLayer 
{ 
        public class CustDataLayer
        {
            List <Customer> _customers = new List <Customer>();/// <summary>
                                                            /// creating list as customers///
                                                            /// </summary>
                                                            /// <param name="c"></param>
            public void AddCustomer(Customer c)///called Add Customer method frm business logic layer///
            {
               _customers.Add(c);///adding values to customers list///
            }
       
        public List<Customer> GetCustomers()
        {
            return _customers;
        }
        public void UpdateCustomer(Customer c)
        {
            //Get matching employee based on EmpID
            Customer cust = _customers.Find(temp => temp.CustomerId == c.CustomerId);
            if (cust != null)
            {
                cust.CustomerName = c.CustomerName;
            }
        }
        public List<Customer> GetCust()
        {
            return _customers;
        }
    }
    }
