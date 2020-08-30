using System;
using System.Collections.Generic;
using System.Linq;
using Znalytics.Group4.Inventory.ProductModule.IBusinessLogicLayer;
using Znalytics.Group4.Inventory.IRawMaterialModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities;
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;
//using Znalytics.Group4.Inventory.RawMaterialModule.DataAccessLayer;

using Znalytics.Inventory.ProductModule.Entitie;
//using Znalytics.Inventory.ProductModule.DataAccessLayer;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.DataAccessLayer;

using Znalytics.Group4.Inventory.RawMaterialModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;

namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.BusinessLogicLayer
{
    public class ProductRawMaterialBusinessLogicLayer
    {
        IRawMaterialBusinessLogicLayer irm = new RawMaterialBusinessLogicLayer();
        IProductBusinessLogicLayer ipb = new ProductBusiness();
        //ProductBusiness pb = new ProductBusiness();
        //RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
        ProductRawMaterialDataAccessLayer prda;
        //RawMaterialDataAccessLayer rawMaterialDataAccessLayer = new RawMaterialDataAccessLayer();
        //ProductData productData = new ProductData();
        public ProductRawMaterialBusinessLogicLayer()
        {
              prda = new ProductRawMaterialDataAccessLayer();
        }
        public void AddRawMaterialToProduct(ProductRawMaterial productRawMaterial)
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
        public void DeleteRawMaterialOfProduct(ProductRawMaterial productRawMaterial)
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
        public ProductRawMaterial GetProductRawMaterialByID(string ProductID,string RawMaterialID)
        {
           return prda.GetProductRawMaterialByID(ProductID,RawMaterialID);
        }
        public List<ProductRawMaterial> GetProductRawMaterial()
        {
            return prda.GetProductRawMaterial();
        }
        public void UpdateRawMaterialOfProduct(ProductRawMaterial productRawMaterial)
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
        public Product GetProductByProductID(string ProductID)
        {
            return ipb.GetProductByProductID(ProductID);
        }
        public RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID)
        {
            return irm.GetRawMaterialByRawMaterialID(RawMaterialID);
        }

            //public Product GetProductByProductID(string ProductID) { return productData.GetProductByID(ProductID); }
           /* public RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID)
        {
            return rawMaterialDataAccessLayer.GetRawMaterialByRawMaterialID(RawMaterialID);

        }*/
        public List<ProductRawMaterial> GetDetailsByProductID(ProductRawMaterial productRawMaterial)
        {
            return prda.GetDetailsByProductID(productRawMaterial);
        }
        public List<ProductRawMaterial> GetDetailsUsingOriderBy()
        {
            return prda.GetProductRawMaterial();
        }
        

       
    }
}
