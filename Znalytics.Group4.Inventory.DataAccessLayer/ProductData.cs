using System.Collections.Generic;
using System.ComponentModel;

public class Productdata
{
    private List<ProductDetails> ProductsList
    {
        set;
        get;
    }

    public Productdata()
    {
        ProductsList = new List<ProductDetails>();
    }

    public void AddProduct(ProductDetails productDetails)
    {
        ProductsList.Add(productDetails);
    }


    public void DisplayProducts(ProductDetails wareHouse)
    {
        for (int i = 0; i < ProductsList.Count; i++)
        {
            ProductDetails n = ProductsList[i];
            System.Console.WriteLine("Product Name ={0},Product Id ={1},Price= {3}", n.ProductName, n.ProductID, n.Price);
        }


    }

}
