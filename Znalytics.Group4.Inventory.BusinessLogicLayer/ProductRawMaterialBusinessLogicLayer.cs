using System;
using System.Collections.Generic;
using System.Linq;
using Znalytics.Group4.Inventory.ProductModule.IBusinessLogicLayer;
using Znalytics.Group4.Inventory.IRawMaterialModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities;
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities;
using Znalytics.Inventory.ProductModule.Entitie;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.DataAccessLayer;

namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.BusinessLogicLayer
{
    public class ProductRawMaterialBusinessLogicLayer: IProductBusinessLogicLayer, IRawMaterialBusinessLogicLayer
    {
        //ProductBusiness pb = new ProductBusiness();
        //RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
        ProductRawMaterialDataAccessLayer prda;
        public ProductRawMaterialBusinessLogicLayer()
        {
              prda = new ProductRawMaterialDataAccessLayer();
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
        public Product GetProductByProductID(string ProductID) { return prda.GetProductByID(ProductID); }
        public RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID)
        {
            return prda.GetRawMaterialByRawMaterialID(RawMaterialID);

        }

    }
}
