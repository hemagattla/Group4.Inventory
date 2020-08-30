using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities;

namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.DataAccessLayer
{
    public class ProductRawMaterialDataAccessLayer
    {

        /// <summary>
        /// creating list for RawMaterial Details
        /// </summary>
        private static List<ProductRawMaterial> _productRawMaterials;

        /// <summary>
        /// static constructor used to creating object for the list and add details to the list
        /// </summary>
        static ProductRawMaterialDataAccessLayer()

        {
            _productRawMaterials = new List<ProductRawMaterial>();//creating object for list 

            // _productRawMaterialss = GetFiledata();
        }

        /// <summary>
        /// AddRawMaterial is a static Method used to Add RawMaterial to the List
        /// </summary>
        /// <param name="rawMaterial">Represents the Reference variable of RawMarial class</param>
        public void AddRawMaterialToProduct(ProductRawMaterial productRawMaterial)
        {

            _productRawMaterials.Add(productRawMaterial);//Addess RawMaterial details to List
            //ListOfRawMaterials();
        }

        /// <summary>
        /// DeleteRawMaterial is a instance Method used to Delete RawMaterial from the List
        /// </summary>
        /// <param name="rawMaterial">is a variable of RawMaterial type</param>
        public void DeleteRawMaterialOfProduct(ProductRawMaterial productRawMaterial)
        {
            _productRawMaterials.RemoveAll(temp => temp.ProductID == productRawMaterial.ProductID && temp.RawMaterialID == productRawMaterial.RawMaterialID);
            // ListOfRawMaterials();
        }

        /// <summary>
        /// Return the List of RawMaterial Details
        /// </summary>
        /// <returns>Returns the list</returns>
        public List<ProductRawMaterial> GetProductRawMaterial()
        {
            return _productRawMaterials;
        }
       public ProductRawMaterial GetProductRawMaterialByID(string ProductID,string RawMaterialID)
       {
          ProductRawMaterial abc = _productRawMaterials.Find(temp => temp.ProductID == ProductID && temp.RawMaterialID==RawMaterialID);
          return abc;
       }

        /// <summary>
        /// UpdateRawMaterialPrice is a instane method used to Update the RawMaterial Price Based on RawMaterialName and RawMaterialID
        /// </summary>
        /// <param name="rawMaterial">is a variable of RawMaterial type</param>
        public void UpdateQuantityOfProduct(ProductRawMaterial productRawMaterial)
        {
            ProductRawMaterial abc = _productRawMaterials.Find(temp => temp.ProductID == productRawMaterial.ProductID && temp.RawMaterialID == productRawMaterial.RawMaterialID);

            abc.Quantity = productRawMaterial.Quantity;
            // ListOfRawMaterials();
        }
        public List<ProductRawMaterial> GetDetailsByProductID(ProductRawMaterial productRawMaterial)
        {
            List<ProductRawMaterial> ab= _productRawMaterials.Where(temp => temp.ProductID == productRawMaterial.ProductID)/*.Select(temp=>new AddRawMaterial() { RawMaterialID, RawMaterialName }*/.ToList();
            return ab;
        }
        public List<ProductRawMaterial> GetDetailsUsingOriderBy()
        {
            List<ProductRawMaterial> ab = _productRawMaterials.OrderBy(temp => temp.ProductID)
                .ThenBy(temp=> temp.RawMaterialID)
                .ThenBy(temp=>temp.RawMaterialName).ToList();
            return ab;
        }
    }
}

