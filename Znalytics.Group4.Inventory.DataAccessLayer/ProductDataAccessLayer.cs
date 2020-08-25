//created by R.krushal



using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using Znalytics.Inventory.Product.Entities;
using Znalytics.Group4.Inventory.IDataAccessLayer;

namespace Znalytics.Inventory.Product.DataAccessLayer
{
    /// <summary>
    /// referes to ProductData in Property class
    /// </summary>
    public class Productdata : IproductDataAccessLogic
    {

        private static List<Entities.Product> _ProductsList  //creating a reference varibale for List
        {
            set;
            get;
        }

        static Productdata() // creating a list object
        {
            _ProductsList = new List<Entities.Product>();

        }

        /// <summary>
        /// adding the products into the List
        /// </summary>
        /// <param name="productDetails"></param>
        public void AddProduct(Entities.Product productDetails)// Adding Products into the ProductsList
        {
            _ProductsList.Add(productDetails);
        }

        /// <summary>
        /// displaying the products in the List
        /// </summary>

        public List<Entities.Product> DisplayProducts() //Dispalying all Products Availabale
        {
            return _ProductsList;
        }

        public void RemoveProductByID(int id) //Removing a Product by using Product ID
        {
            _ProductsList.RemoveAll(n => n.ProductID == id);

        }

        public void RemoveProductByName(string name)// Removing a Product By using Product Name
        {
            _ProductsList.RemoveAll(n => n.ProductName == name);
        }

        public Entities.Product GetProductByID(int productID)//Displaying product Details using Product ID
        {
            Entities.Product pe;
            pe = _ProductsList.Find(n => n.ProductID == productID);
            return pe;

        }

        public void UpdateProductName(Entities.Product product)// update product Name
        {
            Entities.Product PE = _ProductsList.Find(n => n.ProductID == product.ProductID);
            if(PE!=null)
            {
                PE.ProductName = product.ProductName;
            }
        }

        public void UpdateProductPrice(Entities.Product product)
        {
            Entities.Product PE = _ProductsList.Find(n => n.ProductID == product.ProductID);
            if (PE != null)
            {
                PE.Price = product.Price;
            }
        }

    }
}