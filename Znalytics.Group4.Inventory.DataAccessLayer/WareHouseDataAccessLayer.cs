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
            _wareHouseList = new List<WareHouse>()
            {
                new WareHouse(){WareHouseId="WHID01",WareHouseName="ABC",MangerName="NITYA"},
                new WareHouse(){WareHouseId="WHID02",WareHouseName="ABCD",MangerName="HEMA"},
                new WareHouse(){WareHouseId="WHID03",WareHouseName="ABCDE",MangerName="DHANASRI"},
                new WareHouse(){WareHouseId="WHID04",WareHouseName="ABCDEF",MangerName="KRUSHAL"}

            };
        }

        //Method to ADD WareHouse details to the list
        public static void AddWareHouse(WareHouse warehouseDetails)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_wareHouseList.Exists(temp => temp.WareHouseId == warehouseDetails.WareHouseId))
            {
                _wareHouseList.Add(warehouseDetails);
                SaveIntoFile();
            }
            else
            {
                throw new WareHouseException("Warehouse already exists");
            }


        }

        private static void SaveIntoFile()
        {

            string s = JsonConvert.SerializeObject(_wareHouseList);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\WareHouseData.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }

        public static List<WareHouse> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\WareHouseJson.txt");
            string s1 = streamReader.ReadToEnd();
            List<WareHouse> ware = JsonConvert.DeserializeObject<List<WareHouse>>(s1);
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
    }
}
