//created by R.krushal



using System.Collections.Generic;
using System.ComponentModel;
using Znalytics.Inventory.Product.Entities;
using Znalytics.Inventory.Product.IDataAccessLgoic;

namespace Znalytics.Inventory.Product.DataAccessLayer
{
    /// <summary>
    /// referes to ProductData in Property class
    /// </summary>
    public class Productdata : IproductDataAccessLogic
    {

        private static List<ProductEntitie> _ProductsList  //creating a reference varibale for List
        {
            set;
            get;
        }

        static Productdata() // creating a list object
        {
            _ProductsList = new List<ProductEntitie>();

        }

        /// <summary>
        /// adding the products into the List
        /// </summary>
        /// <param name="productDetails"></param>
        public void AddProduct(ProductEntitie productDetails)
        {
            _ProductsList.Add(productDetails);
        }

        /// <summary>
        /// displaying the products in the List
        /// </summary>

        public List<ProductEntitie> DisplayProducts()
        {
            return _ProductsList;
        }

        public void RemoveProductByID(int id)
        {
            _ProductsList.RemoveAll(n => n.ProductID == id);

        }

        public void RemoveProductByName(string name)
        {
            _ProductsList.RemoveAll(n => n.ProductName == name);
        }


    }
}