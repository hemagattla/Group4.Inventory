using System;
using System.Collections.Generic;
using Znalytics.Inventory.Product.Entities;

namespace Znalytics.Inventory.Product.BusinessLogicLayer
{
    public interface IProductBusinessLogicLayer
    {
        ProductEntitie GetProductByProductID(int ProductID);
    }
}

