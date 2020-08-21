//Created By Nitya

namespace Znalytics.Inventory.WareHouseModule.Entities
{
    /// <summary>
    /// Represents Address of the WareHouse
    /// </summary>
    class Address
    {
        private string _locationId;
        private string _doorNumber;
        private string _locationName;
        private string _state;
        private string _pincode;

        /// <summary>
        /// Default constructor
        /// </summary>
        Address()
        {

        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="locId"></param>
        /// <param name="doorNo"></param>
        /// <param name="locName"></param>
        /// <param name="state"></param>
        /// <param name="pincode"></param>
        Address(string locId, string doorNo, string locName, string state, string pincode)
        {
            this._locationId = locId;
            this._doorNumber = doorNo;
            this._locationName = locName;
            this._state = state;
            this._pincode = pincode;
        }

        /// <summary>
        /// Property for LocationId
        /// </summary>
        public string LocationId
        {
            set
            {
                if (value.Length <= 2)
                {
                    _locationId = value;
                }
            }

            get
            {
                return _locationId;
            }
        }
        /// <summary>
        /// Property for DoorId
        /// </summary>
        public string DoorNumber
        {
            set
            {
                if (value.Length <= 30)
                {
                    _doorNumber = value;
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
        /// Property for State Name
        /// </summary>
        public string State
        {
            set
            {
                if (value.Length <= 30)
                {
                    _state = value;
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
    }
}