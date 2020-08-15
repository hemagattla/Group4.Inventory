using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

public class Product
{
    int i = 0, j = 0, k = 0;
    private string[] _productName = new string[10];
    private int[] _productID = new int[10];
    private int[] _productAvailable = new int[10];
    public void AddProductName(string Value)
    {

        _productName[i] = Value;
        i++;



    }
    public void AddProductID(int ProductID)
    {

        _productID[j] = ProductID;
        j++;
    }

    public void SetProductAvalability(int ProductAvailable)
    {

        _productAvailable[k] = ProductAvailable;
        k++;
    }


    public string GetProduct()
    {

        for (int i = 0; i < _productName.Length; i++)
        {
            return (_productName[i]);
        }
        return null;


    }
    public int GetProductID()
    {

        for (int i = 0; i < _productID.Length; i++)
        {
            return _productID[i];

        }
        return 0;


    }

    public int GetNoofProducts()
    {

        for (int i = 0; i < _productAvailable.Length; i++)
        {
            return _productAvailable[i];

        }
        return 0;


    }
}