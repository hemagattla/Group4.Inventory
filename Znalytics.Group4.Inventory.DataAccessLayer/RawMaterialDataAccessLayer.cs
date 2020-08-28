using System;
using System.Collections.Generic;
using System.Linq;
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;
using Newtonsoft.Json.Serialization;


namespace Znalytics.Group4.Inventory.RawMaterialModule.DataAccessLayer
{
    public class RawMaterialDataAccessLayer
    {
        private static List<RawMaterial> _rawMaterials;
        static RawMaterialDataAccessLayer()
        {
            _rawMaterials = new List<RawMaterial>();
        }
        public void AddRawMaterial(RawMaterial rawMaterial)
        {
            _rawMaterials.Add(rawMaterial);
        }
        public void DeleteRawMaterial(RawMaterial rawMaterial)
        {
            _rawMaterials.Remove(rawMaterial);
        }
        public List<RawMaterial> GetRawMaterial()
        {
            return _rawMaterials;
        }
        public void UpdateRawMaterial(RawMaterial rawMaterial)
        {
          RawMaterial abc = _rawMaterials.Find(temp => temp.RawMaterialID == rawMaterial.RawMaterialID && temp.RawMaterialName == rawMaterial.RawMaterialName);
            if(abc!=null)
            {
                abc.Quantity = rawMaterial.Quantity;
                abc.Price = rawMaterial.Price;
            }
        }
    }
}
