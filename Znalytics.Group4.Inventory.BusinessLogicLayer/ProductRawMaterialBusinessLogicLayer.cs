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
    /// <summary>
    /// productRawMaterialBusiness Represents in a BusinessLogicLayer
    /// </summary>
    public class ProductRawMaterialBusinessLogicLayer
    {
        IRawMaterialBusinessLogicLayer irm; //creating reference variable of interface class
        IProductBusinessLogicLayer ipb; //creating reference variable of interface class
        ProductRawMaterialDataAccessLayer prda;//creating reference variable of ProductRawMaterialDataAccessLayer

        /// <summary>
        /// Constractor of ProductRawMaterialDataAccessLayer
        /// </summary>
        public ProductRawMaterialBusinessLogicLayer()
        {
              prda = new ProductRawMaterialDataAccessLayer();//creating object of dataAccesslayer
            irm = new RawMaterialBusinessLogicLayer();//creating object of RawMaterialBusinessLogicLayer
            ipb = new ProductBusiness();//creating object of ProductBusiness
        }
        /// <summary>
        /// To add the RawMaterials to Product
        /// </summary>
        /// <param name="productRawMaterial">contains all the details of feilds</param>
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
        /// <summary>
        /// deletes RawMaterial of Product
        /// </summary>
        /// <param name="productRawMaterial">contains all the details of feilds</param>
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
        /// <summary>
        ///checks weather entered product exits or not
        /// </summary>
        /// <param name="ProductID">Represents ProductID</param>
        /// <param name="RawMaterialID">Represents RawMaterialID</param>
        /// <returns>Returns the details</returns>
        public ProductRawMaterial GetProductRawMaterialByID(string ProductID,string RawMaterialID)
        {
           return prda.GetProductRawMaterialByID(ProductID,RawMaterialID);
        }
        /// <summary>
        /// Displays the Details in the List
        /// </summary>
        /// <returns></returns>
        public List<ProductRawMaterial> GetProductRawMaterial()
        {
            return prda.GetProductRawMaterial();
        }
        /// <summary>
        /// To update Quantity of RawMaterial
        /// </summary>
        /// <param name="productRawMaterial">Represents ProductID</param>
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
        /// <summary>
        /// checks entered ProductID exists or not in List
        /// </summary>
        /// <param name="ProductID">Represents the ProductID</param>
        /// <returns></returns>
        public Product GetProductByProductID(string ProductID)
        {
            
            return ipb.GetProductByProductID(ProductID);
        }
        /// <summary>
        /// checks entered RawMaterialID exists or not in List
        /// </summary>
        /// <param name="RawMaterialID">Represents the RawMaterialID</param>
        /// <returns></returns>
        public RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID)
        {
            
            return irm.GetRawMaterialByRawMaterialID(RawMaterialID);
        }

        /// <summary>
        /// checks entered productID exists or not. if yes Returns the Details
        /// </summary>
        /// <param name="productRawMaterial"></param>
        /// <returns></returns>
        public List<ProductRawMaterial> GetDetailsByProductID(ProductRawMaterial productRawMaterial)
        {
            return prda.GetDetailsByProductID(productRawMaterial);
        }
        /// <summary>
        /// Displays in Assending order 
        /// </summary>
        /// <returns></returns>
        public List<ProductRawMaterial> GetDetailsUsingOrderBy()
        {
            return prda.GetDetailsUsingOrderBy();
        }
        /// <summary>
        /// checks weather entered productID and RawMaterialID exists or not
        /// </summary>
        /// <param name="productRawMaterial"></param>
        /// <returns>Returns the details</returns>
        public ProductRawMaterial GetDetailsByProductIDAndRawMaterialID(ProductRawMaterial productRawMaterial)
        {

            return prda.GetDetailsByProductIDAndRawMaterialID(productRawMaterial);
        }


    }
}
