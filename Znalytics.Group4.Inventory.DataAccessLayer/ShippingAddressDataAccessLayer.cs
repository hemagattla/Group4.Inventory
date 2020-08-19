using System.Collections.Generic;
using Znalytics.Inventory.ProductShippingAddressModule.Entities;
namespace Znalytics.Inventory.ProductShippingAddressModule.DataAccesLayer{ 
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