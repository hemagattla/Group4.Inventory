//created by R.krushal



using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using Znalytics.Inventory.ProductModule.Entitie;


namespace Znalytics.Inventory.ProductModule.DataAccessLayer
{
    /// <summary>
    /// referes to ProductData class in DataAccessLayer
    /// </summary>
    public class ProductData
    {

        private static List<Entitie.Product> _ProductsList  //creating a reference varibale for List
        {
            set;
            get;
        }

        static ProductData() // creating a list object in constructor
        {
            _ProductsList = new List<Entitie.Product>();

        }

        /// <summary>
        /// adding the products into the List
        /// </summary>
        /// <param name="productDetails">object of Product class</param>
        public void AddProduct(Entitie.Product productDetails)// Adding Products into the ProductsList
        {
            _ProductsList.Add(productDetails);
        }

        /// <summary>
        /// displaying the products in the List
        /// </summary>

        public List<Entitie.Product> DisplayProducts() 
        {
            return _ProductsList;
        }

        /// <summary>
        /// Removing a Product by using Product ID
        /// </summary>
        /// <param name="id">Product Id</param>
        public void RemoveProductByID(int id) //Removing a Product by using Product ID
        {
            _ProductsList.RemoveAll(n => n.ProductID == id);

        }
        /// <summary>
        /// Removing a Product by Product By name
        /// </summary>
        /// <param name="name">Product name</param>
        public void RemoveProductByName(string name)// Removing a Product By using Product Name
        {
            _ProductsList.RemoveAll(n => n.ProductName == name);
        }

        /// <summary>
        /// Displaying product Details using Product ID
        /// </summary>
        /// <param name="productID">passing Product ID</param>
        /// <returns></returns>
        public Entitie.Product GetProductByID(int productID)//Displaying product Details using Product ID
        {
            Entitie.Product pe;
            pe = _ProductsList.Find(n => n.ProductID == productID);
            return pe;

        }
        /// <summary>
        /// update product Name
        /// </summary>
        /// <param name="product">reference of Product</param>

        public void UpdateProductName(Entitie.Product product)// update product Name
        {
            Entitie.Product PE = _ProductsList.Find(n => n.ProductID == product.ProductID);
            if(PE!=null)
            {
                PE.ProductName = product.ProductName;
            }
        }
        /// <summary>
        /// update method for Product Price
        /// </summary>
        /// <param name="product">object of Product class</param>
        public void UpdateProductPrice(Entitie.Product product)
        {
            Entitie.Product PE = _ProductsList.Find(n => n.ProductID == product.ProductID);
            if (PE != null)
            {
                PE.Price = product.Price;
            }
        }

    }
}