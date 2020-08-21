using System.Collections.Generic;
using Znalytics.Group4.Inventory.Entities;
namespace Znalytics.Group4.Inventory.DataAccessLayer
{
    /// <summary>
    /// represents ShippingAddress DataLayer of Inventory Management System
    /// </summary>
    public class ShippingAddressDataLayer
    {
        private static List<ShippingAddress> _shippingAddresses;
        static ShippingAddressDataLayer()
        {
            _shippingAddresses = new List<ShippingAddress>();
        }
        public void AddShippingDetails(ShippingAddress values)
        {
            _shippingAddresses.Add(values);
        }
        public List <ShippingAddress> GetShippingDetails()
        {
            return _shippingAddresses;
        }
       public void updateProductDetails()
        {
            foreach(ShippingAddress ShippingDetails in _shippingAddresses)
            {
                if (ShippingDetails.ProductID = _shippingAddresses._productID)
                {

                }
            }
        }
             
    }
}
