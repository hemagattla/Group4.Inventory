using System;
using System.Collections.Generic;


namespace Znalytics.Group4.Inventory.Entities
{
    class OrderManagement
    {
        List<string> _productName;
        WareHouseAddress _wareHouseAddress;
        CustomerAddress _customerAddress;
        double _quantity;
        double _price;
        OrderManagement(List<string> productName, WareHouseAddress wareHouseAddress,CustomerAddress customerAddress,double quantity,double price)
        {
            productName = _productName;
            wareHouseAddress = _wareHouseAddress;
            customerAddress = _customerAddress;
            quantity = _quantity;
            price = _price;
        }
       Public List<string> ProductName{
            set{
                _productName = value;
            }
            get{
                return _productName;
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
        public CustomerAddress CustomerAddress
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

     
        
    } 
}
