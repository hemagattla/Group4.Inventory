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
    ///Public class RawMaterialBusinessLogicLayer 
    /// </summary>
    public class RawMaterialBusinessLogicLayer : IRawMaterialBusinessLogicLayer//Interface Name
    {
        //creating reference variable of RawMaterialDataAccessLayer class
        RawMaterialDataAccessLayer _rawMaterialDataAccessLayer;
        //public Constructor
        public RawMaterialBusinessLogicLayer()
        {
            _rawMaterialDataAccessLayer = new RawMaterialDataAccessLayer();//creating object of RawMaterialDataAccessLayer class
        }
        //AddRawMaterial Method
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
        //Deletes the RawMaterial details
        public void DeleteRawMaterial(RawMaterial rawMaterial)
        {
            try
            {
                if ((rawMaterial.RawMaterialName != null) && (rawMaterial.RawMaterialID != null) && (rawMaterial.Quantity != 0D) && (rawMaterial.Units != null) && (rawMaterial.Price != 0D))
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
        //returns the list of RawMaterial details
        public List<RawMaterial> GetRawMaterial()
        {

            return _rawMaterialDataAccessLayer.GetRawMaterial();

        }
        //used to update price of the RawMaterial
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
        //Updates the Quantity of RawMaterial
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
        //represents whethere the RawMaterial exists or not based on RawMaterialID
        public RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID)
        {
            return _rawMaterialDataAccessLayer.GetRawMaterialByRawMaterialID(RawMaterialID);

        }
        //represents whethere the RawMaterial exists or not based on RawMaterialID
        public RawMaterial GetRawMaterialNameByRawMaterialID(string RawMaterialID)
        {
            return _rawMaterialDataAccessLayer.GetRawMaterialNameByRawMaterialID(RawMaterialID);

        }
    }
}
