using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;

namespace Znalytics.Group4.Inventory.IRawMaterialModule.BusinessLogicLayer
{
    public interface IRawMaterialBusinessLogicLayer
    {
        RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID);
    }
}
