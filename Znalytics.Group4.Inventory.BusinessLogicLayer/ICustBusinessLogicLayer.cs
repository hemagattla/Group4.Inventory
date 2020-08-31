using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.Module.Entities;
namespace Znalytics.Group4.Module.IBusinessLogicLayer
{
    interface ICustBusinessLogicLayer
    {
        void AddCustomer(Customer c);
        void UpdateCustomer(Customer c);
      void DelCustomer(Customer c);
        Customer GetCustomerById(int CustomerId);
        Tuple<string, string> LoginCustomer(string CustomerName, string PassWord);
    }
}
