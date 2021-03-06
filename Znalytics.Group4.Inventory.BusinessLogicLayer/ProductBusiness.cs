﻿//created by R.Krushal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.ProductModule.CustomException;
using Znalytics.Inventory.ProductModule.DataAccessLayer;
using Znalytics.Inventory.ProductModule.Entitie;

using Znalytics.Group4.Inventory.ProductModule.IBusinessLogicLayer;

namespace Znalytics.Inventory.ProductModule.BusinessLogicLayer
{

    /// <summary>
    /// refers t0 Product BusinessLogic
    /// </summary>
    public class ProductBusiness : IProductBusinessLogicLayer
    {

        ProductDataAccessLogic d;

        public ProductBusiness()
        {
            d = new ProductDataAccessLogic();
        }

        /// <summary>
        /// adding products 
        /// </summary>
        /// <param name="n"> gets object of ProductDetails</param>
        public void AddProducts(Product n)
        {
            try
            {
                if (n.ProductName != null)
                {

                    d.AddProduct(n);
                }
            }
            catch (Exception e)
            {

                throw new ProductException(e.Message);
            }
        }

        /// <summary>
        /// displaying the products
        /// </summary>
        /// <param name="n">gets object of ProductDeatils</param>

        public List<Product> DispalyProducts()
        {

            return d.DisplayProducts();
        }

        /// <summary>
        /// removing Product By ID
        /// </summary>
        /// <param name="id"></param>
        public void RemoveProduct(string id)
        {
            if (id != null)
            {
                d.RemoveProduct(id);
            }
        }


        /// <summary>
        /// update product name
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProductName(Product product)
        {
            if (product.ProductName != null)
            {
                d.UpdateProductName(product);
            }
        }
        /// <summary>
        /// update Product Price
        /// </summary>
        /// <param name="p">reference of Product class</param>
        public void UpdateProductPrice(Product p)
        {

            d.UpdateProductPrice(p);

        }

        /// <summary>
        /// getting Products details by productID
        /// </summary>
        /// <param name="ProductID">productID</param>
        /// <returns></returns>
        public Product GetProductByProductID(string ProductID) { return d.GetProductByID(ProductID); }

        /// <summary>
        /// checking whether Product is present in the list and return bool value
        /// </summary>
        /// <param name="productID"> gets product id from user</param>
        /// <returns>return true or false if the product is present in the list</returns>
        public bool CheckProductID(string productID)
        {


            bool result = d.CheckProductID(productID);
            if (result == true)
            {

                System.Console.WriteLine("ProductID Exits");
                return result;
            }
            return result;
        }


    }
}