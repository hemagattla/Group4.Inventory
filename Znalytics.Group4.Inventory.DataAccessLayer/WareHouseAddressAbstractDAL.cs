//Created by Nitya

//Importing Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Inventory.AddressModule.Entities;

namespace Znalytics.Inventory.AddressModule.DataAccessLayer
{
    /// <summary>
    /// Represents abstract class.Its methods must be implemented in the child class
    /// </summary>
    public abstract class WareHouseAddressAbstractDAL
    {
        /// <summary>
        /// //Method to add address details to the list
        /// </summary>
        /// <param name="addressDetails"></param>
        public abstract void AddAddress(WareHouseAddress addressDetails);


        /// <summary>
        ///Method to display the added address details
        /// </summary>
        /// <returns></returns>
       // public abstract List<WareHouseAddress> GetAddresses();

        /// <summary>
        /// Method to get the Address details by AddressID
        /// </summary>
        /// <param name="AddressID">Represents Address id</param>
        /// <returns></returns>
        public abstract WareHouseAddress GetAddressByAddressID(string AddressID);

        /// <summary>
        /// Method to get the Address Details by WareHouseID
        /// </summary>
        /// <param name="WareHouseID">Represents Warehouse id</param>
        /// <returns></returns>
        public abstract WareHouseAddress GetAddressByWareHouseID(string WareHouseID);

        /// <summary>
        /// //Method to GET WareHouseAddress details by LocationName
        /// </summary>
        /// <param name="locationName">Represents Location Name</param>
        /// <returns></returns>
        public abstract List<WareHouseAddress> GetAddressByLocationName(string locationName);
    }
}
