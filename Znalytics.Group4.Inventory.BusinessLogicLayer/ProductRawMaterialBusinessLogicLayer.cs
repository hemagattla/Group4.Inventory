using System.Collections.Generic;
using Znalytics.Group4.Inventory.ProductModule.IBusinessLogicLayer;
using Znalytics.Group4.Inventory.IRawMaterialModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities;
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;
using Znalytics.Inventory.ProductModule.Entitie;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.DataAccessLayer;
using Znalytics.Group4.Inventory.RawMaterialModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;

namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.BusinessLogicLayer
{
    public class ProductRawMaterialBusinessLogicLayer
    {
        IRawMaterialBusinessLogicLayer irm; //= new RawMaterialBusinessLogicLayer();
        IProductBusinessLogicLayer ipb; //= new ProductBusiness();
        ProductRawMaterialDataAccessLayer prda;

        public ProductRawMaterialBusinessLogicLayer()
        {
              prda = new ProductRawMaterialDataAccessLayer();
            irm = new RawMaterialBusinessLogicLayer();
            ipb = new ProductBusiness();
        }
        public void AddRawMaterialToProduct(ProductRawMaterial productRawMaterial)
        {
            try
            {
                if ((productRawMaterial.ProductID != null) && (productRawMaterial.RawMaterialID != null) && (productRawMaterial.RawMaterialName != null) && (productRawMaterial.Quantity != 0D) && (productRawMaterial.Units != null))
                {
                    prda.AddRawMaterialToProduct(productRawMaterial);
                }
                else
                {
                    throw new ProductRawMaterialException("Entered Values contains null values");
                }
            }
            catch
            {
                throw;
            }
        }
        public void DeleteRawMaterialOfProduct(ProductRawMaterial productRawMaterial)
        {
            try
            {
                if ((productRawMaterial.ProductID != null) && (productRawMaterial.RawMaterialID != null))// && (productRawMaterial.Quantity != 0D) && (productRawMaterial.Units != null))
                {
                    prda.DeleteRawMaterialOfProduct(productRawMaterial);
                }
                else
                {
                    throw new ProductRawMaterialException("Entered Values contains null values");
                }
            }
            catch
            {

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
        public void UpdateQuantityOfProduct(ProductRawMaterial productRawMaterial)
        {
            try
            {
                if ((productRawMaterial.ProductID != null) && (productRawMaterial.RawMaterialID != null) && (productRawMaterial.Quantity != 0D))
                {
                    prda.UpdateQuantityOfProduct(productRawMaterial);
                }
                else
                {
                    throw new ProductRawMaterialException("Entered Values contains null values");
                }
            }
            catch
            {
                throw;
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

     
        public List<ProductRawMaterial> GetDetailsByProductID(ProductRawMaterial productRawMaterial)
        {
            return prda.GetDetailsByProductID(productRawMaterial);
        }
        public List<ProductRawMaterial> GetDetailsUsingOrderBy()
        {
            return prda.GetDetailsUsingOrderBy();
        }
        public ProductRawMaterial GetDetailsByProductIDAndRawMaterialID(ProductRawMaterial productRawMaterial)
        {

            return prda.GetDetailsByProductIDAndRawMaterialID(productRawMaterial);
        }


    }
}
