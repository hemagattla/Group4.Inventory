using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group4.Inventory.Entities
{
    /// <summary>
    /// Exception class For WareHouse
    /// </summary>
    public class WareHouseException : ApplicationException
    {
        /// <summary>
        /// Exception which calls the Parent Exception 
        /// </summary>
        public WareHouseException() : base()
        {

        }
        /// <summary>
        /// Exception is displayed with user defined message 
        /// </summary>
        /// <param name="message"> message to be displayed</param>
        public WareHouseException(string message) : base(message)
        {
        }
        /// <summary>
        /// Inner Exception thrown from another place and re throwned to another Place 
        /// </summary>
        /// <param name="message">base Exception message</param>
        /// <param name="innerException">Inner Exception Message</param>
        public WareHouseException(string message, Exception innerException) : base(message)
        {

        }
    }
}
