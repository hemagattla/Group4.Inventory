using System;
using System.Collections.Generic;
//Created by Nitya
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.AddressModule.Entities;

namespace Znalytics.Inventory.AddressModule.DataAccessLayer
{
    public abstract class WareHouseAddressAbstractDAL
    {
        //Method to add address details to the list
       public abstract void AddAddress(WareHouseAddress addressDetails);

       // Method to display the added address details
      public abstract List<WareHouseAddress> GetAddresses();

    //Method to get the Address details by AddressID
    public abstract WareHouseAddress GetAddressByAddressID(string AddressID);

    //Method to get the Address Details by WareHouseID
    public abstract WareHouseAddress GetAddressByWareHouseID(string WareHouseID);

        //Method to GET WareHouseAddress details by LocationName
        public abstract List<WareHouseAddress> GetAddressByLocationName(string locationName);
    }
}
