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



        /// <summary>
        /// Property for ProductName
        /// </summary>
        public string ProductName
        {
            set
            {


                if (!string.IsNullOrEmpty(value))
                {
                    _productName = value;

                }
                else
                {
                    throw new ProductException("do not enter empty values");
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
                if (value != "")
                {
                    _productId = value;
                }
                else
                {
                    throw new ProductException("Product ID Should not NULL");
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
        public double Price { set; get; }

    }
}