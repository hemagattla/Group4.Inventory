using System;
using System.Collections.Generic;
using Znalytics.Inventory.Product.Entities;

namespace Znalytics.Group4.Inventory.IBusinessLogicLayer
{
    public interface IProductBusinessLogicLayer
    {
        Product GetProductByProductID(int ProductID);
    }
}

