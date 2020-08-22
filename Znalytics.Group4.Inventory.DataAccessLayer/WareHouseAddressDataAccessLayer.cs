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
    public class WareHouseAddressDataAccessLayer
    {
        //Created a list for WareHouse Addresses
        public List<WareHouseAddress> AddressList
        {
            set;
            get;
        }

        // Constructor
        public WareHouseAddressDataAccessLayer()
        {
            AddressList = new List<WareHouseAddress>();
        }

        //Method to add address details to the list
        public void AddAddress(WareHouseAddress a)
        {
            AddressList.Add(a);
        }

        // Method to display the added address details
        public List<WareHouseAddress> GetAddresses()
        {
            return AddressList;
        }

        //Method to get the Address details by AddressID
        public WareHouseAddress GetAddressByAddressID(string AddressID)
        {
            return AddressList.Find(temp => temp.AddressId == AddressID);
        }

        //Method to get the Address Details by WareHouseID
        public WareHouseAddress GetAddressByWareHouseID(string WareHouseID)
        {
            return AddressList.Find(temp => temp.WarehouseId == WareHouseID);
        }
    }
}
    