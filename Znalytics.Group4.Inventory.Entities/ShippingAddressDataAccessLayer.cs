// Written by Dhanasri
using System.Collections.Generic;
using Znalytics.Group4.Inventory.Entities;
using Znalytics.Inventory.ProductShippingAddressModule.Entities;

namespace Znalytics.Group4.Inventory.DataAccessLayer{ 
/// <summary>
/// represents ShippingAddress DataLayer of Inventory Management System
/// </summary>
public class ShippingAddressDataLayer
{
    private static List<ProductShippingAddress> shippingAddresses; 
        public ShippingAddressDataLayer()
    {
        shippingAddresses = new List<ProductShippingAddress>();
    }
        //Add Shipping Details
    public void AddShippingDetails(ProductShippingAddress values)
    {
        shippingAddresses.Add(values);
    }
        //ViewShippingAddressesDetails
        public List<ProductShippingAddress> ViewShippingAddressesDetails()
        {
            return shippingAddresses;
        }
        //Delete AddressDetails
        public void DeleteAddressDetails(ProductShippingAddress values)
        {
            foreach(var Address in shippingAddresses)
            {
                if (Address.ProductID == values.ProductID)
                {
                    shippingAddresses.Remove(values);


                        
                }
            }
        }
        //UpdateAddressDetails
        public void UpdateAddressDetails(ProductShippingAddress values)
        {
            
        }

} }