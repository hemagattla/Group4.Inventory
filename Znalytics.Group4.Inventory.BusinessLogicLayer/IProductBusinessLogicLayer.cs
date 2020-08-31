//created by R.Krushal

using System;
using System.Collections.Generic;
using Znalytics.Inventory.ProductModule.Entitie;

namespace Znalytics.Group4.Inventory.ProductModule.IBusinessLogicLayer
{
    /// <summary>
    /// referes to interface of product BsuinessLogic Layer
    /// </summary>
    public interface IProductBusinessLogicLayer
    {
        /// <summary>
        /// abstract method to add products into List
        /// </summary>
        /// <param name="n">Takes parameter of Product type which contains all the details to be inserted into the List</param>
        void AddProducts(Product n);
        
        /// <summary>
        /// referes to Abstarct method to remove a product by product ID
        /// </summary>
        /// <param name="id">take the parameter of productID from the user, to remove particular product</param>
        void RemoveProduct(string id);

        /// <summary>
        /// refers to Abstract method upadate Product name
        /// </summary>
        /// <param name="product">takes parameter of product type which contains product id to which name has to be change</param>
        void UpdateProductName(Product product);

        /// <summary>
        /// referes to abstract method to update ProductProice 
        /// </summary>
        /// <param name="p">takes parameter of product type which contains product id to which Price has to be change</param>
        void UpdateProductPrice(Product p);

        /// <summary>
        /// refers to abstract method to get product details by using Product Id
        /// </summary>
        /// <param name="ProductID">take the parameter of productID from the user, to get product details of Particular product ID </param>
        /// <returns>returns product type which contains all the matching ProductId details</returns>
        Product GetProductByProductID(string ProductID);
        
        /// <summary>
        /// refers to abstract mehtod to get details of products available in the products list
        /// </summary>
        /// <returns>retruns List of Products available in the Products List</returns>
        List<Product> DispalyProducts();
    }
}

