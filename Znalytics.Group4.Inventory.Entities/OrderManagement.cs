using System;
using System.Collections.Generic;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.Module.Entities;
namespace Znalytics.Inventory.OrderManagementModule.Entities
{
    public class OrderManagement
    {
        List<string> _productNames;
        WareHouseAddress _wareHouseAddress;
        Customer _customerAddress;
        double _quantity;
        double _price;
        int _productID;
        bool _shippingStatus=false;
        OrderManagement(List<string> productNames, WareHouseAddress wareHouseAddress,Customer customerAddress,double quantity,double price,int productID,bool shippingStatus)
        {
            productNames = _productNames;
            wareHouseAddress = _wareHouseAddress;
            customerAddress = _customerAddress;
            quantity = _quantity;
            price = _price;
            productID = _productID;
            shippingStatus = _shippingStatus;
        }
       public List<string> ProductNames{
            set{
                _productNames = value;
            }
            get{
                return _productNames;
            }
        }
        public WareHouseAddress WareHouseAddress
        {
            set
            {
                _wareHouseAddress = value;
            }
            get
            {
                return _wareHouseAddress;
            }
        } 
        public Customer CustomerAddress
        {
            set
            {
                _customerAddress = value;
            }
            get
            {
                return _customerAddress;
            }
        }
        public double Quantity
        {
            set
            {
                _quantity = value;
            }
            get
            {
                return _quantity;
            }
        }
        public double Price
        {
            set
            {
                _price = value;
            }
            get
            {
                return _price;
            }
        }
        public int ProductID
        {
            set
            {
                _productID = value;
            }
            get
            {
                return _productID; 
            }
        }
        public bool ShippingStatus
        {
            set
            {
                _shippingStatus = value;
            }
            get
            {
                return _shippingStatus;
            }
        }

     
        
    } 
}
