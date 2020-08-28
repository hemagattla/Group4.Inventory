using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;
using Znalytics.Group4.Inventory.RawMaterialModule.DataAccessLayer;


namespace Znalytics.Group4.Inventory.RawMaterialModule.BusinessLogicLayer
{
    public  class RawMaterialBusinessLogicLayer
    {
        RawMaterialDataAccessLayer _rawMaterialDataAccessLayer;
       public RawMaterialBusinessLogicLayer()
        {
            _rawMaterialDataAccessLayer = new RawMaterialDataAccessLayer();
        }
        public void AddRawMaterial(RawMaterial rawMaterial)
        {
            if ((rawMaterial.RawMaterialName != null)&& (rawMaterial.RawMaterialID!=null)&&(rawMaterial.Quantity!=null)&&(rawMaterial.Units!=null)&&(rawMaterial.Price!=0D))
            {
                _rawMaterialDataAccessLayer.AddRawMaterial(rawMaterial);
            }
        }
        public void DeleteRawMaterial(RawMaterial rawMaterial)
        {
            if ((rawMaterial.RawMaterialName != null) && (rawMaterial.RawMaterialID != null) && (rawMaterial.Quantity != null) && (rawMaterial.Units != null) && (rawMaterial.Price != 0D))
            {
                _rawMaterialDataAccessLayer.DeleteRawMaterial(rawMaterial);
            }
        }
        public List<RawMaterial> GetRawMaterial()
        {
            return _rawMaterialDataAccessLayer.GetRawMaterial();
        }
        public void UpdateRawMaterial(RawMaterial rawMaterial)
        {
            if((rawMaterial.Price!=0D)||(rawMaterial.Quantity!=null))
            {
                _rawMaterialDataAccessLayer.UpdateRawMaterial(rawMaterial);
            }
        }
    }
}
