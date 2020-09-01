//created by Hema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities
{
    //creating our own ProductRawMaterialException
    public class ProductRawMaterialException: ApplicationException
    {
        public ProductRawMaterialException() : base()
        {

        }

        public ProductRawMaterialException(string message) : base(message)
        {

        }
    }
}


