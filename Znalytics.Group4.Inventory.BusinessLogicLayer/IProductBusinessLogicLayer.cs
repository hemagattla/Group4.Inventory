﻿using System;
using System.Collections.Generic;
using Znalytics.Inventory.Product.Entities;

namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{
    public interface IProductBusinessLogicLayer
    {
        ProductEntitie GetProductByProductID(int ProductID);
    }
}

