//Created by Nitya

//Importing statements
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Group4.Inventory.DataAccessLayer;
using Znalytics.Inventory.AddressModule.Entities;
using System;

//Created a namespace for DataAccessLayer of WareHouseAddress Module
namespace Znalytics.Inventory.AddressModule.DataAccessLayer
{

    /// <summary>
    /// Represents the class for WareHouse Address
    /// </summary>
    public class WareHouseAddressDataAccessLayer//: IWareHouseAddressDataAccessLayer
    {
        //Created a list for WareHouse Addresses
        private static List<WareHouseAddress> _addressList
        {
            set;
            get;
        }

        //Static Constructor
        static WareHouseAddressDataAccessLayer()
        {
            _addressList = new List<WareHouseAddress>()
            {
                //Mock Data
                new WareHouseAddress(){WareHouseId="WHID01",AddressId="W1A1",DoorNumber="1-1-1",LocationName="WARANGAL",Pincode="505005"},
                new WareHouseAddress(){WareHouseId="WHID01",AddressId="W1A2",DoorNumber="1-2-2",LocationName="HYDERABAD",Pincode="506003"},
                new WareHouseAddress(){WareHouseId="WHID02",AddressId="W2A1",DoorNumber="2-1-1",LocationName="KARIMNAGAR",Pincode="506002"},
                new WareHouseAddress(){WareHouseId="WHID02",AddressId="W2A2",DoorNumber="2-2-2",LocationName="VIZA",Pincode="506009"},
            };

        }

        //Method to ADD address details to the list
        public void AddAddress(WareHouseAddress addressDetails)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_addressList.Exists(temp => temp.WareHouseId == addressDetails.WareHouseId))
            {
                _addressList.Add(addressDetails);
            }
            else
            {
                throw new Exception("Warehouse id doesnot exist");
            }
        }

        // Method to GET the added address details
        public List<WareHouseAddress> GetAddresses()
        {
            return _addressList;
        }

        //Method to GET the Address details by AddressID
        public WareHouseAddress GetAddressByAddressID(string addressID)
        {

            return _addressList.Find(temp => temp.AddressId == addressID);

        }

        //Method to GET the Address Details by WareHouseID
        public List<WareHouseAddress> GetAddressByWareHouseID(string wareHouseID)
        {

            return _addressList.FindAll(temp => temp.WareHouseId == wareHouseID);

        }

        //Method to GET WareHouseAddress details by LocationName
        public List<WareHouseAddress> GetAddressByLocationName(string locationName)
        {

            return _addressList.FindAll(temp => temp.LocationName == locationName);

        }

        //Method to UPDATE Door Number of WareHouse
        public void UpdateDoorNumber(WareHouseAddress address)// update WareHouse Name
        {
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.DoorNumber = address.DoorNumber;


            }
        }

        //Method to UPDATE the Location Name of WareHouse
        public void UpdateLocationName(WareHouseAddress address)// update WareHouse Name
        {
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.LocationName = address.LocationName;


            }
        }


        //Method to UPDATE the State of WareHouse
        public void UpdateState(WareHouseAddress address)// update product Name
        {
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.State = address.State;


            }
        }

        //Method to UPDATE the Pincode of WareHouse
        public void UpdatePincode(WareHouseAddress address)
        {
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.Pincode = address.Pincode;


            }
        }

        //Method to REMOVE an address of the Warehouse by wareHouseID
        public void RemoveAddressByWareHouseID(string wareHouseID)
        {

            _addressList.RemoveAll(n => n.WareHouseId == wareHouseID);

        }

        //Method to REMOVE an address of the Warehouse by addressID
        public void RemoveAddressByAddressID(string addressID) 
        {

            _addressList.RemoveAll(n => n.AddressId == addressID);

        }
    }
}
    