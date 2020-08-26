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
        public List<WareHouseAddress> GetAddressByAddressID(string addressId)
        {
            return wadl.GetAddressByAddressID(addressId);
        }

        //Method to display WareHouseAddress details by WareHouseId
        public List<WareHouseAddress> GetAddressByWareHouseID(string wareHouseID)
        {
            return wadl.GetAddressByWareHouseID(wareHouseID);
        }

        //Method to display WareHouseAddress details by LocationName
        public List<WareHouseAddress> GetAddressByLocationName(string locationName)
        {
            return wadl.GetAddressByLocationName(locationName);
        }

        public void UpdateDoorNumber(WareHouseAddress address)// update product Name
        {

            if (address.AddressId != null)
            {
                wadl.UpdateDoorNumber(address);
            }
        }
        public void UpdateLocationName(WareHouseAddress address)// update product Name
        {

            if (address.AddressId != null)
            {
                wadl.UpdateLocationName(address);
            }

        }
        public void UpdateState(WareHouseAddress address)// update product Name
        {

            if (address.AddressId != null)
            {
                wadl.UpdateState(address);
            }
        }
        public void UpdatePincode(WareHouseAddress address)// update product Name
        {

            if (address.AddressId != null)
            {
                wadl.UpdatePincode(address);
            }
        }

        public void RemoveAddressByWareHouseID(string wareHouseID)
        {
            if (wareHouseID != null)
            {
                wadl.RemoveAddressByWareHouseID(wareHouseID);
            }
        }

        public void RemoveAddressByAddressID(string addressID)
        {
            if (addressID != null)
            {
                wadl.RemoveAddressByAddressID(addressID);
            }
        }


    }
}