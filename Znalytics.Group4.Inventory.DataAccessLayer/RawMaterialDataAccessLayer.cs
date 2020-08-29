using System;
using System.Collections.Generic;
using System.Linq;
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;
using Znalytics.Group4.Inventory.RawMaterialModule.EntityLayer;
using Newtonsoft.Json;
using System.IO;
namespace Znalytics.Group4.Inventory.RawMaterialModule.DataAccessLayer
{
    /// <summary>
    /// RawMaterialDataAccessLayer is a Public used to maintain the list
    /// </summary>
    public class RawMaterialDataAccessLayer
    {

        /// <summary>
        /// creating list for RawMaterial Details
        /// </summary>
        private static List<RawMaterial> _rawMaterials;

        /// <summary>
        /// static constructor used to creating object for the list and add details to the list
        /// </summary>
        static RawMaterialDataAccessLayer()
           
        {
            /*StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\RawMaterial\RawMaterials.txt");
            string s2 = streamReader.ReadToEnd();
            List<RawMaterial> customers2 = JsonConvert.DeserializeObject<List<RawMaterial>>(s2);*/
            _rawMaterials = new List<RawMaterial>()//creating object for list 
            {
                new RawMaterial{RawMaterialID="RMID12", RawMaterialName="MILK",Quantity=3,Units="kgs",Price=23}
            };
            /*StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\RawMaterial\RawMaterials.txt");
            string s2 = streamReader.ReadToEnd();
            List<RawMaterial> customers2 = JsonConvert.DeserializeObject<List<RawMaterial>>(s2);*/


        }

        /// <summary>
        /// AddRawMaterial is a static Method used to Add RawMaterial to the List
        /// </summary>
        /// <param name="rawMaterial">Represents the Reference variable of RawMarial class</param>
        public void AddRawMaterial(RawMaterial rawMaterial)
        {

            _rawMaterials.Add(rawMaterial);//Addess RawMaterial details to List
            ListOfRawMaterials();
        }

        /// <summary>
        /// DeleteRawMaterial is a instance Method used to Delete RawMaterial from the List
        /// </summary>
        /// <param name="rawMaterial">is a variable of RawMaterial type</param>
        public void DeleteRawMaterial(RawMaterial rawMaterial)
        {
            _rawMaterials.RemoveAll(temp => temp.RawMaterialID == rawMaterial.RawMaterialID && temp.RawMaterialName == rawMaterial.RawMaterialName);
            ListOfRawMaterials();
        }
        
        /// <summary>
        /// Return the List of RawMaterial Details
        /// </summary>
        /// <returns>Returns the list</returns>
        public List<RawMaterial> GetRawMaterial()
        {
            return _rawMaterials;
        }

        /// <summary>
        /// UpdateRawMaterialPrice is a instane method used to Update the RawMaterial Price Based on RawMaterialName and RawMaterialID
        /// </summary>
        /// <param name="rawMaterial">is a variable of RawMaterial type</param>
        public void UpdateRawMaterialPrice(RawMaterial rawMaterial)
        {
            RawMaterial abc = _rawMaterials.Find(temp => temp.RawMaterialID == rawMaterial.RawMaterialID && temp.RawMaterialName == rawMaterial.RawMaterialName);
            try
            {
                if (abc != null)
                {
                    abc.Price = rawMaterial.Price;
                    ListOfRawMaterials();
                }
                else
                {
                    throw new RawMaterialException("entered RawMaterialName is invalid");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// UpdateRawMaterialQuantity is a instance method used to Update the RawMaterial Quantity Based on RawMaterialName and RawMaterialID
        /// </summary>
        /// <param name="rawMaterial">is a variable of RawMaterial type</param>
        public void UpdateRawMaterialQuantity(RawMaterial rawMaterial)
        {
            RawMaterial ab = _rawMaterials.Find(temp => temp.RawMaterialID == rawMaterial.RawMaterialID && temp.RawMaterialName == rawMaterial.RawMaterialName);

            try
            {
                if (ab != null)
                {
                    ab.Quantity = rawMaterial.Quantity;
                    ListOfRawMaterials();
                }
                else
                {
                    throw new RawMaterialException("entered RawMaterialName is invalid");
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
        public RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID)
        {

            RawMaterial asd = _rawMaterials.Find(temp => temp.RawMaterialID == RawMaterialID);

            return asd;
        }
         public RawMaterial GetRawMaterialNameByRawMaterialID(string RawMaterialID)
         {

             RawMaterial asd = _rawMaterials.Find(temp => temp.RawMaterialID == RawMaterialID);
             if (asd != null)
             {
                 return asd;
             }
            return null;
         }

        /// <summary>
        /// ListOfRawMaterials is a instance method used to used to Write data into the file
        /// </summary>
        public void ListOfRawMaterials()
        {
            string s = JsonConvert.SerializeObject(_rawMaterials);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\RawMaterial\RawMaterials.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
    }
}
