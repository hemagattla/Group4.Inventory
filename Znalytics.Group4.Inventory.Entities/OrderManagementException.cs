using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group4.Inventory.Entities
{
    /// <summary>
    /// Class for OrderManagent Exception
    /// </summary>
    class OrderManagementException : ApplicationException
    {
        //Constructor That Initializes Nothing
        public OrderManagementException() : base()
            {

            }

        /// <summary>
        /// Constructor initializes only Message
        /// </summary>
        /// <param name="message"></param>
        public OrderManagementException(string message) : base(message)
            {
            }

        /// <summary>
        /// Constructor initializes Message and InnerException
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception which causes the current exception</param>
        public OrderManagementException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
    }


