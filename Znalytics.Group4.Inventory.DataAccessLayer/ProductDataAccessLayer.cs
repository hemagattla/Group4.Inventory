﻿//created by R.krushal



using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using Znalytics.Inventory.ProductModule.Entitie;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Linq;

namespace Znalytics.Inventory.ProductModule.DataAccessLayer
{
    /// <summary>
    /// referes to ProductData class in DataAccessLayer
    /// </summary>
    public class ProductData
    {

        private static List<Product> _ProductsList  //creating a reference varibale for List
        {
            set;
            get;

        }

        static ProductData() // creating a list object in constructor
        {

            _ProductsList = new List<Product>();


        }

        /// <summary>
        /// adding the products into the List
        /// </summary>
        /// <param name="productDetails">object of Product class</param>
        public void AddProduct(Product productDetails)// Adding Products into the ProductsList
        {
            _ProductsList.Add(productDetails);
            SaveIntoFile();
        }

        /// <summary>
        /// displaying the products in the List
        /// </summary>

        public List<Product> DisplayProducts() => _ProductsList;

        /// <summary>
        /// Removing a Product by using Product ID
        /// </summary>
        /// <param name="id">Product Id</param>
        public void RemoveProduct(string id) => _ProductsList.RemoveAll(n => n.ProductID == id);
        //Removing a Product by using Product ID


        /// <summary>
        /// Displaying product Details using Product ID
        /// </summary>
        /// <param name="productID">passing Product ID</param>
        /// <returns></returns>
        public Product GetProductByID(string productID)//Displaying product Details using Product ID
        {
            Product pe;
            pe = _ProductsList.Find(n => n.ProductID == productID);
            return pe;

        }


        /// <summary>
        /// update product Name
        /// </summary>
        /// <param name="product">reference of Product</param>

        public void UpdateProductName(Product product)// update product Name
        {
            Product PE = _ProductsList.Find(n => n.ProductID == product.ProductID);
            if (PE != null)
            {
                PE.ProductName = product.ProductName;
                SaveIntoFile();
            }
        }


        /// <summary>
        /// update method for Product Price
        /// </summary>
        /// <param name="product">object of Product class</param>
        public void UpdateProductPrice(Product product)
        {
            Product PE = _ProductsList.Find(n => n.ProductID == product.ProductID);
            if (PE != null)
            {
                PE.Price = product.Price;
            }
        }

        /// <summary>
        /// checking the product exits or not in the List
        /// </summary>
        /// <param name="productID">based on this parameter the product gets checked</param>
        /// <returns></returns>
        public bool CheckProductID(string productID)
        {
            return _ProductsList.Exists(n => n.ProductID == productID);

        }

        public void SaveIntoFile()
        {

            string s = JsonConvert.SerializeObject(_ProductsList);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\ProcuctData.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }

    }
}