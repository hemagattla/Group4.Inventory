//created by R.Krushal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.ProductModule.DataAccessLayer;
using Znalytics.Inventory.ProductModule.Entitie;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;
using Znalytics.Group4.Inventory.ProductModule.IBusinessLogicLayer;

namespace Znalytics.Inventory.ProductModule.BusinessLogicLayer
{

    /// <summary>
    /// refers tp Product BusinessLogic
    /// </summary>
    public class ProductBusiness: IProductBusinessLogicLayer
    {
        ProductData d;


        public ProductBusiness()
        {
            d = new ProductData();
        }
        /// <summary>
        /// adding products 
        /// </summary>
        /// <param name="n"> gets object of ProductDetails</param>
        public void AddProducts(Product n)
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

        public List<Product> DispalyProducts()
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
        public void UpdateProductName(Entitie.Product product)
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
        public void UpdateProductPrice(Entitie.Product p)
        {


            d.UpdateProductPrice(p);

        }

        /// <summary>
        /// getting Products details by productID
        /// </summary>
        /// <param name="ProductID">productID</param>
        /// <returns></returns>
        public Entitie.Product GetProductByProductID(int ProductID)
        {
            return d.GetProductByID(ProductID);
          
        }


    }
}