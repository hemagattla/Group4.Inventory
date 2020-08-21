// Created by Nitya
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.DataAccessLayer;
namespace Znalytics.Inventory.WareHouseModule.DataAccessLayer 
{

    /// <summary>
    /// Represents BusinessLogic class of AddressWareHouse
    /// </summary>
    public class WareHouseAddressBusinessLogicLayer
         {
       WareHouseAddressDataAccessLayer wadl = new WareHouseAddressDataAccessLayer();

        //Method to add Address details to the list
        public void AddAddress(WareHouseAddress a)
        {
            if (a.AddressId != null)
            {
                // DataAccess d = new DataAccess();
                wadl.AddAddress(a);
            }
        }

        // Method to display the added  address details
        public List<WareHouseAddress> GetAddresses()
        {
            return wadl.AddressList;
        }

        //Method to display WareHouseAddress details by AddressId
        public WareHouseAddress GetAddressByAddressID(string AddressID)
        {
            return wadl.AddressList.Find(temp => temp.AddressId == AddressID);
        }

        //Method to display WareHouseAddress details by WareHouseId
        public WareHouseAddress GetAddressByWareHouseID(string WareHouseID)
        {
            return wadl.AddressList.Find(temp => temp.WarehouseId == WareHouseID);
        }


    }
}