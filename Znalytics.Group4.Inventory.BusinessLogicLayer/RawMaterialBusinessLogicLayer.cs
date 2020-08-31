using System;
using System.Collections.Generic;
using System.Linq;
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;
using Znalytics.Group4.Inventory.RawMaterialModule.DataAccessLayer;
using Znalytics.Group4.Inventory.IRawMaterialModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.RawMaterialModule.EntityLayer;

namespace Znalytics.Group4.Inventory.RawMaterialModule.BusinessLogicLayer
{
    /// <summary>
    ///RawMaterialBusinessLogicLayer is a Public Class child class of IRawMaterialBusinessLogicLayer Interface
    /// </summary>
    public class RawMaterialBusinessLogicLayer : IRawMaterialBusinessLogicLayer//Interface Name
    {
        //creating reference variable of RawMaterialDataAccessLayer class
        RawMaterialDataAccessLayer _rawMaterialDataAccessLayer;

        /// <summary>
        /// RawMaterialBusinessLogicLayer is a public Constructor
        /// </summary>
        public RawMaterialBusinessLogicLayer()
        {
            _rawMaterialDataAccessLayer = new RawMaterialDataAccessLayer();//creating object of RawMaterialDataAccessLayer class
        }
        /// <summary>
        /// AddRawMaterial Method is a instance method used to Add RawMaterial Details to list
        /// </summary>
        /// <param name="rawMaterial">Represents the Reference variable of RawMaterial class</param>
        public void AddRawMaterial(RawMaterial rawMaterial)
        {
            try
            {
                if ((rawMaterial.RawMaterialName != null) && (rawMaterial.RawMaterialID != null) && (rawMaterial.Quantity != 0D) && (rawMaterial.Units != null) && (rawMaterial.Price != 0D))
                {
                    _rawMaterialDataAccessLayer.AddRawMaterial(rawMaterial);
                }
                else
                {
                    throw new RawMaterialException("ur entered input not valid");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// DeleteRawmaterial is instance method used to delete RawMaterial details from the List
        /// </summary>
        /// <param name="rawMaterial">Represents the Reference variable of RawMaterial class</param>
        public void DeleteRawMaterial(RawMaterial rawMaterial)
        {
            try
            {
                if (rawMaterial.RawMaterialID != null) 
                {
                    _rawMaterialDataAccessLayer.DeleteRawMaterial(rawMaterial);
                }
                else
                {
                    throw new RawMaterialException("ur entered input not valid");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// GetRawMaterial is a instance method used to return the list
        /// </summary>
        /// <returns>Returns the list of RawMaterial details</returns>
        public List<RawMaterial> GetRawMaterial()
        {

            return _rawMaterialDataAccessLayer.GetRawMaterial();

        }


        /// <summary>
        /// UpdateRawMaterialPrice is a instance method used to update price of the RawMaterial
        /// </summary>
        /// <param name="rawMaterial">Represents the Reference variable of RawMaterial class</param>
        public void UpdateRawMaterialPrice(RawMaterial rawMaterial)
        {
            try
            {
                if (rawMaterial.Price != 0D)
                {
                    _rawMaterialDataAccessLayer.UpdateRawMaterialPrice(rawMaterial);
                }
                else
                {
                    throw new RawMaterialException("ur entered input not valid");
                }
            }
            catch
            {
                throw;
            }

        }
       
        /// <summary>
        /// UpdateRawMaterialQuantity is a instance method used to Updates the Quantity of RawMaterial
        /// </summary>
        /// <param name="rawMaterial">Represents the Reference variable of RawMaterial class</param>
        public void UpdateRawMaterialQuantity(RawMaterial rawMaterial)
        {

            try
            {
                if (rawMaterial.Quantity != 0D)
                {
                    _rawMaterialDataAccessLayer.UpdateRawMaterialQuantity(rawMaterial);
                }
                else
                {
                    throw new RawMaterialException("ur entered input not valid");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// GetRawMaterialByRawMaterialID is a instance method used to represent whethere the RawMaterial exists or not based on RawMaterialID
        /// </summary>
        /// <param name="RawMaterialID">Represents the ID of RawMaterial</param>
        /// <returns> Used to Represent the Details of Corresponding RawMaterialID</returns>
        public RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID)
        {
            return _rawMaterialDataAccessLayer.GetRawMaterialByRawMaterialID(RawMaterialID);

        }
       
    }
}
