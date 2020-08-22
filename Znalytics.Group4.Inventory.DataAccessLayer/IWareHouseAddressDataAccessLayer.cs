using System;
using System.Collections.Generic;
//Created by Nitya
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.AddressModule.Entities;

namespace Znalytics.Inventory.AddressModule.DataAccessLayer
{
    interface IWareHouseAddressDataAccessLayer
    {
        void AddAddress(WareHouseAddress a);
        List<WareHouseAddress> GetAddresses();
        WareHouseAddress GetAddressByAddressID(string AddressID);
        WareHouseAddress GetAddressByWareHouseID(string WareHouseID);
    }
}
