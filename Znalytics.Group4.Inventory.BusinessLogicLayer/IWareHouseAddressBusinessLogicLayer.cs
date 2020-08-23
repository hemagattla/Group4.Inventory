using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.AddressModule.Entities;

namespace Znalytics.Inventory.AddressModule.BusinessLogicLayer
{
    interface IWareHouseAddressBusinessLogicLayer
    {
        //Method to add address details to the list
        void AddAddress(WareHouseAddress a);

        // Method to display the added address details
        List<WareHouseAddress> GetAddresses();

        //Method to get the Address details by AddressID
        WareHouseAddress GetAddressByAddressID(string AddressID);

        //Method to get the Address Details by WareHouseID
        WareHouseAddress GetAddressByWareHouseID(string WareHouseID);
    }
}
