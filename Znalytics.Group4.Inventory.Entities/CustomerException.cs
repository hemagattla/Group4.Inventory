using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group4.Inventory.Entities
{
    public class CustomerException : ApplicationException
    {
        public CustomerException() : base()
        {
        }
            public CustomerException(string message) : base(message)
            {

            }
        public CustomerException(string message, Exception innerException) : base(message)
        {

        }


    }
}
