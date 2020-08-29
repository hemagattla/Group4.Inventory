using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.RawMaterialModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.DataAccessLayer;

namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.BusinessLogicLayer
{
    public class ProductRawMaterialBusinessLogicLayer
    {
        ProductBusiness pb = new ProductBusiness();
        RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
        public ProductRawMaterialBusinessLogicLayer()
        {
             ProductRawMaterialDataAccessLayer prda = new ProductRawMaterialDataAccessLayer();
        }
        public void AddRawMaterialToProduct(ProductRawMaterials productRawMaterial)
        {
            if((productRawMaterial.ProductID!=null)&&(productRawMaterial.RawMaterialID != null)&&(productRawMaterial.RawMaterialName != null)&&(productRawMaterial.Quantity != 0D)&&(productRawMaterial.Units != null))
            {
                prda.AddRawMaterialToProduct(productRawMaterial);
            }
            else
            {
                System.Console.WriteLine("Entered Values contail null values");
            }
        }
        public void DeleteRawMaterialOfProduct(ProductRawMaterials productRawMaterial)
        {
            if ((productRawMaterial.ProductID != null) && (productRawMaterial.RawMaterialID != null) && (productRawMaterial.RawMaterialName != null))// && (productRawMaterial.Quantity != 0D) && (productRawMaterial.Units != null))
            {
                prda.DeleteRawMaterialOfProduct(productRawMaterial);
            }
            else
            {
                System.Console.WriteLine("Entered Values contail null values");
            }
        }
        public List<ProductRawMaterials> GetRawMaterialByRawMaterialID()
        {
            return prda.GetRawMaterialByRawMaterialID();
        }
        public void UpdateRawMaterialOfProduct(ProductRawMaterials productRawMaterial)
        {
            if ((productRawMaterial.ProductID != null) && (productRawMaterial.RawMaterialID != null) && (productRawMaterial.RawMaterialName != null) && (productRawMaterial.Quantity != 0D) && (productRawMaterial.Units != null))
            {
                prda.UpdateRawMaterialOfProduct(productRawMaterial);
            }
            else
            {
                System.Console.WriteLine("Entered Values contail null values");
            }
        }
    }
}
