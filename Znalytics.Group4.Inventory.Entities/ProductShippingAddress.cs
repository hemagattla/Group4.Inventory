﻿//Written By Dhanasri
namespace Znalytics.Inventory.ProductShippingAddressModule.Entities
{
    /// <summary>
    /// product shipping address module of inventory management system
    /// </summary>
    public class ProductShippingAddress
    {
        private string _productName;
        private string _productID;
        private double _productPrice;
        private string _customerName;
        private string _countryName;
        private string _stateName;
        private string _districtName;
        private string _cityName;
        private string _colony;
        private string _homeNo;
        private string _pincode;
        private string _mobileNumber;
        private string _emailID;
        /// <summary>
        /// constructor that represents the details of product
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productID"></param>
        /// <param name="productPrice"></param>
        public ProductShippingAddress(string productName, string productID, double productPrice, string countryName, string stateName, string districtName, string cityName, string colony, string homeNo, string pincode, string customerName, string phoneNo, string emailID)
        {
            productName = _productName;
            productID = _productID;
            productPrice = _productPrice;
            countryName = _countryName;
            stateName = _stateName;
            districtName = _districtName;
            cityName = _cityName;
            colony = _colony;
            homeNo = _homeNo;
            pincode = _pincode;
            customerName = _customerName;
            phoneNo = _mobileNumber;
            emailID = _emailID;
        }
        //default constructor
        public ProductShippingAddress()
        {

        }



        /// <summary>
        /// Represents Name of the product
        /// </summary>
        public string ProductName
        {
            set
            {
                _productName = value;
            }
            get
            {
                return _productName;
            }
        }
        /// <summary>
        /// represents the id of the product
        /// </summary>
        public string ProductID
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
        /// <summary>
        /// represents the price of the product
        /// </summary>
        public double ProductPrice
        {
            set
            {
                _productPrice = value;
            }
            get
            {
                return _productPrice;
            }
        }
        /// <summary>
        /// represents the Name of the customer
        /// </summary>
        public string CustomerName
        {
            set
            {
                _countryName = value;
            }
            get
            {
                return _countryName;
            }
        }
        /// <summary>
        /// represents country Name
        /// </summary>
        public string CountryName
        {
            set
            {
                _countryName = value;
            }
            get
            {
                return _countryName;
            }
        }
        /// <summary>
        /// represents stateName
        /// </summary>
        public string StateName
        {
            set
            {
                _stateName = value;
            }
            get
            {
                return _stateName;
            }
        }
        /// <summary>
        /// Represents DistrictName
        /// </summary>
        public string DistrictName
        {
            set
            {
                _districtName = value;
            }
            get
            {
                return _districtName;
            }
        }
        /// <summary>
        /// Represents CityName
        /// </summary>



        public string CityName
        {
            set
            {
                _cityName = value;
            }
            get
            {
                return _cityName;
            }
        }
        /// <summary>
        /// represents ColonyName
        /// </summary>
        public string Colony
        {
            set
            {
                _colony = value;
            }
            get
            {
                return _colony;
            }
        }
        /// <summary>
        /// represents HomeNo
        /// </summary>
        public string HomeNo
        {
            set
            {
                _homeNo = value;
            }
            get
            {
                return _homeNo;
            }
        }
        /// <summary>
        /// represents pincode
        /// </summary>
        public string PinCode
        {
            set
            {
                _pincode = value;
            }
            get
            {
                return _pincode;
            }
        }
        /// <summary>
        /// represents mobileNumber
        /// </summary>
        public string MobileNumber
        {
            set
            {
                _mobileNumber = value;
            }
            get
            {
                return _mobileNumber;
            }
        }
        /// <summary>
        /// Represents EmailID 
        /// </summary>
        public string EmailID
        {
            set
            {
                value = _emailID;
            }
            get
            {
                return _emailID;
            }
        }
    }
}
