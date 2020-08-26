using System;
using System.Collections.Generic;
using Znalytics.Inventory.Product.Entitie;

namespace Znalytics.Group4.Inventory.IBusinessLogicLayer
{
    public interface IProductBusinessLogicLayer
    {
        void AddProducts(Product n);

        void RemoveProductByID(int id);

        void RemoveProductByName(string name);

        void UpdateProductName(Product product);

        void UpdateProductPrice(Product p);

        Product GetProductByProductID(int ProductID);
        
        List<Product> DispalyProducts();
    }
}

