using System;
using System.Collections.Generic;

using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.Module.Entities;
using Znalytics.Inventory.IDataAccessLayer;
using System.Security.Cryptography;

namespace Znalytics.Inventory.Module.DataAccessLayer
{
    public class CustDataLayer : IcustDataLayer
    {
        static List<Customer> _customers = new List<Customer>()/// <summary> /// creating list as customers///
                                                               /// </summary>
        {
            new Customer()
            {
                CustomerId=1,CustomerName="ramya",Email="ramyasuram1999@gmail.com",Country="india",State="telengana",Street="ramvada",PinNo="123456",HNo="123456"
            },
            new Customer()
            {
                  CustomerId=2,CustomerName="ram",Email="ram1999@gmail.com",Country="india",State="telengana",Street="ramvada",PinNo="123456",HNo="123789"
            }

        };

        public void AddCustomer(Customer c)///called Add Customer method frm business logic layer///
        {
            _customers.Add(c);///adding values to customers list///
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }
        public Tuple<string,string> LoginCustomer(string CustomerName,string PassWord)
        {
            if (_customers.Exists(temp => temp.CustomerName ==CustomerName))
                {
                if (_customers.Exists(temp => temp.PassWord == PassWord))
                {
                    return null; 
                }
         
            }
            return null;
        }
        public void UpdateCustomer(Customer c)
        {
            ///updating deatils based on cust id///
            Customer cu = _customers.Find(temp => temp.CustomerId == c.CustomerId);
            if (cu != null)
            {
                cu.CustomerName = c.CustomerName;
               
            }
        }
        public void DelCustomer(Customer c)
        {
            Customer t = _customers.Find((temp => temp.CustomerId == c.CustomerId));
            _customers.Clear();///deleting customers deatils based on given condition///
        }
        public Customer GetCustomerById(int CustomerId)//Displaying product Details using Product ID
        {
            Customer e;
            e = _customers.Find(n => n.CustomerId == CustomerId);
            /// e = _customers.FirstOrdefault(n => n.CustomerId == CustomerId);///
            ///  e = _customers.OrderedBy(n => n.CustomerId == CustomerId);
            return e;
        }
        public void RemoveCustomer(int CustomerId) => _customers.RemoveAll(n => n.CustomerId == CustomerId);
        ///deleting customers deatils based on given condition///
    }
  
}
