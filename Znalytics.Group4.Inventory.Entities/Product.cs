// created by R.Krushal


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Znalytics.Inventory.Product.Entitie
{
    /// <summary>
    /// referes to ProductEntities class in Entities Layer
    /// </summary>
    public class Product
    {
        //creating private feilds
        private string _productName;
        private int _productId;



        /// <summary>
        /// Property for ProductName
        /// </summary>
        public string ProductName
        {
            set
            {
                if (value != " ")
                    _productName = value;
            }
            get
            {
                return _productName;
            }
        }

        /// <summary>
        /// Property for ProductID
        /// </summary>
        public int ProductID
        {
            set
            {
                _productId = value;
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