//created by Hema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;

namespace Znalytics.Group4.Inventory.IRawMaterialModule.BusinessLogicLayer
{
    /// <summary>
    /// IRawMaterialBusinessLogicLayer is a interface class. We can't create an object
    /// </summary>
    interface IRawMaterialBusinessLogicLayer
    {
        /// <summary>
        /// GetRawMaterialByRawMaterialID is a abstract method
        /// </summary>
        /// <param name="RawMaterialID">Represents RawMaterialID</param>
        /// <returns>Return type is RawMaterial</returns>
        RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID);
    }
}
