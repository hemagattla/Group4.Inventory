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
        private static List<ProductRawMaterials> _productRawMaterialss;

        /// <summary>
        /// static constructor used to creating object for the list and add details to the list
        /// </summary>
        static ProductRawMaterialDataAccessLayer()

        {

            _productRawMaterialss = new List<ProductRawMaterials>();//creating object for list 

           // _productRawMaterialss = GetFiledata();



        }

        /// <summary>
        /// AddRawMaterial is a static Method used to Add RawMaterial to the List
        /// </summary>
        /// <param name="rawMaterial">Represents the Reference variable of RawMarial class</param>
        public void AddRawMaterial(ProductRawMaterials productRawMaterial)
        {

            _productRawMaterialss.Add(productRawMaterial);//Addess RawMaterial details to List
            //ListOfRawMaterials();
        }

        /// <summary>
        /// DeleteRawMaterial is a instance Method used to Delete RawMaterial from the List
        /// </summary>
        /// <param name="rawMaterial">is a variable of RawMaterial type</param>
        public void DeleteRawMaterial(ProductRawMaterials productRawMaterial)
        {
            _productRawMaterialss.RemoveAll(temp => temp.ProductID == productRawMaterial.ProductID && temp.RawMaterialID == productRawMaterial.RawMaterialID && temp.RawMaterialName == productRawMaterial.RawMaterialName);
           // ListOfRawMaterials();
        }

        /// <summary>
        /// Return the List of RawMaterial Details
        /// </summary>
        /// <returns>Returns the list</returns>
        public List<ProductRawMaterials> GetRawMaterial()
        {
            return _productRawMaterialss;
        }

        /// <summary>
        /// UpdateRawMaterialPrice is a instane method used to Update the RawMaterial Price Based on RawMaterialName and RawMaterialID
        /// </summary>
        /// <param name="rawMaterial">is a variable of RawMaterial type</param>
        public void UpdateRawMaterialPrice(ProductRawMaterials productRawMaterial)
        {
            ProductRawMaterials abc = _productRawMaterialss.Find(temp => temp.RawMaterialID == productRawMaterial.RawMaterialID && temp.RawMaterialName == productRawMaterial.RawMaterialName);
           
       
                    abc.Quantity = productRawMaterial.Quantity;
                   // ListOfRawMaterials();
        }

        /// <summary>
        /// UpdateRawMaterialQuantity is a instance method used to Update the RawMaterial Quantity Based on RawMaterialName and RawMaterialID
        /// </summary>
        /// <param name="rawMaterial">is a variable of RawMaterial type</param>
        public void UpdateRawMaterialQuantity(ProductRawMaterials productRawMaterial)
        {
            ProductRawMaterials ab = _productRawMaterialss.Find(temp => temp.RawMaterialID == productRawMaterial.RawMaterialID && temp.RawMaterialName == productRawMaterial.RawMaterialName);

            try
            {
                if (ab != null)
                {
                    ab.Quantity = productRawMaterial.Quantity;
                   // ListOfRawMaterials();
                }
                else
                {
                    throw new Exception("entered RawMaterialName is invalid");
                }
            }
            catch
            {
                throw;
            }


        }

        /// <summary>
        /// GetRawMaterialByRawMaterialID is a instance method used to Return the Corresponding RawMaterial Details based on RawMaterialID
        /// </summary>
        /// <param name="RawMaterialID">Represents the ID of RawMaterial</param>
        /// <returns>Returns the list of RawMaterial details</returns>
       /* public RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID)
        {

            RawMaterial asd = _rawMaterials.Find(temp => temp.RawMaterialID == RawMaterialID);

            return asd;
        }
        public string GetRawMaterialNameByRawMaterialID(string RawMaterialID)
        {

            RawMaterial asd = _rawMaterials.Find(temp => temp.RawMaterialID == RawMaterialID);

            return asd.RawMaterialName;

        }*/

        /// <summary>
        /// ListOfRawMaterials is a instance method used to used to Write data into the file
        /// </summary>
       /* public void ListOfRawMaterials()
        {
            string s = JsonConvert.SerializeObject(_rawMaterials);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\RawMaterial\RawMaterials.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        public static List<RawMaterial> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\RawMaterial\RawMaterials.txt");
            string s2 = streamReader.ReadToEnd();
            List<RawMaterial> customers2 = JsonConvert.DeserializeObject<List<RawMaterial>>(s2);
            streamReader.Close();
            return customers2;

        }*/
    }
}

    

