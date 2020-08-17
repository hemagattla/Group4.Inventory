//Created by R.Krushal
using System.Collections.Generic;
using System.Security.Policy;
/// <summary>
/// Represents Product Class
/// </summary>
public class Product
{
    private string _productName;
    private int _productId;
    private string _ProductsAvailable;
    private string _price;

    /// <summary>
    /// adding a product passing arguments of product name and product id
    /// </summary>
    /// <param name="productname"></param>
    /// <param name="productId"></param>
    public void AddProduct(string productname, int productId)
    {

        ProductName = productname;
        ProductID = productId;

    }
    /// <summary>
    /// properties of Productname
    /// </summary>
    public string ProductName
    {
        set
        {
            if (value != " ")
                _productName = value;
        }
        get
        {
            return _productName;
        }
    }
    /// <summary>
    /// properties of ProductID
    /// </summary>
    public int ProductID
    {
        set
        {
            _productId = value;
        }
        get
        {
            return _productId;
        }
    }
}