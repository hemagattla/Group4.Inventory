//Created by Nitya

using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Group4.Inventory.DataAccessLayer;
using Znalytics.Inventory.AddressModule.Entities;

namespace Znalytics.Inventory.AddressModule.DataAccessLayer
{

    /// <summary>
    /// Represents the class for WareHouse Address
    /// </summary>
    public class WareHouseAddressDataAccessLayer//: IWareHouseAddressDataAccessLayer
    {
        //Created a list for WareHouse Addresses
        public List<WareHouseAddress> _addressList
        {
            set;
            get;
        }

        // Constructor
        public WareHouseAddressDataAccessLayer()
        {
            _addressList = new List<WareHouseAddress>();
        }

        //Method to add address details to the list
        public void AddAddress(WareHouseAddress a)
        {
            _addressList.Add(a);
        }

        // Method to display the added address details
        public List<WareHouseAddress> GetAddresses()
        {
            return _addressList;
        }

        //Method to get the Address details by AddressID
        public List<WareHouseAddress> GetAddressByAddressID(string AddressID)
        {

            return _addressList.FindAll(temp => temp.AddressId == AddressID);

        }

        //Method to get the Address Details by WareHouseID
        public List<WareHouseAddress> GetAddressByWareHouseID(string WareHouseID)
        {

            return _addressList.FindAll(temp => temp.WareHouseId == WareHouseID);

        }

        //Method to display WareHouseAddress details by LocationName
        public List<WareHouseAddress> GetAddressByLocationName(string locationName)
        {

            return _addressList.FindAll(temp => temp.LocationName == locationName);

        }

        //Method to update Door Number of WareHouse
        public void UpdateDoorNumber(WareHouseAddress address)// update WareHouse Name
        {
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.DoorNumber = address.DoorNumber;


            }
        }

        //Method to update the Location Name of WareHouse
        public void UpdateLocationName(WareHouseAddress address)// update WareHouse Name
        {
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.LocationName = address.LocationName;


            }
        }


        //Method to update the State of WareHouse
        public void UpdateState(WareHouseAddress address)// update product Name
        {
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.State = address.State;


            }
        }

        //Method to update the Pincode of WareHouse
        public void UpdatePincode(WareHouseAddress address)
        {
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.Pincode = address.Pincode;


            }
        }

        //Method to remove an address of the Warehouse by wareHouseID
        public void RemoveAddressByWareHouseID(string wareHouseID)
        {

            _addressList.RemoveAll(n => n.WareHouseId == wareHouseID);

        }

        //Method to remove an address of the Warehouse by addressID
        public void RemoveAddressByAddressID(string addressID) 
        {

            _addressList.RemoveAll(n => n.AddressId == addressID);

        }
    }
}
    