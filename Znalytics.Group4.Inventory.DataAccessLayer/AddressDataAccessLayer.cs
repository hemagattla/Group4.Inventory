using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Group4.Inventory.DataAccessLayer;
namespace Znalytics.Inventory.WareHouseModule.DataAccessLayer
{
    public class AddressDataAccessLayer
    {
        public List<Address> AddressList
        {
            set;
            get;
        }
        public AddressDataAccessLayer()
        {
            AddressList = new List<Address>();
        }
        public void AddAddress(WareHouse n)
        {
            AddressList.Add(n);
        }
        public List<WareHouse> GetAddresses()
        {
            return AddressList;
        }

        public Address GetAddressByAddressID(string AddressID)
        {
            return AddressList.Find(temp => temp.AddressId == AddressID);
        }
        public Address GetAddressByWareHouseID(string WareHouseID)
        {
            return AddressList.Find(temp => temp.WarehouseId == WareHouseID);
        }
    }