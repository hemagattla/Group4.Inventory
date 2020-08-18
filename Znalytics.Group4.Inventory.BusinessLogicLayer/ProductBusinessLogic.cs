//created by R.Krushal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// refers tp Product BusinessLogic
/// </summary>
public class ProductBusiness
{

    /// <summary>
    /// adding the products 
    /// </summary>
    /// <param name="n"></param>
    public void AddProducts(ProductDetails n)
    {
        if (n.ProductName != null)
        {
            Productdata d = new Productdata();
            d.AddProduct(n);
        }
    }
    /// <summary>
    /// displaying the products
    /// </summary>
    
    public void DisplayProducts(ProductDetails n)
    {
        Productdata d = new Productdata();
        d.DisplayProducts(n);

    }


}
