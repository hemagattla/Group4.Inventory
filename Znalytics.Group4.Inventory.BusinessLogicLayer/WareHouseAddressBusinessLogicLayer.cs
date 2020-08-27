// Created by Nitya

//Importing statements
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.DataAccessLayer;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.AddressModule.DataAccessLayer;
using System;

//Created a namespace for BusinessLayer of WareHouseAddress module
namespace Znalytics.Inventory.AddressModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents BusinessLogic class of AddressWareHouse
    /// </summary>
    public class WareHouseAddressBusinessLogicLayer: IWareHouseAddressBusinessLogicLayer
    {

        //Created an object for datalayer and stored it in reference variable
       WareHouseAddressDataAccessLayer wadl = new WareHouseAddressDataAccessLayer();

        //Method to ADD Address details to the list
        public void AddAddress(WareHouseAddress adressDetails)
        {

            try
            {
                //AddressId should not be null
                if (adressDetails.AddressId != null)
                {


                    wadl.AddAddress(adressDetails);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Method to GET the added  address details
        public List<WareHouseAddress> GetAddresses()
        {
            return wadl.GetAddresses();
        }

        //Method to GET WareHouseAddress details by AddressId
        public List<WareHouseAddress>GetAddressByAddressID(string addressID)
        {
            return wadl.GetAddressByAddressID(addressID);
        }

        //Method to GET WareHouseAddress details by WareHouseId
        public List<WareHouseAddress>GetAddressByWareHouseID(string wareHouseID)
        {
            return wadl.GetAddressByWareHouseID(wareHouseID);
        }

        //Method to GET WareHouseAddress details by LocationName
        public List<WareHouseAddress> GetAddressByLocationName(string locationName)
        {
            return wadl.GetAddressByLocationName(locationName);
        }

        //Method to UPDATE Door Number of WareHouse
        public void UpdateDoorNumber(WareHouseAddress address)
        {

            if (address.AddressId != null)
            {
                wadl.UpdateDoorNumber(address);
            }
        }

        //Method to UPDATE the Location Name of WareHouse
        public void UpdateLocationName(WareHouseAddress address)
        {

            if (address.AddressId != null)
            {
                wadl.UpdateLocationName(address);
            }

        }

        //Method to UPDATE the State of WareHouse
        public void UpdateState(WareHouseAddress address)
        {

            if (address.AddressId != null)
            {
                wadl.UpdateState(address);
            }
        }

        //Method to UPDATE the Pincode of WareHouse
        public void UpdatePincode(WareHouseAddress address)
        {

            if (address.AddressId != null)
            {
                wadl.UpdatePincode(address);
            }
        }

        //Method to REMOVE an address of the Warehouse by wareHouseID
        public void RemoveAddressByWareHouseID(string wareHouseID)
        {
            if (wareHouseID != null)
            {
                wadl.RemoveAddressByWareHouseID(wareHouseID);
            }
        }

        //Method to REMOVE an address of the Warehouse by addressID
        public void RemoveAddressByAddressID(string addressID)
        {
            if (addressID != null)
            {
                wadl.RemoveAddressByAddressID(addressID);
            }
        }


    }
}