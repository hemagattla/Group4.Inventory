using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Inventory.Group4.WareHouse.Entities
{
    
        //Created by Nitya
        /// <summary>
        /// Represents Inventory Warehouse
        /// </summary>
        public class WareHouse
        {
            //Private Fields
            private string _managerName;
            private string _warehouseId;
            // private string _locationId;
            private string _locationName;
            private string _pincode;
            private int _warehouseCapacity;
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
            public WareHouse(string name, string wareId, string locName, string pincode, int wareCapacity)
            {
                this._managerName = name;
                this._warehouseId = wareId;
                // this._locationId = locId;
                this._locationName = locName;
                this._pincode = pincode;
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
            /// Property for LocationId
            /// </summary>
            /* public string LocationId
             {
                 set
                 {
                     if (value.Length == 2)
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
                             _locationId = value;
                         }
                     }
                 }
                 get
                 {
                     return _locationId;
                 }
             }*/

            /// <summary>
            /// Property for Location Name
            /// </summary>
            public string LocationName
            {
                set
                {
                    if (value.Length <= 30)
                    {
                        _locationName = value;
                    }
                }
                get
                {
                    return _locationName;
                }
            }

            /// <summary>
            /// Property for Pincode
            /// </summary>
            public string Pincode
            {
                set
                {
                    if (value.Length == 6)
                    {
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (value[i] < '0' || value[i] > 9)
                            {
                                _pincode = value;
                            }
                        }
                    }
                }
                get
                {
                    return _pincode;
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





        /*
            public void Add()
            {

            }
            public void Display()
            {

            }
            public void Update()
            {
            }
            public void Delete()
            {
            }
            public void Exit()
            {
            }
        }
        */
    }

