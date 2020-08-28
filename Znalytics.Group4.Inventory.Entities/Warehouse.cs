// Created by Nitya

//Importing Statements
using System;
using Znalytics.Group4.Inventory.Entities;

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
                if (!string.IsNullOrEmpty(value))
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!spaceFound && !atFound && !commaFound && value.StartsWith("WHID") && value.Length <= 6)
                    {
                        _warehouseId = value;
                    }
                }

                else
                {
                    throw new WareHouseException("Enter valid warehouseidshould not contain spaces and length be exactly 6");
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
                if (!string.IsNullOrEmpty(value))
                {
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");

                    if (!atFound && !commaFound && value.Length <= 30)
                    {
                        _warehouseName = value;
                    }

                }

                else
                {
                    throw new WareHouseException("invalid warehouse name,should not contain spaces and length should not exceed by 30");
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

                if (!string.IsNullOrEmpty(value))
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.Length <= 30)
                    {
                        _managerName = value;
                    }
                }


                else
                {
                    throw new WareHouseException("Manager name is invalid,should not contain spaces and length should not exceed by 30");
                }


            }
            get
            {
                return _managerName;
            }
        }





    }
}

    



