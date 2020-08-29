// Created By Nitya

//Importing statements

using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Group4.Inventory.Entities;
using Newtonsoft.Json;
using System.IO;


//Created a namespace for DataAccess Layer of WareHouse Module
namespace Znalytics.Inventory.WareHouseModule.DataAccessLayer
{
    /// <summary>
    /// Represents the class for WareHouse Data
    /// </summary>
    public static class WareHouseDataAccessLayer
    {
        //Created a list for WareHouse
        private static List<WareHouse> _wareHouseList
        {
            set;
            get;
        }

        //Static  Constructor 
        static WareHouseDataAccessLayer()
        {
            _wareHouseList = new List<WareHouse>();

            if (_wareHouseList.Count == 0)
            {
                _wareHouseList = GetFiledata();
            }
        }

        //Method to ADD WareHouse details to the list
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

            string s = JsonConvert.SerializeObject(_wareHouseList);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\WareHouseData.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }

        /// <summary>
        /// reading the data from Json file and return the data in the file in List format
        /// </summary>
        /// <returns>return List of warehouses avaliable int WareHouse.Txt</returns>
        public static List<WareHouse> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\WareHouseData.txt");
            string s1 = streamReader.ReadToEnd();
            List<WareHouse> ware = JsonConvert.DeserializeObject<List<WareHouse>>(s1);
            streamReader.Close();
            return ware;

        }

        // Method to GET the added details
        public static List<WareHouse> GetWareHouses()
        {
            return _wareHouseList;
        }

        //Method to GET the WareHouse by WareHouseID
        public static WareHouse GetWareHouseByWareHouseID(string wareHouseID)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_wareHouseList.Exists(n => n.WareHouseId == wareHouseID))
            {
                return _wareHouseList.Find(temp => temp.WareHouseId == wareHouseID);
            }
            else
            {
                throw new WareHouseException("WareHouse doesn't exist");
            }
        }

        //Method to REMOVE WareHouse by WareHouseID
        public static void RemoveWareHouseByID(string wareHouseID)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_wareHouseList.Exists(n => n.WareHouseId == wareHouseID))
            {
                _wareHouseList.RemoveAll(n => n.WareHouseId == wareHouseID);
                SaveIntoFile();
            }
            else
            {
                throw new WareHouseException("Warehouse doesn't exist");
            }

        }

        //Method to REMOVE WareHouse by WareHouse Name
        public static void RemoveWareHouseByName(string wareHouseName)
        {
            //Condition to check whether the WareHouseName exists or not
            if (_wareHouseList.Exists(n => n.WareHouseName == wareHouseName))
            {
                _wareHouseList.RemoveAll(n => n.WareHouseName == wareHouseName);
                SaveIntoFile();
            }
            else
            {
                throw new WareHouseException("Warehouse doesn't exists by this name");
            }
        }

        // Method to UPDATE the WareHouse Name
        public static void UpdateWareHouseName(WareHouse wareHouse)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_wareHouseList.Exists(n => n.WareHouseId == wareHouse.WareHouseId))
            {
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

        // Method to UPDATE the Manager Name
        public static void UpdateManagerName(WareHouse wareHouse)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_wareHouseList.Exists(temp => temp.WareHouseId == wareHouse.WareHouseId))
            {
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
            bool result = _wareHouseList.Exists(temp => temp.WareHouseId == id);
            return result;
        }
    }
}
