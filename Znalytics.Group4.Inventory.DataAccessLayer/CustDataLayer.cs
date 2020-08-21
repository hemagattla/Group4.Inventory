using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group4.Inventory.DataAccessLayer 
{ 
        public class CustDataLayer
        {
            List <Customer> _customers = new List <Customer>();/// <summary>
                                                            /// creating list for customer class///
                                                            /// </summary>
                                                            /// <param name="c"></param>
            public void AddCustomer(Customer c)
            {
               _customers.Add(c);///adding values to customer///
            }
        }
    }