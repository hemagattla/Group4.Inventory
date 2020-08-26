using System;
using System.Collections.Generic;
using Znalytics.Inventory.ProductModule.Entitie;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.Module.Entities;
namespace Znalytics.Inventory.OrderManagementModule.Entities
{
    public class OrderManagement
    {
        List<Product> _products;
        WareHouseAddress _wareHouseAddress;
        Customer _customerAddress;
        
        double _totalPrice;
       
        bool _shippingStatus=false;
        OrderManagement(List<Product> products, WareHouseAddress wareHouseAddress,Customer customerAddress,double price,bool shippingStatus)
        {
            products = _products;
            wareHouseAddress = _wareHouseAddress;
            customerAddress = _customerAddress;
           
            price = _totalPrice;
           
            shippingStatus = _shippingStatus;
        }
       public List<Product> Products{
            set{
                _products = value;
            }
            get{
                return _products;
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
      
        public double Price
        {
            set
            {
                _totalPrice = value;
            }
            get
            {
                return _totalPrice;
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
