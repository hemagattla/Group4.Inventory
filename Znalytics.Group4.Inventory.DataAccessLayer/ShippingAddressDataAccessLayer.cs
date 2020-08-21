using System.Collections.Generic;
using Znalytics.Group4.Inventory.Entities;
namespace Znalytics.Group4.Inventory.DataAccessLayer{ 
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

} }