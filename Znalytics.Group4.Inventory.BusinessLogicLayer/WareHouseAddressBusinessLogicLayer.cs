// Created by Nitya
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.DataAccessLayer;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.AddressModule.DataAccessLayer;

namespace Znalytics.Inventory.AddressModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents BusinessLogic class of AddressWareHouse
    /// </summary>
    public class WareHouseAddressBusinessLogicLayer: IWareHouseAddressBusinessLogicLayer
    {
       WareHouseAddressDataAccessLayer wadl = new WareHouseAddressDataAccessLayer();

        //Method to add Address details to the list
        public void AddAddress(WareHouseAddress a)
        {
            if (a.AddressId != null)
            {
                
                wadl.AddAddress(a);
            }
        }

        // Method to display the added  address details
        public List<WareHouseAddress> GetAddresses()
        {
            return wadl.GetAddresses();
        }

        //Method to display WareHouseAddress details by AddressId
        public List<WareHouseAddress>GetAddressByAddressID(string addressID)
        {
            return wadl.GetAddressByAddressID(addressID);
        }

        //Method to display WareHouseAddress details by WareHouseId
        public List<WareHouseAddress>GetAddressByWareHouseID(string wareHouseID)
        {
            return wadl.GetAddressByWareHouseID(wareHouseID);
        }

        //Method to display WareHouseAddress details by LocationName
        public List<WareHouseAddress> GetAddressByLocationName(string locationName)
        {
            return wadl.GetAddressByLocationName(locationName);
        }

        //Method to update Door Number of WareHouse
        public void UpdateDoorNumber(WareHouseAddress address)// update product Name
        {

            if (address.AddressId != null)
            {
                wadl.UpdateDoorNumber(address);
            }
        }

        //Method to update the Location Name of WareHouse
        public void UpdateLocationName(WareHouseAddress address)// update product Name
        {

            if (address.AddressId != null)
            {
                wadl.UpdateLocationName(address);
            }

        }

        //Method to update the State of WareHouse
        public void UpdateState(WareHouseAddress address)// update product Name
        {

            if (address.AddressId != null)
            {
                wadl.UpdateState(address);
            }
        }

        //Method to update the Pincode of WareHouse
        public void UpdatePincode(WareHouseAddress address)// update product Name
        {

            if (address.AddressId != null)
            {
                wadl.UpdatePincode(address);
            }
        }

        //Method to remove an address of the Warehouse by wareHouseID
        public void RemoveAddressByWareHouseID(string wareHouseID)
        {
            if (wareHouseID != null)
            {
                wadl.RemoveAddressByWareHouseID(wareHouseID);
            }
        }

        //Method to remove an address of the Warehouse by addressID
        public void RemoveAddressByAddressID(string addressID)
        {
            if (addressID != null)
            {
                wadl.RemoveAddressByAddressID(addressID);
            }
        }


    }
}