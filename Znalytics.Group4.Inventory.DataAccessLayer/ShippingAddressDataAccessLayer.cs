using System.Collections.Generic;
using Znalytics.Group4.Inventory.Entities;
namespace Znalytics.Group4.Inventory.DataAccessLayer{ 
/// <summary>
/// represents ShippingAddress DataLayer of Inventory Management System
/// </summary>
public class ShippingAddressDataLayer
{
    private List<ProductShippingAddress> shippingAddresses;
        public ShippingAddressDataLayer()
    {
        shippingAddresses = new List<ProductShippingAddress>();
    }
        //Add Shipping Details
    public void AddShippingDetails(ProductShippingAddress value)
    {
        shippingAddresses.Add(value);
    }
        //ViewDetails
        public List<ProductShippingAddress>ShippingAddressesDetails()
        {
            return shippingAddresses;
        }
        //Update AddressDetails
        public void UpdateAddressDetails(ProductShippingAddress value)
        {
            foreach(ShippingAddress s in shippingAddresses)
            {
                if (s.ProductID == value.ProductId)
                {
                    
                }
            }
        }

} }