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
        string _productId;
        string _wareHouseAddressId;
        int _customerAddressId;
        int _orderID;
        double _totalPrice;

        int _quantity;
        
        
        /// <summary>
        /// Constructor That intializes the Fields
        /// </summary>
        /// <param name="products"></param>
        /// <param name="wareHouseAddress"></param>
        /// <param name="customerAddress"></param>
        /// <param name="price"></param>
        
        /// <param name="orderID"></param>
        public OrderManagement(string products, string wareHouseAddress,int customerAddressId,double price,int orderID,int quantity)
        {
            products = _productId;
            wareHouseAddress = _wareHouseAddressId;
            customerAddressId = _customerAddressId;
           
            price = _totalPrice;
            orderID = _orderID;
            quantity = _quantity;
           
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
       public string ProductId{
            set
            {
                
                if (value!= null)
                {
                    _productId = value;
                }
                else
                {
                    throw new OrderManagementException("Select Atleast one product");
                }
                
            }
            get
            {
                return _productId;
            }
        }
        /// <summary>
        /// Property for setting values to WareHouseAddress field and Getting The value of the WareHouseAddress Field 
        /// </summary>
        public string WareHouseAddressId
        {
            set
            {
                if (value != null)
                {
                    _wareHouseAddressId = value;
                }
            
                else
                
                    throw new OrderManagementException("Please Select Warehouse Address");
                   
            }
            get
            {
                return _wareHouseAddressId;
            }
        }
        /// <summary>
        /// Property for setting values to CustomerAddress field and Getting The value of the CustomerAddress Field 
        /// </summary>
        public int CustomerAddressId
        {
            set
            {
                if (value != 0)
                {
                    _customerAddressId = value;
                }
                else throw new OrderManagementException("Select Customer Address");

              
            }
            get
            {
                return _customerAddressId;
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
        /// Property for storing Quantity 
        /// </summary>
        public int Quantity
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

        
     
        
    } 
}
