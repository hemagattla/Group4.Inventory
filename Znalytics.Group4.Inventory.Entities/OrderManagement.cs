using System;
using System.Collections.Generic;
using Znalytics.Inventory.ProductModule.Entitie;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.Module.Entities;
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
        string _orderID;
        double _totalPrice;
      bool _shippingStatus=false;
        
        /// <summary>
        /// Constructor That intializes the Fields
        /// </summary>
        /// <param name="products"></param>
        /// <param name="wareHouseAddress"></param>
        /// <param name="customerAddress"></param>
        /// <param name="price"></param>
        /// <param name="shippingStatus"></param>
        /// <param name="orderID"></param>
        public OrderManagement(List<Product> products, WareHouseAddress wareHouseAddress,Customer customerAddress,double price,bool shippingStatus,string orderID)
        {
            products = _products;
            wareHouseAddress = _wareHouseAddress;
            customerAddress = _customerAddress;
           
            price = _totalPrice;
            orderID = _orderID;
            shippingStatus = _shippingStatus;
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
            set{
                _products = value;
            }
            get{
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
                _wareHouseAddress = value;
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
                _customerAddress = value;
            }
            get
            {
                return _customerAddress;
            }
        }
        /// <summary>
        /// Property for setting values to price field and Getting The value of the price Field 
        /// </summary>

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
        /// <summary>
        /// Property for setting values to ShippingStatus field and Getting The value of the ShippingStatus Field 
        /// </summary>

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
        /// <summary>
        /// Property for setting values to OrderID field and Getting The value of the OrderID Field 
        /// </summary>
        public string OrderID
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

     
        
    } 
}
