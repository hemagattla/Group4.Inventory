﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Inventory.StockMaintain.CustomException
{
    class StockException:ApplicationException
    {

        public StockException():base()
        {

        }

        public StockException(string message):base(message)
        {

        }
    }
}
