using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ProductBusiness
{


    public void AddWareHouse(ProductDetails n)
    {
        if (n.ProductName != null)
        {
            Productdata d = new Productdata();
            d.AddProduct(n);
        }
    }

    public void DisplayProducts(ProductDetails n)
    {
        Productdata d = new Productdata();
        d.DisplayProducts(n);

    }


}
