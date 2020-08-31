//created by R.Krushal

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Inventory.ProductModule.CustomException
{
    /// <summary>
    /// refers to Custom Exception of Product module
    /// </summary>
    public class ProductException:ApplicationException
    {
        /// <summary>
        /// default constructor for custom Exception
        /// </summary>
        public ProductException():base()
        {

        }
        /// <summary>
        /// Constuctor to read message when throw is used 
        /// </summary>
        /// <param name="message"></param>

        public ProductException(string message):base(message)
        {

        }
    }
}
