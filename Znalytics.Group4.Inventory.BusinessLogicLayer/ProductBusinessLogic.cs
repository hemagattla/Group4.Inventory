//created by R.Krushal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.Product.DataAccessLayer;
using Znalytics.Inventory.Product.Entities;

namespace Znalytics.Inventory.Product.BusinessLogicLayer
{

    /// <summary>
    /// refers tp Product BusinessLogic
    /// </summary>
    public class ProductBusiness
    {
        Productdata d;


        public ProductBusiness()
        {
            d = new Productdata();
        }
        /// <summary>
        /// adding the products 
        /// </summary>
        /// <param name="n"> gets object of ProductDetails</param>
        public void AddProducts(ProductEntitie n)
        {
            if (n.ProductName != null)
            {

                d.AddProduct(n);
            }
        }
        /// <summary>
        /// displaying the products
        /// </summary>
        /// <param name="n">gets object of ProductDeatils</param>

        public List<ProductEntitie> DispalyProducts()
        {

            return d.DisplayProducts();
        }

        /// <summary>
        /// removing Product By ID
        /// </summary>
        /// <param name="id"></param>
        public void RemoveProductByID(int id)
        {
            if (id != 0)
            {
                d.RemoveProductByID(id);
            }
        }
        /// <summary>
        /// remove Product By Product name
        /// </summary>
        /// <param name="name"></param>
        public void RemoveProductByName(string name)
        {
            if (name != null)
            {
                d.RemoveProductByName(name);
            }
        }
        /// <summary>
        /// Displaying the Product Details By using ProductID
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>

        public ProductEntitie GetProductByID(int productID)
        {
            return d.GetProductByID(productID);
        }


        public void UpdateProductName(ProductEntitie product)
        {
            if (product.ProductName != null)
            {
                d.UpdateProductName(product);
            }
        }
    }
}