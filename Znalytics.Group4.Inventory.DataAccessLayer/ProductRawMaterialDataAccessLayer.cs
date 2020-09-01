//Created By Hema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities;
using Newtonsoft.Json;
using System.IO;

namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.DataAccessLayer
{
    /// <summary>
    /// ProductRawMaterialDataAccessLayer used to details in list
    /// </summary>
    public class ProductRawMaterialDataAccessLayer
    {

        /// <summary>
        /// creating list for ProductRawMaterial Details
        /// </summary>
        private static List<ProductRawMaterial> _productRawMaterials;

        /// <summary>
        /// static constructor used to creating object for the list and add details to the list
        /// </summary>
        static ProductRawMaterialDataAccessLayer()

        {
            _productRawMaterials = new List<ProductRawMaterial>();//creating object for list 

             _productRawMaterials = LoadDetailsToList();
        }

        /// <summary>
        /// AddRawMaterialToProduct is a instance Method used to Add RawMaterial of product to the List
        /// </summary>
        /// <param name="ProductRawMaterial">Contain the all the Details of the feild present in ProductRawMaterial Class</param>
        public void AddRawMaterialToProduct(ProductRawMaterial productRawMaterial)
        {

            _productRawMaterials.Add(productRawMaterial);//Addess ProductRawMaterial details to List
            ListOfRawMaterials();
        }

        /// <summary>
        /// DeleteRawMaterialProduct is a instance Method used to Delete RawMaterial of the Product from the List
        /// </summary>
        /// <param name="productRawMaterial">Contain the all the Details of the feild present in ProductRawMaterial Class</param>
        public void DeleteRawMaterialOfProduct(ProductRawMaterial productRawMaterial)
        {
            _productRawMaterials.RemoveAll(temp => temp.ProductID == productRawMaterial.ProductID && temp.RawMaterialID == productRawMaterial.RawMaterialID);
             ListOfRawMaterials();
        }

        /// <summary>
        /// Return the List of ProductRawMaterial Details
        /// </summary>
        /// <returns>Returns the list</returns>
        public List<ProductRawMaterial> GetProductRawMaterial()
        {
            return _productRawMaterials;
        }
        /// <summary>
        /// GetProductRawMaterialByID is a instance method used to check weather the below condition satisfies or not
        /// </summary>
        /// <param name="ProductID">represents ID of the product</param>
        /// <param name="RawMaterialID">represents ID of the RawMaterial</param>
        /// <returns>Returns the details</returns>
       public ProductRawMaterial GetProductRawMaterialByID(string ProductID,string RawMaterialID)
       {
          ProductRawMaterial abc = _productRawMaterials.Find(temp => temp.ProductID == ProductID && temp.RawMaterialID==RawMaterialID);
              if (abc != null)
              {
                 return abc;
              }
              else
              {
                return null;
              }
           

       }

        /// <summary>
        /// UpdateQuantityOfProduct is a instane method used to Update the Quantity Based on ProductID and RawMaterialID
        /// </summary>
        /// <param name="productRawMaterial">Contain the all the Details of the feild present in ProductRawMaterial Class</param>
        public void UpdateQuantityOfProduct(ProductRawMaterial productRawMaterial)
        {
            ProductRawMaterial abc = _productRawMaterials.Find(temp => temp.ProductID == productRawMaterial.ProductID && temp.RawMaterialID == productRawMaterial.RawMaterialID);

            abc.Quantity = productRawMaterial.Quantity;
             ListOfRawMaterials();
        }
        /// <summary>
        /// GetDetailsByProductID is a instance method used to Return the List if ProductID matches
        /// </summary>
        /// <param name="productRawMaterial">Contain the all the Details of the feild present in ProductRawMaterial Class</param>
        /// <returns>Return the list</returns>
        public List<ProductRawMaterial> GetDetailsByProductID(ProductRawMaterial productRawMaterial)
        {
            List<ProductRawMaterial> ab= _productRawMaterials.Where(temp => temp.ProductID == productRawMaterial.ProductID).ToList();
            return ab;
        }
        /// <summary>
        /// GetDetailsUsingOrderBy is a instance method used to arrange the in assending order 1st preference to ProductID,2nd RawMaterialID and then RawMaterialName
        /// </summary>
        /// <returns>Return the in List assending order</returns>
        public List<ProductRawMaterial> GetDetailsUsingOrderBy()
        {
            List<ProductRawMaterial> ab = _productRawMaterials.OrderBy(temp => temp.ProductID)
                .ThenBy(temp=> temp.RawMaterialID)
                .ThenBy(temp=>temp.RawMaterialName).ToList();
            return ab;
        }
        /// <summary>
        /// checks weather entered details contains or not in the List
        /// </summary>
        /// <param name="productRawMaterial">Contain the all the Details of the feild present in ProductRawMaterial Class</param>
        /// <returns>Returns the details based on ProductID and RwMaterialID</returns>
        public ProductRawMaterial GetDetailsByProductIDAndRawMaterialID(ProductRawMaterial productRawMaterial)
        {
            ProductRawMaterial ab = _productRawMaterials.Find(temp => temp.ProductID == productRawMaterial.ProductID && temp.RawMaterialID == productRawMaterial.RawMaterialID);
          
                if (ab != null)
                {
                    return ab;
                }
                else
                {
                    return null;
                }

        }
        /// <summary>
        /// serialization
        /// </summary>
        public void ListOfRawMaterials()
        {
            string s = JsonConvert.SerializeObject(_productRawMaterials);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\ProductRawMaterial\ProductRawMaterials.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        /// <summary>
        /// Deserialization
        /// </summary>
        /// <returns>returns the list</returns>
        public static List<ProductRawMaterial> LoadDetailsToList()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\ProductRawMaterial\ProductRawMaterials.txt");
            string s2 = streamReader.ReadToEnd();
            List<ProductRawMaterial> productRawMaterials = JsonConvert.DeserializeObject<List<ProductRawMaterial>>(s2);
            streamReader.Close();

            if (productRawMaterials == null)
            {
                return new List<ProductRawMaterial>();
            }
            else
            {
                return productRawMaterials;

            }

        }
    }
}

