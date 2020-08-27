// Created by Nitya

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
        /// <param name="name"></param>
        /// <param name="wareid"></param>
        /// <param name="locid"></param>
        /// <param name="locname"></param>
        /// <param name="pincode"></param>
        /// <param name="warecapacity"></param>
        public WareHouse(string name, string wareId, string warName)
        {
            this._managerName = name;
            this._warehouseId = wareId;
            this._warehouseName = warName;
            
        }

        /// <summary>
        /// Property for WarehouseId
        /// </summary>
        public string WarehouseId
        {
            set
            {
                bool isSpaceFound = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == ' ')
                    {
                        isSpaceFound = true;
                    }
                }
                if (isSpaceFound == false)
                {
                    _warehouseId = value;
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
                if (value.Length <= 30)
                {
                    _warehouseName = value;
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
                if (value.Length <= 30)
                {
                    _managerName = value;
                }
            }
            get
            {
                return _managerName;
            }
        }





    }
}
    



