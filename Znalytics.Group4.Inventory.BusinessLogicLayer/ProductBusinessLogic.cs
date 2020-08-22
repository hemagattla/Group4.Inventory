//created by R.Krushal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.BusinessLogicLayer;
using Znalytics.Inventory.Product.DataAccessLayer;
using Znalytics.Inventory.Product.Entities;

namespace Znalytics.Inventory.Product.BusinessLogicLayer
{

    /// <summary>
    /// refers tp Product BusinessLogic
    /// </summary>
    public class ProductBusiness : IProductBusinessLogicLayer
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

       public ProductEntitie GetProductByID

        public void RemoveProductByID(int id)
        {
            if (id != 0)
            {
                d.RemoveProductByID(id);
            }
        }
        public void RemoveProductByName(string name)
        {
            if (name != null)
            {
                d.RemoveProductByName(name);
            }
        }

    }
}