//created by R.Krushal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.Product.DataAccessLayer;
using Znalytics.Inventory.Product.Entities;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;

namespace Znalytics.Inventory.Product.BusinessLogicLayer
{

    /// <summary>
    /// refers tp Product BusinessLogic
    /// </summary>
    public class ProductBusiness: IProductBusinessLogicLayer
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
        public void AddProducts(Entities.Product n)
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

        public List<Entities.Product> DispalyProducts()
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

     

        /// <summary>
        /// update product name
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProductName(Entities.Product product)
        {
            if (product.ProductName != null)
            {
                d.UpdateProductName(product);
            }
        }

        public void UpdateProductPrice(Entities.Product p)
        {


            d.UpdateProductPrice(p);

        }

        public Entities.Product GetProductByProductID(int ProductID)
        {
            return d.GetProductByID(ProductID);
          
        }


    }
}