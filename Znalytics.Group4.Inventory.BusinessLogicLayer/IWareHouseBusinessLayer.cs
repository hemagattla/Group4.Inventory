﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{
   public interface IWareHouseBusinessLayer
    {
        string getStockStatus();
        int getStockQuantity();
        
    }
}
