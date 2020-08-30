using System;
using System.Runtime.Serialization;

namespace Znalytics.Inventory.StockMaintain.PresentationLayer
{
    [Serializable]
    internal class StockException : Exception
    {
        public StockException()
        {
        }

        public StockException(string message) : base(message)
        {
        }

        public StockException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StockException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}