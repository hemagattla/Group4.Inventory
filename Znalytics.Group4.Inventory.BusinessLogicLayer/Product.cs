using System.Collections.Generic;
using System.Security.Policy;

public class Product
{
    private string _productName;
    private int _productId;
    // private string _ProductsAvailable;
    // private string _price;

    public void AddProduct(string productname, int productId)
    {

        ProductName = productname;
        ProductID = productId;

    }

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