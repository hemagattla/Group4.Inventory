//Created by Nitya

//Importing statements
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Group4.Inventory.DataAccessLayer;
using Znalytics.Inventory.AddressModule.Entities;
using System;
using Znalytics.Group4.Inventory.Entities;
using Newtonsoft.Json;
using System.IO;


//Created a namespace for DataAccessLayer of WareHouseAddress Module
namespace Znalytics.Inventory.AddressModule.DataAccessLayer
{

    /// <summary>
    /// Represents the class for WareHouse Address
    /// </summary>
    public class WareHouseAddressDataAccessLayer : WareHouseAddressAbstractDAL
    {
        //Created a list for WareHouse Addresses
        private static List<WareHouseAddress> _addressList
        {
            set;
            get;
        }

        //Static Constructor
        static WareHouseAddressDataAccessLayer()
        {
            _addressList = new List<WareHouseAddress>()
            {
                //Mock Data
                new WareHouseAddress(){WareHouseId="WHID01",AddressId="W1A1",DoorNumber="1-1-1",LocationName="WARANGAL",Pincode="505005"},
                new WareHouseAddress(){WareHouseId="WHID01",AddressId="W1A2",DoorNumber="1-2-2",LocationName="HYDERABAD",Pincode="506003"},
                new WareHouseAddress(){WareHouseId="WHID02",AddressId="W2A1",DoorNumber="2-1-1",LocationName="KARIMNAGAR",Pincode="506002"},
                new WareHouseAddress(){WareHouseId="WHID02",AddressId="W2A2",DoorNumber="2-2-2",LocationName="VIZA",Pincode="506009"},
            };
            if (_addressList.Count == 0)
            {
                _addressList = GetFiledata();
            }

        }

        //Method to ADD address details to the list
        public override void AddAddress(WareHouseAddress addressDetails)
        {
            //Condition to check whether the WareHouseId exists or not
            if (addressDetails.AddressId != null)
            {
                _addressList.Add(addressDetails);
                SaveIntoFile();

            }
            else
            {
                throw new WareHouseException("Warehouse id doesnot exist");
            }
        }

        private void SaveIntoFile()
        {
            string s = JsonConvert.SerializeObject(_addressList);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\WareHouseDataAddress.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        public static List<WareHouseAddress> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\WareHouseAddress.txt");
            string s2 = streamReader.ReadToEnd();
            List<WareHouseAddress> addr = JsonConvert.DeserializeObject<List<WareHouseAddress>>(s2);
            streamReader.Close();
            return addr;

        }


        // Method to GET the added address details
        public override List<WareHouseAddress> GetAddresses()
        {
            return _addressList;
        }

        //Method to GET the Address details by AddressID
        public override WareHouseAddress GetAddressByAddressID(string addressID)
        {
            //Condition to check whether the AddressId exists or not
            if (_addressList.Exists(temp => temp.AddressId == addressID))
            {
                return _addressList.Find(temp => temp.AddressId == addressID);
            }
            else
            {
                throw new WareHouseException("WareHouse id doesn't exist");
            }

        }

        //Method to GET the Address Details by WareHouseID
        public override WareHouseAddress GetAddressByWareHouseID(string wareHouseID)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_addressList.Exists(temp => temp.WareHouseId == wareHouseID))
            {
                return _addressList.Find(temp => temp.WareHouseId == wareHouseID);
            }
            else
            {
                throw new WareHouseException("WareHouse id doesn't exist");
            }

        }

        //Method to GET WareHouseAddress details by LocationName
        public override List<WareHouseAddress> GetAddressByLocationName(string locationName)
        {
            //Condition to check whether the LocationName exists or not
            if (_addressList.Exists(temp => temp.LocationName == locationName))
            {
                return _addressList.FindAll(temp => temp.LocationName == locationName);
            }
            else
            {
                throw new WareHouseException("location name doesn't exist");
            }

        }

        //Method to UPDATE Door Number of WareHouse
        public void UpdateDoorNumber(WareHouseAddress address)// update WareHouse Name
        {
            //Condition to check whether the AddressId exists or not
            if (_addressList.Exists(temp => temp.AddressId == address.AddressId))
            {
                WareHouseAddress wha = _addressList.Find(temp => temp.AddressId == address.AddressId);
                if (wha != null)
                {
                    wha.DoorNumber = address.DoorNumber;
                    SaveIntoFile();


                }
            }
            else
            {
                throw new WareHouseException("Address Id doesn't exist");
            }
        }

        //Method to UPDATE the Location Name of WareHouse
        public void UpdateLocationName(WareHouseAddress address)
        {
            //Condition to check whether the AddressId exists or not
            WareHouseAddress wha = _addressList.Find(temp => temp.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.LocationName = address.LocationName;
                SaveIntoFile();


            }
            else
            {
                throw new WareHouseException("Address Id doesn't exist");
            }
        }


        //Method to UPDATE the State of WareHouse
        public void UpdateState(WareHouseAddress address)// update product Name
        {
            //Condition to check whether the AddressId exists or not
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.State = address.State;
                SaveIntoFile();


            }
            else
            {
                throw new WareHouseException("Address Id doesn't exist");
            }
        }

        //Method to UPDATE the Pincode of WareHouse
        public void UpdatePincode(WareHouseAddress address)
        {
            //Condition to check whether the AddressId exists or not
            WareHouseAddress wha = _addressList.Find(n => n.AddressId == address.AddressId);
            if (wha != null)
            {
                wha.Pincode = address.Pincode;
                SaveIntoFile();


            }
            else
            {
                throw new WareHouseException("Address Id doesn't exist");
            }
        }

        //Method to REMOVE an address of the Warehouse by wareHouseID
        public void RemoveAddressByWareHouseID(string wareHouseID)
        {
            //Condition to check whether the WareHouseId exists or not
            if (_addressList.Exists(n => n.WareHouseId == wareHouseID))
            {

                _addressList.RemoveAll(n => n.WareHouseId == wareHouseID);
                SaveIntoFile();
            }
            else
            {
                throw new WareHouseException("Warehouse id doesn't exist");
            }

        }

        //Method to REMOVE an address of the Warehouse by addressID
        public void RemoveAddressByAddressID(string addressID)
        {
            //Condition to check whether the AddressId exists or not
            if (_addressList.Exists(n => n.AddressId == addressID))
            {
                _addressList.RemoveAll(n => n.AddressId == addressID);
                SaveIntoFile();
            }
            else
            {
                throw new WareHouseException("Address id doesn't exist");
            }

        }
        /// <summary>
        /// Method to check whether the AddressId exists or not
        /// </summary>
        /// <param name="id">Represents the Address id</param>
        /// <returns></returns>
        public static bool CheckAddressId(string id)
        {
            bool result = _addressList.Exists(temp => temp.AddressId == id);
            return result;
        }

    }
}



    