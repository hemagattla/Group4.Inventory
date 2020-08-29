// Created by Nitya

//Importing statements
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.DataAccessLayer;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.AddressModule.DataAccessLayer;
using System;
using Znalytics.Group4.Inventory.Entities;

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
            catch (WareHouseException ex)
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
        public WareHouseAddress GetAddressByAddressID(string addressId)
        {
            try
            {
                //AddressId should not be null
                if (addressId != null)
                {
                    return wadl.GetAddressByAddressID(addressId);
                }
                else
                {
                    return null;
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }

        }

        //Method to GET WareHouseAddress details by WareHouseId
        public WareHouseAddress GetAddressByWareHouseID(string wareHouseId)
        {
            try
            {
                //WareHouseId should not be null
                if (wareHouseId != null)
                {
                    return wadl.GetAddressByWareHouseID(wareHouseId);
                }
                else
                {
                    return null;
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        //Method to GET WareHouseAddress details by LocationName
        public List<WareHouseAddress> GetAddressByLocationName(string locationName)
        {
            try
            {
                //Location Name should not be null
                if (locationName != null)
                {
                    return wadl.GetAddressByLocationName(locationName);
                }
                else
                {
                    return null;
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        //Method to UPDATE Door Number of WareHouse
        public void UpdateDoorNumber(WareHouseAddress address)
        {

            try
            {
                //AddressId should not be null
                if (address.AddressId != null)
                {
                    wadl.UpdateDoorNumber(address);
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        //Method to UPDATE the Location Name of WareHouse
        public void UpdateLocationName(WareHouseAddress address)
        {
                try
                {
                    //AddressId should not be null

                    if (address.AddressId != null)
                    {
                        wadl.UpdateLocationName(address);
                    }
                }
                catch (WareHouseException ex)
                {
                    throw;
                }
            

        }

        //Method to UPDATE the State of WareHouse
        public void UpdateState(WareHouseAddress address)
        {
                try
                {
                //AddressId should not be null
                if (address.AddressId != null)
                    {
                        wadl.UpdateState(address);
                    }
                }
                catch (WareHouseException ex)
                {
                    throw;
                }
            
        }

        //Method to UPDATE the Pincode of WareHouse
        public void UpdatePincode(WareHouseAddress address)
        {
            try
            {
                //AddressId should not be null
                if (address.AddressId != null)
                {
                    wadl.UpdatePincode(address);
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        //Method to REMOVE an address of the Warehouse by wareHouseID
        public void RemoveAddressByWareHouseID(string wareHouseID)
        {
            try
            {
                //WareHouseId should not be null
                if (wareHouseID != null)
                {
                    wadl.RemoveAddressByWareHouseID(wareHouseID);
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        //Method to REMOVE an address of the Warehouse by addressID
        public void RemoveAddressByAddressID(string addressID)
        {
            try
            {
                //AddressId should not be null
                if (addressID != null)
                {
                    wadl.RemoveAddressByAddressID(addressID);
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }


    }
}