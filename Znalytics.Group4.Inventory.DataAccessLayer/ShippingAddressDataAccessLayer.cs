using System.Collections.Generic;
/// <summary>
/// represents ShippingAddress DataLayer of Inventory Management System
/// </summary>
public class ShippingAddressDataLayer
{
    private List<ShippingAddress> shippingAddresses;
        public ShippingAddressDataLayer()
    {
        shippingAddresses = new List<ShippingAddress>();
    }
    public void AddShippingDetails(ShippingAddress value)
    {
        shippingAddresses.Add(value);
    }

} 