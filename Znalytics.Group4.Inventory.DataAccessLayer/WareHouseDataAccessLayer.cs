// Created By Nitya

//Importing statements

using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Group4.Inventory.Entities;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Znalytics.Inventory.AddressModule.DataAccessLayer;


/// <summary>
///Created a namespace for DataAccess Layer of WareHouse Module
/// </summary>
namespace Znalytics.Inventory.WareHouseModule.DataAccessLayer
{
    /// <summary>
    /// Represents the static class for WareHouse Data 
    /// </summary>
    public static class WareHouseDataAccessLayer//Can be accessed with ClassName only
    {
        /// <summary>
        /// Created a list for WareHouse. It is made static so that it doesn't override the previous data
        /// </summary>
        private static List<WareHouse> _wareHouseList
        {
            set;
            get;
        }

        /// <summary>
        /// Static  Constructor. It is executed when the class is accessed for the first time
        /// </summary>
        static WareHouseDataAccessLayer()
        {
            //The object of List class is stored in the reference variable
            _wareHouseList = new List<WareHouse>()
            {
                //MOCK DATA
                new WareHouse(){WareHouseId="WHID01",WareHouseName="A",MangerName="NITYA"},
                new WareHouse(){WareHouseId="WHID02",WareHouseName="AB",MangerName="HEMA"},
                new WareHouse(){WareHouseId="WHID03",WareHouseName="ABC",MangerName="DHANASRI"},
                new WareHouse(){WareHouseId="WHID04",WareHouseName="ABCD",MangerName="KRUSHAL"},
                new WareHouse(){WareHouseId="WHID05",WareHouseName="ABCDE",MangerName="RAMYA"},
            };

            //If WarehouseList is empty, then it returns the data present in the file
            if (_wareHouseList.Count == 0)
            {
                _wareHouseList = GetFiledata();
            }
        }

        /// <summary>
        ///Method to ADD WareHouse details to the list
        /// </summary>
        /// <param name="warehouseDetails">Represents warehouse object</param>
        public static void AddWareHouse(WareHouse warehouseDetails)
        {
            //Condition to check whether the WareHouseId exists or not
            if (warehouseDetails.WareHouseId != null)
            {
                _wareHouseList.Add(warehouseDetails);
                SaveIntoFile();
            }
            else
            {
                throw new WareHouseException("Warehouse already exists");
            }


        }

        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        private static void SaveIntoFile()
        {
            //Serialization converts an object into Json Format/String
            //Serialize object is stored in a reference variable of a string
            string s = JsonConvert.SerializeObject(_wareHouseList);

            //Strean Writer writes data into file.
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\WareHouse.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }

        /// <summary>
        /// reading the data from Json file and return the data in the file in List format
        /// </summary>
        /// <returns>Returns List of warehouses avaliable int WareHouseData.Txt</returns>
        public static List<WareHouse> GetFiledata()
        {
            //Stream Reader reads the data from the given file
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\WareHouse.txt");
            string s1 = streamReader.ReadToEnd();
            //Deserialization converts Json data/string to Object
            List<WareHouse> ware = JsonConvert.DeserializeObject<List<WareHouse>>(s1);
            streamReader.Close();
            return ware;

        }

        /// <summary>
        ///  Method to GET the added details
        /// </summary>
        /// <returns>It returns the list of WareHouses</returns>
        public static List<WareHouse> GetWareHouses() => _wareHouseList;//Used Linq
        

        /// <summary>
        /// Method to GET the WareHouse by WareHouseID
        /// </summary>
        /// <param name="wareHouseID">Reprents WareHouse id</param>
        /// <returns></returns>
        public static WareHouse GetWareHouseByWareHouseID(string wareHouseID)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_wareHouseList.Exists(n => n.WareHouseId == wareHouseID))
            {
                //Linq returns an object of conditional data 
                return _wareHouseList.Find(temp => temp.WareHouseId == wareHouseID);
            }
            else
            {
                throw new WareHouseException("WareHouse doesn't exist");
            }
        }

        /// <summary>
        /// Method to REMOVE WareHouse by WareHouseID
        /// </summary>
        /// <param name="wareHouseID">Reprents WareHouse id</param>
        public static void RemoveWareHouseByID(string wareHouseID)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_wareHouseList.Exists(n => n.WareHouseId == wareHouseID))
            {
                //It removes all the condition matching elements
                _wareHouseList.RemoveAll(n => n.WareHouseId == wareHouseID);

                //Created an object and is stored in a reference variable
                WareHouseAddressDataAccessLayer wa = new WareHouseAddressDataAccessLayer();

                //When a WareHouse is deleted, the corresponding addresses are also removed
                wa.RemoveAddressByWareHouseID(wareHouseID);
                SaveIntoFile();
            }
            else
            {
                throw new WareHouseException("Warehouse doesn't exist");
            }

        }

        /// <summary>
        /// Method to REMOVE WareHouse by WareHouse Name
        /// </summary>
        /// <param name="wareHouseName">Represents WareHouse Name</param>
        public static void RemoveWareHouseByName(string wareHouseName)
        {
            //Condition to check whether the WareHouseName exists or not
            if (_wareHouseList.Exists(n => n.WareHouseName == wareHouseName))
            {
                //It removes all the condition matching elements
                _wareHouseList.RemoveAll(n => n.WareHouseName == wareHouseName);
                SaveIntoFile();
            }
            else
            {
                throw new WareHouseException("Warehouse doesn't exists by this name");
            }
        }

        /// <summary>
        /// Method to UPDATE the WareHouse Name
        /// </summary>
        /// <param name="wareHouse">Represents the WareHouse object</param>
        public static void UpdateWareHouseName(WareHouse wareHouse)
        {
            //Condition to check whether the WareHouseId exists or not
           if (_wareHouseList.Exists(n => n.WareHouseId == wareHouse.WareHouseId))
            {
                //Finds the matching element.The returned bool value is stored in a reference variable
                WareHouse w = _wareHouseList.Find(n => n.WareHouseId == wareHouse.WareHouseId);
                if (w != null)
                {
                    w.WareHouseName = wareHouse.WareHouseName;
                    SaveIntoFile();
                }
            }
            else
            {
                throw new WareHouseException("Warehouse doesn't exist");
            }
        }

        /// <summary>
        /// Method to UPDATE the Manager Name
        /// </summary>
        /// <param name="wareHouse">Represents of WareHouse object</param>
        public static void UpdateManagerName(WareHouse wareHouse)
        {
            //Condition to check whether the WareHouseId exists or not
           if (_wareHouseList.Exists(temp => temp.WareHouseId == wareHouse.WareHouseId))
            {
                //Finds the matching element.The returned bool value is stored in a reference variable
                WareHouse w = _wareHouseList.Find(n => n.WareHouseId == wareHouse.WareHouseId);
                if (w != null)
                {
                    w.MangerName = wareHouse.MangerName;
                    SaveIntoFile();
                }
           }
            else
            {
                throw new WareHouseException("Warehouse doesn't exist");
            }
        }

        /// <summary>
        /// Method to check whether WareHouseId exists or not
        /// </summary>
        /// <param name="id">Represents warehouse id</param>
        /// <returns></returns>
        public static bool CheckWareHouseId(string id)
        {
            //Condition to check whether the WareHouseId exists or not
            bool result = _wareHouseList.Exists(temp => temp.WareHouseId == id);
            return result;
        }
    }
}
