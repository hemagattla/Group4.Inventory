using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Inventory.ProductModule.CustomException
{
    public class ProductException:ApplicationException
    {
        public ProductException():base()
        {

        }

        public ProductException(string message):base(message)
        {

        }
    }
}
