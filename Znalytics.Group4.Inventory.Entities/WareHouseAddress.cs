//Created By Nitya

//Importing Statements
using System;
using System.Text.RegularExpressions;
using Znalytics.Group4.Inventory.Entities;

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
                //Regular Expression for AlphaNumeric values
                Regex r = new Regex("[A-Z0-9]$");
                //AddressId should not be null or empty
                if (!string.IsNullOrEmpty(value)&&value.StartsWith("W")&&value.Length==4&&r.IsMatch(value) )
                {
                    
                        _addressId = value;
                    
                }
                else
                {
                    throw new WareHouseException("Invalid addressid. It should not contain spaces or Special Characters and length should be exactly 4");
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
                //Door number should not be null or empty
                if (!string.IsNullOrEmpty(value)&&value.Length<=30)
                {
                    
                        _doorNumber = value;
                    
                }
                else
                {
                    throw new WareHouseException("Door Number shouldn't be null or empty");
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
                //Regular Expression for Alphabets(Capital&small letters)
                Regex r = new Regex("[a-zA-Z_]+$");
                //LocationName should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
                {
                    
                        _locationName = value;
                    
                }

                else
                {
                    throw new WareHouseException("Location Name shouldn't be null and shouldn't contain special characters");
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
                //Regular Expression for Alphabets(Capital&small letters)
                Regex r = new Regex("[a-zA-Z_]+$");
                //State should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
                {
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.Length <= 30)
                    {
                        _state = value;
                    }
                }
                else
                {
                    throw new WareHouseException("State shouldn't be null and shouldn't contain special characters");
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
                //Regular Expression for numeric values
                Regex r = new Regex("[0-9]+$");
                //Pincode should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length == 6)    
                {
                    _pincode = value;
                }
                else
                {
                    throw new WareHouseException("Pincode should contain exactly 6 digits");
                }
            }
            get
            {
                return _pincode;
            }
        }
    }
}