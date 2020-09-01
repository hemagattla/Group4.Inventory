//Created by Hema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group4.Inventory.RawMaterialModule.EntityLayer

{
    //creating our own RawMaterialException
    public class RawMaterialException : ApplicationException
    {

        public RawMaterialException() : base()
        {

        }

        public RawMaterialException(string message) : base(message)
        {

        }



    }
}
