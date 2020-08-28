// Created by Nitya

//Importing Statements
using System;

//Created a namespace for Entity Layer of WareHouse Module
namespace Znalytics.Inventory.WareHouseModule.Entities
{

    /// <summary>
    /// Represents Inventory Warehouse 
    /// </summary>
    public class WareHouse
    {
        //Private Fields
        private string _warehouseId;
        private string _warehouseName;
        private string _managerName;
        //private int _warehouseCapacity;
        

        /// <summary>
        /// Default constructor 
        /// </summary>
        public WareHouse()
        {


        }
       /// <summary>
       /// Parameterized constructor
       /// </summary>
       /// <param name="name">Represents Name of the Manager</param>
       /// <param name="wareId">Represents id of the WareHouse</param>
       /// <param name="warName">Represents Name of the WareHouse</param>
        public WareHouse(string name, string wareId, string warName)
        {
            this._managerName = name;
            this._warehouseId = wareId;
            this._warehouseName = warName;
            
        }

        /// <summary>
        /// Property for WarehouseId
        /// </summary>
        public string WareHouseId
        {
            set
            {
                try
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!spaceFound && !atFound && !commaFound && value.StartsWith("WHID") && value.Length <= 6)
                    {
                        _warehouseId = value;
                    }
                }
                catch
                {
                    throw new Exception("Enter valid warehouseid");
                }
            }
            get
            {
                return _warehouseId;

            }
        }
        /// <summary>
        /// Property for WareHouseName
        /// </summary>
        public string WareHouseName
        {
             set
            {
                try
                {
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if ( !atFound && !commaFound && value.Length <= 30)
                    {
                        _warehouseName = value;
                    }

                }
                catch(Exception ex)
                {
                    throw new Exception("invalid warehouse name");
                }
            }
            get
            {
                return _warehouseName;
            }
        }

        /// <summary>
        /// Property for ManagerName
        /// </summary>
        public string MangerName
        {
            set
            {
                try
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.Length <= 30)
                    {
                        _managerName = value;
                    }

                }
                catch
                {
                    throw new Exception("Manager name is invalid");
                }
            }
            get
            {

                return _managerName;
            }
            }
        }





    }

    



