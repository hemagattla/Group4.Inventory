// Created by Nitya

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
        // private string _wareHouseName;
        private int _warehouseCapacity;
        //private string _locationName;
        // private string _pincode;
        //private string _warehouseStatus;




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
        public WareHouse(string name, string wareId, int wareCapacity)
        {
            this._managerName = name;
            this._warehouseId = wareId;
            //this._locationName = locName;
            //this._pincode = pincode;
            this._warehouseCapacity = wareCapacity;
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
        /// Property for WarehouseCapacity
        /// </summary>
        public int WarehouseCapacity
        {
            set
            {
                _warehouseCapacity = value;
            }
            get
            {
                return _warehouseCapacity;

            }
        }
        /// <summary>
        /// Property for Warehouse Status
        /// </summary>
        public string WarehouseStatus
        {
            get
            {
                if (WarehouseCapacity <= 0)
                {
                    return "Empty";
                }
                else
                {
                    return "Not Empty";
                }
            }

        }
    }
}



