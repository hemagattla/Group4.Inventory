//Created by Nitya

//Importing Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.AddressModule.Entities;


namespace Znalytics.Inventory.AddressModule.BusinessLogicLayer
{
    /// <summary>
    /// Represents an interface of WareHouseAddressBusinessLogicLayer
    /// </summary>
    interface IWareHouseAddressBusinessLogicLayer
    {
        /// <summary>
        /// Method to add address details to the list
        /// </summary>
        /// <param name="a"></param>
        void AddAddress(WareHouseAddress a);

        /// <summary>
        /// Method to add address details to the list
        /// </summary>
        /// <returns></returns>
        List<WareHouseAddress> GetAddresses();


        /// <summary>
        /// Method to get the Address details by AddressID
        /// </summary>
        /// <param name="addressID">Represents Addressid</param>
        /// <returns></returns>
        WareHouseAddress GetAddressByAddressID(string addressID);


        /// <summary>
        /// Method to get the Address Details by WareHouseID
        /// </summary>
        /// <param name="wareHouseID">Represents WareHouse id</param>
        /// <returns></returns>
        WareHouseAddress GetAddressByWareHouseID(string wareHouseID);
    }
}
