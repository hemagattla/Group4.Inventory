//created by R.Krushal


using System;
using System.Collections.Generic;
using Znalytics.Inventory.Product.Entities;
/// <summary>
/// Represents Interface of IdataAcessLogic
/// </summary>
namespace Znalytics.Group4.Inventory.IDataAccessLayer
{
    interface IproductDataAccessLogic
    {
        void AddProduct(ProductEntitie productDetails);
        List<ProductEntitie> DisplayProducts();
    }
}
