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
    /// RawMaterialDataAccessLayer
    /// </summary>
    public class RawMaterialDataAccessLayer
    {
        //creating list
        private static List<RawMaterial> _rawMaterials;
        //static constructor
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
        //Add RawMaterial to the List
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rawMaterial"></param>
        public void AddRawMaterial(RawMaterial rawMaterial)
        {

            _rawMaterials.Add(rawMaterial);//Addess RawMaterial details to List
            ListOfRawMaterials();
        }
        //Delete RawMaterial from the List
        public void DeleteRawMaterial(RawMaterial rawMaterial)
        {
            _rawMaterials.RemoveAll(temp => temp.RawMaterialID == rawMaterial.RawMaterialID && temp.RawMaterialName == rawMaterial.RawMaterialName);
            ListOfRawMaterials();
        }
        //Return the List of RawMaterial Details
        public List<RawMaterial> GetRawMaterial()
        {
            return _rawMaterials;
        }
        //Update the RawMaterial Price Based on RawMaterialName and RawMaterialID
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
        //Update the RawMaterial Quantity Based on RawMaterialName and RawMaterialID
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
        //Return the Corresponding RawMaterial Details based on RawMaterialID
        public RawMaterial GetRawMaterialByRawMaterialID(string RawMaterialID)
        {

            RawMaterial asd = _rawMaterials.Find(temp => temp.RawMaterialID == RawMaterialID);

            return asd;
        }
        public RawMaterial GetRawMaterialNameByRawMaterialID(string RawMaterialID)
        {

            RawMaterial asd = _rawMaterials.Find(temp => temp.RawMaterialID == RawMaterialID);
            //if (asd != null)
            //{
                return asd.RawMaterialName;
            //}
        }
        //used to Write data into the file
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
