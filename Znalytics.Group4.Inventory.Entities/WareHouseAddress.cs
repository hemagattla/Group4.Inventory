//Created By Nitya

//Importing Statements
using System;

//Created a namespace for Entity Layer of WareHouseAddress Module
namespace Znalytics.Inventory.AddressModule.Entities
{
    /// <summary>
    /// Represents Address of the WareHouse
    /// </summary>
   public class WareHouseAddress
    {

        /// <summary>
        /// Private fields
        /// </summary>
        private string _addressId;
        private string _doorNumber;
        private string _locationName;
        private string _state;
        private string _pincode;

        //WareHouseId Property
        public string WareHouseId;

        /// <summary>
        /// Default constructor
        /// </summary>
        public WareHouseAddress()
        {

        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="addId">Represents the id of the address/location</param>
        /// <param name="doorNo">Represnts the Door Number of the WareHouse</param>
        /// <param name="locName">Represents the Name of the Location</param>
        /// <param name="state">Represents the Name of the State</param>
        /// <param name="pincode">Represents the Pincode of the Location</param>
       public  WareHouseAddress(string addId, string doorNo, string locName, string state, string pincode)
        {
            this._addressId = addId;
            this._doorNumber = doorNo;
            this._locationName = locName;
            this._state = state;
            this._pincode = pincode;
        }

        /// <summary>
        /// Property for LocationId
        /// </summary>
        public string AddressId
        {
            set
            {
                try
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!spaceFound && !atFound && !commaFound && value.StartsWith("W") && value.Length <= 4)
                    {
                        _addressId = value;
                    }
                }
                catch
                {
                    throw new System.Exception("invalid addressid");
                }
            }

            get
            {
                return _addressId;
            }
        }
        /// <summary>
        /// Property for DoorId
        /// </summary>
        public string DoorNumber
        {
            set
            {
                try
                {
                    if (value.Length <= 30)
                    {
                        _doorNumber = value;
                    }
                }
                catch
                {
                    throw new Exception("invalid door number");
                }
            }

            get
            {
                return _doorNumber;
            }
        }

        /// <summary>
        /// Property for Location Name
        /// </summary>
        public string LocationName
        {
            set
            {
                try
                {

                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.Length <= 30)
                    {
                        _locationName = value;
                    }
                }
                catch
                {
                    throw new System.Exception("invalid location name");
                }
            }
                get
            {
                return _locationName;
            }
        }

        /// <summary>
        /// Property for State Name
        /// </summary>
        public string State
        {
            set
            {
                try
                {

                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.Length <= 30)
                    {
                        _addressId = value;
                    }
                }
                catch
                {
                    throw new Exception("invalid state");
                }
            }
            get
            {
                return _state;
            }
        }

        /// <summary>
        /// Property for Pincode
        /// </summary>
        public string Pincode
        {
            set
            {
                try
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
                catch
                {
                    throw new Exception("invalid pincode");
                }
            }
            get
            {
                return _pincode;
            }
        }
    }
}