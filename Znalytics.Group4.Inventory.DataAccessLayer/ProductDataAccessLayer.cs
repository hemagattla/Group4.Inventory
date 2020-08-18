//created by R.krushal



using System.Collections.Generic;
using System.ComponentModel;
using Znalytics.Inventory.Product.Entities;

namespace Znalytics.Inventory.Product.DataAccessLayer
{
    /// <summary>
    /// referes to ProductData in Property class
    /// </summary>
    public class Productdata
    {

        private List<ProductDetails> ProductsList  //creating a reference varibale for List
        {
            set;
            get;
        }

        public Productdata() // creating a list object
        {
            ProductsList = new List<ProductDetails>();
        }

        /// <summary>
        /// adding the products into the List
        /// </summary>
        /// <param name="productDetails"></param>
        public void AddProduct(ProductDetails productDetails)
        {
            ProductsList.Add(productDetails);
        }

        /// <summary>
        /// displaying the products in the List
        /// </summary>
        /// <param name="wareHouse"></param>
        public void DisplayProducts(ProductDetails wareHouse)
        {
            for (int i = 0; i < ProductsList.Count; i++)
            {
                ProductDetails n = ProductsList[i];
                System.Console.WriteLine("Product Name ={0},Product Id ={1},Price= {3}", n.ProductName, n.ProductID, n.Price);
            }


        }

    }
}