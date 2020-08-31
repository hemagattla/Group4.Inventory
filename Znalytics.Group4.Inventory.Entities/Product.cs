// created by R.Krushal


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Znalytics.Inventory.ProductModule.CustomException;

namespace Znalytics.Inventory.ProductModule.Entitie
{
    /// <summary>
    /// referes to ProductEntities class in Entities Layer
    /// </summary>
    public class Product
    {
        //creating private feilds
        private string _productName;
        private string _productId;
        private double _price;


        /// <summary>
        /// Property for ProductName
        /// </summary>
        public string ProductName
        {
            set
            {
                Regex r = new Regex("[a-zA-Z_]$");

                if (!string.IsNullOrEmpty(value) && r.IsMatch(value))
                {
                    _productName = value;

                }
                else
                {
                    throw new ProductException("do not enter empty values and Product name should contain only characters");
                }

            }
            get
            {
                return _productName;
            }
        }

        /// <summary>
        /// Property for ProductID
        /// </summary>
        public string ProductID
        {
            set
            {
                Regex r = new Regex("[A-Z0-9]$");
                if (value != "" && value.StartsWith("PID") && r.IsMatch(value) && value.Length <= 6)
                {
                    _productId = value;
                }
                else
                {
                    throw new ProductException("Product ID Should not NULL and ProductID Should Start with PID and 0-9 number and length should be 6");
                }
            }
            get
            {
                return _productId;
            }
        }
        /// <summary>
        /// Property for Price
        /// </summary>
        public double Price
        {
            set
            {
                try
                {
                    _price = value;
                }
                catch
                {
                    throw new ProductException("price should not be empty and should contain only numbers");
                }
            }
            get
            {
                return _price;
            }
        }

    }
}