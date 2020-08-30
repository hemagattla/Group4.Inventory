//created by R.krushal



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
    public class ProductDataAccessLogic
    {
        /// <summary>
        /// creating a private List of Product class
        /// </summary>
        private static List<Product> _productsList  //creating a reference varibale for List
        {
            set;
            get;

        }
        /// <summary>
        /// static Constructor to initialize
        /// </summary>
        static ProductDataAccessLogic() // creating a list object in constructor
        {

            _productsList = new List<Product>()
            {
                new Product(){ProductID="PID10",ProductName="mobile",Price=99}

             };
            if (_productsList.Count == 0)
            {
                _productsList = GetFiledata();
            }


        }
       

        /// <summary>
        /// adding the products into the List
        /// </summary>
        /// <param name="productDetails">object of Product class</param>
        public void AddProduct(Product productDetails)// Adding Products into the ProductsList
        {
           
            
                _productsList.Add(productDetails);
                SaveIntoFile();
            
        }

        /// <summary>
        /// displaying the products in the List
        /// </summary>

        public List<Product> DisplayProducts() => _productsList;

        /// <summary>
        /// Removing a Product by using Product ID
        /// </summary>
        /// <param name="id">Product Id</param>
        public void RemoveProduct(string id) => _productsList.RemoveAll(n => n.ProductID == id);
        //Removing a Product by using Product ID


        /// <summary>
        /// Displaying product Details using Product ID
        /// </summary>
        /// <param name="productID">passing Product ID</param>
        /// <returns></returns>
        public Product GetProductByID(string productID)//Displaying product Details using Product ID
        {
            Product pe;
            pe = _productsList.Find(n => n.ProductID == productID);
            return pe;

        }


        /// <summary>
        /// update product Name
        /// </summary>
        /// <param name="product">reference of Product</param>

        public void UpdateProductName(Product product)// update product Name
        {
            Product PE = _productsList.Find(n => n.ProductID == product.ProductID);
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
            Product PE = _productsList.Find(n => n.ProductID == product.ProductID);
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
            return _productsList.Exists(n => n.ProductID == productID);

        }

        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        public void SaveIntoFile()
        {

            string s = JsonConvert.SerializeObject(_productsList);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\ProcuctData.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        /// <summary>
        /// reading the data from Json file and return the data in the file in List format
        /// </summary>
        /// <returns>return List of products avaliable int ProductData.Txt</returns>
        public static List<Product> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\ProcuctData.txt");
            string s2 = streamReader.ReadToEnd();
            List<Product> customers2 = JsonConvert.DeserializeObject<List<Product>>(s2);
            streamReader.Close();
            return customers2;

        }

    }
}