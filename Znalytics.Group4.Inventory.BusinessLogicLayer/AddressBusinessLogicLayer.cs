// Created by Nitya
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.DataAccessLayer;
namespace Znalytics.Inventory.WareHouseModule.DataAccessLayer {
    public class AddressBusinessLogicLayer
    {
        AddressDataAccessLayer adl = new AddressDataAccessLayer();
        public void AddAddress(Address a)
        {
            if (a.AddressId != null)
            {
                // DataAccess d = new DataAccess();
                adl.AddAddress(a);
            }
        }
        public List<Address> GetAddresses()
        {
            return adl.AddressList;
        }
        public Address GetAddressByAddressID(string AddressID)
        {
            return adl.AddressList.Find(temp => temp.AddressId == AddressID);
        }

        public Address GetAddressByWareHouseID(string WareHouseID)
        {
            return adl.AddressList.Find(temp => temp.WarehouseId == WareHouseID);
        }


    }
}