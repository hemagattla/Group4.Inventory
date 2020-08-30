using System;
using System.Collections.Generic;
using Znalytics.Inventory.ProductModule.Entitie;

namespace Znalytics.Group4.Inventory.ProductModule.IBusinessLogicLayer
{
    public interface IProductBusinessLogicLayer
    {
        //void AddProducts(Product n);

        //void RemoveProductByID(int id);

       // void RemoveProductByName(string name);

        //void UpdateProductName(Product product);

        //void UpdateProductPrice(Product p);

        Product GetProductByProductID(string ProductID);
        
        //List<Product> DispalyProducts();
    }
}

