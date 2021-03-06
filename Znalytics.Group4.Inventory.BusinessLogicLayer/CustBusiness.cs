﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.Module.DataAccessLayer;//importing dataaccesslayer by using keyword///
using Znalytics.Inventory.Module.Entities;
using Znalytics.Group4.Inventory.Entities;
using Znalytics.Group4.Module.IBusinessLogicLayer;
using System.Linq.Expressions;

namespace Znalytics.Inventory.Module.BusinessLogicLayer///namespace is nothing bt collection of classes///
{

    public class CustBusiness : ICustBusinessLogicLayer
    {
        CustDataLayer d = new CustDataLayer();
        public void AddCustomer(Customer c)///these method is called from presentation layer///
        {
            try
            {
                if (c.CustomerName != null)///validating the condition///
                {
                    d.AddCustomer(c);///these calls the method of dataaccess layer///

                }
            }
            catch(Exception e)
            {
                throw new CustomerException(e.Message);
            }
                   
            }
      
        

        public List<Customer> GetCustomers()
        {
            return d.GetCustomers();// return to presentation layer
        }
        public Tuple<string, string> LoginCustomer(string CustomerName, string PassWord)
        {
            if (CustomerName != null && PassWord != null)
            {
              return d.LoginCustomer(CustomerName, PassWord);
                
            }
            return null;
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
            if (c.CustomerId != 0)
            {
                d.DelCustomer(c);
            }
        }
       public Customer GetCustomerById(int CustomerId)
        {
            return d.GetCustomerById(CustomerId);

        }
        public void RemoveCustomer(int CustomerId)
        {
            if (CustomerId != null)
            {
                d.RemoveCustomer(CustomerId);
            }
        }


    }
}

