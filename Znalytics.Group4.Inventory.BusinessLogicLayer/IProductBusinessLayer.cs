using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Znalytics.Inventory.Product.Entities;

namespace Znalytics.Group4.Inventory.IBusinessLogicLayer
{
    interface IProductBusinessLayer
    {
         void AddProducts(ProductEntitie n);
         List<ProductEntitie> DispalyProducts();
         void RemoveProductByID(int id);
        void RemoveProductByName(string name);
    }
}
