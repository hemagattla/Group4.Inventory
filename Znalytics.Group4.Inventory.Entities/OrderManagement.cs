using System;
using System.Collections.Generic;
using Znalytics.Inventory.ProductModule.Entitie;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.Module.Entities;
using Znalytics.Group4.Inventory.Entities;
using System.Xml.Schema;

namespace Znalytics.Inventory.OrderManagementModule.Entities
{
/// <summary>
/// Class That Represents OrderManagement Module in Inventory Management System Project
/// </summary>
    public class OrderManagement
    {    //private Fields
        List<Product> _products;
        WareHouseAddress _wareHouseAddress;
        Customer _customerAddress;
        int _orderID;
        double _totalPrice;

        Dictionary<string, int> _pIdQuantity;
        int _totalQuantity;
        
        /// <summary>
        /// Constructor That intializes the Fields
        /// </summary>
        /// <param name="products"></param>
        /// <param name="wareHouseAddress"></param>
        /// <param name="customerAddress"></param>
        /// <param name="price"></param>
        
        /// <param name="orderID"></param>
        public OrderManagement(List<Product> products, WareHouseAddress wareHouseAddress,Customer customerAddress,double price,int orderID,Dictionary<string,int> quantity,int totalQuantity)
        {
            products = _products;
            wareHouseAddress = _wareHouseAddress;
            customerAddress = _customerAddress;
           
            price = _totalPrice;
            orderID = _orderID;
            quantity = _pIdQuantity;
            totalQuantity = _totalQuantity;
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderManagement()
        {

        }
/// <summary>
/// Property for setting values to Products field and Getting The value of the Field 
/// </summary>
       public List<Product> Products{
            set
            {
                List<Product> Products = new List<Product>();
                if (value!= null)
                {
                    _products = value;
                }
                else
                {
                    throw new OrderManagementException("Select Atleast one product");
                }
                
            }
            get
            {
                return _products;
            }
        }
        /// <summary>
        /// Property for setting values to WareHouseAddress field and Getting The value of the WareHouseAddress Field 
        /// </summary>
        public WareHouseAddress WareHouseAddress
        {
            set
            {
                if (value != null)
                {
                    _wareHouseAddress = value;
                }
            
                else
                
                    throw new OrderManagementException("Please Select Warehouse Address");
                   
            }
            get
            {
                return _wareHouseAddress;
            }
        }
        /// <summary>
        /// Property for setting values to CustomerAddress field and Getting The value of the CustomerAddress Field 
        /// </summary>
        public Customer CustomerAddress
        {
            set
            {
                if (value != null)
                {
                    _customerAddress = value;
                }
                else throw new OrderManagementException("Select Customer Address");

              
            }
            get
            {
                return _customerAddress;
            }
        }
        /// <summary>
        /// Property for setting values to price field and Getting The value of the price Field 
        /// </summary>

        public double TotalPrice
        {
            set
            {
                if (value > 0)
                {
                    _totalPrice = value;
                }
               
                else throw new OrderManagementException("Please Caluclate the Price Correctly ");

                
            }
            get
            {
                return _totalPrice;
            }
        }
        
       
           
        /// <summary>
        /// Property for setting values to OrderID field and Getting The value of the OrderID Field 
        /// </summary>
        public int OrderID
        {
            set
            {
                
                _orderID = value;
            }
            get
            {
                return _orderID;
            }
        }
        /// <summary>
        /// Property for storing Quantity in the index of ProductId
        /// </summary>
        public Dictionary<string,int> PIdQuantity
        {
            set
            {
                _pIdQuantity = value;
            }
            get
            {
                return _pIdQuantity;
            }
        }

        /// <summary>
        /// Property for assigning Values to Quantity Field and Getting the value of Quantity
        /// </summary>
        public int TotalQuantity 
        {
            set
            {
                if (value > 0 && value != ' ')
                {
                    _totalQuantity = value;
                }
                else throw new OrderManagementException("Quantity should be Greater than 0 and It Should not be null");
            }
            get
            {
                return _totalQuantity;
            }
        }

     
        
    } 
}
