// Created by Nitya

//Importing statements
using System.Collections.Generic;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.AddressModule.DataAccessLayer;
using Znalytics.Group4.Inventory.Entities;

//Created a namespace for BusinessLayer of WareHouseAddress module
namespace Znalytics.Inventory.AddressModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents BusinessLogic class of WareHouseAddress.It implements an Interface
    /// </summary>
    public class WareHouseAddressBusinessLogicLayer: IWareHouseAddressBusinessLogicLayer
    {

        //Created an object for datalayer and stored it in reference variable
       WareHouseAddressDataAccessLayer wadl = new WareHouseAddressDataAccessLayer();

        /// <summary>
        /// Method to ADD Address details to the list
        /// </summary>
        /// <param name="address">Represents the object of WareHouse Address</param>
        public void AddAddress(WareHouseAddress address)
        {

            try
            {
                //AddressId should not be null
                if (address.AddressId != null)
                {

                    //Calls the AddAddress Method of WareHouseAddress Data Layer
                    wadl.AddAddress(address);
                }

            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        /// Method to GET the added  address details
        /// </summary>
        /// <returns>Returns the address list</returns>
        public List<WareHouseAddress> GetAddresses()
        {
            return (List<WareHouseAddress>)wadl.GetEnumerator();
        }

        /// <summary>
        /// Method to GET WareHouseAddress details by AddressId
        /// </summary>
        /// <param name="addressId">Represents AddressId</param>
        /// <returns></returns>
        public WareHouseAddress GetAddressByAddressID(string addressId)
        {
            try
            {
                //AddressId should not be null
                if (addressId != null)
                {
                    //Calls the GetAddressByAddressID Method of WareHouseAddress Data Layer
                    return wadl.GetAddressByAddressID(addressId);
                }
                else
                {
                    return null;
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }

        }

        /// <summary>
        /// Method to GET WareHouseAddress details by AddressId
        /// </summary>
        /// <param name="wareHouseId">Represents WareHouseId</param>
        /// <returns></returns>
        public WareHouseAddress GetAddressByWareHouseID(string wareHouseId)
        {
            try
            {
                //WareHouseId should not be null
                if (wareHouseId != null)
                {
                    //Calls the GetAddressByWareHouseID Method of WareHouseAddress Data Layer
                    return wadl.GetAddressByWareHouseID(wareHouseId);
                }
                else
                {
                    return null;
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        /// Method to GET WareHouseAddress details by LocationName
        /// </summary>
        /// <param name="locationName">Represents Location Name</param>
        /// <returns></returns>
        public List<WareHouseAddress> GetAddressByLocationName(string locationName)
        {
            try
            {
                //Location Name should not be null
                if (locationName != null)
                {
                    //Calls the GetAddressByLocationName Method of WareHouseAddress Data Layer
                    return wadl.GetAddressByLocationName(locationName);
                }
                else
                {
                    return null;
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        /// Method to UPDATE Door Number of WareHouse
        /// </summary>
        /// <param name="address">Represents object of WareHouseAddress</param>
        public void UpdateDoorNumber(WareHouseAddress address)
        {

            try
            {
                //AddressId should not be null
                if (address.AddressId != null)
                {
                    //Calls the UpdateDoorNumber Method of WareHouseAddress Data Layer
                    wadl.UpdateDoorNumber(address);
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        /// Method to UPDATE the Location Name of WareHouse
        /// </summary>
        /// <param name="address">Represents object of WareHouseAddress</param>
        public void UpdateLocationName(WareHouseAddress address)
        {
                try
                {
                    //AddressId should not be null

                    if (address.AddressId != null)
                    {
                    //Calls the UpdateLocationName Method of WareHouseAddress Data Layer
                    wadl.UpdateLocationName(address);
                    }
                }
                catch (WareHouseException ex)
                {
                    throw new WareHouseException(ex.Message);
                }
            

        }
        /// <summary>
        /// Method to UPDATE the State of WareHouse
        /// </summary>
        /// <param name="address">Represents object of WareHouseAddress</param>

        public void UpdateState(WareHouseAddress address)
        {
                try
                {
                //AddressId should not be null
                if (address.AddressId != null)
                    {
                    //Calls the UpdateState Method of WareHouseAddress Data Layer
                    wadl.UpdateState(address);
                    }
                }
                catch (WareHouseException ex)
                {
                    throw new WareHouseException(ex.Message);
                }
            
        }


        /// <summary>
        /// Method to UPDATE the Pincode of WareHouse
        /// </summary>
        /// <param name="address">Represents object of WareHouseAddress</param>
        public void UpdatePincode(WareHouseAddress address)
        {
            try
            {
                //AddressId should not be null
                if (address.AddressId != null)
                {
                    //Calls the UpdatePincode Method of WareHouseAddress Data Layer
                    wadl.UpdatePincode(address);
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        /// Method to REMOVE an address of the Warehouse by wareHouseID
        /// </summary>
        /// <param name="wareHouseID">Represents WareHouseId</param>
        public void RemoveAddressByWareHouseID(string wareHouseID)
        {
            try
            {
                //WareHouseId should not be null
                if (wareHouseID != null)
                {
                    //Call the RemoveAddressByWareHouseID method of WareHouseAddress Data Layer
                    wadl.RemoveAddressByWareHouseID(wareHouseID);
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        /// Method to REMOVE an address of the Warehouse by addressID
        /// </summary>
        /// <param name="addressID">Represents Address Id</param>
        public void RemoveAddressByAddressID(string addressID)
        {
            try
            {
                //AddressId should not be null
                if (addressID != null)
                {
                    //Call the RemoveAddressByAddressID method of WareHouseAddress Data Layer
                    wadl.RemoveAddressByAddressID(addressID);
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        /// Method to check whether the AddressId exists or not
        /// </summary>
        /// <param name="id">Represents the Address id</param>
        /// <returns></returns>
        public bool CheckAddressId(string id)
        {
            //Call the CheckAddressId method of WareHouseAddress Data Layer
            return wadl.CheckAddressId(id);
        }



    }
}