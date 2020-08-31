// Created By Nitya

//Importing Statements
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.DataAccessLayer;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;
using System;
using Znalytics.Group4.Inventory.Entities;

//Created a namespace for BusinessLayer of WareHouse module
namespace Znalytics.Inventory.WareHouseModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents BusinessLogic class of WareHouse and Implementing an interface
    /// </summary>

    public class WareHouseBusinessLogicLayer : IWareHouseBusinessLogicLayer
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public WareHouseBusinessLogicLayer() { }


        /// <summary>
        /// Method to ADD WareHouse details to the list
        /// </summary>
        /// <param name="ware">Represents warehouse object</param>
        public void AddWareHouse(WareHouse ware)
        {

            try
            {
                //WareHouse Id should not be null 
                if (ware.WareHouseId != null)
                {
                    //Calls the AddWareHouse method of WareHouse Data Layer
                    WareHouseDataAccessLayer.AddWareHouse(ware);
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message); 
            }
        }

        /// <summary>
        /// Method to GET the added details
        /// </summary>
        /// <returns>It returns the list of WareHouses</returns>
        public List<WareHouse> GetWareHouses()
        {
            //Calls the GetWareHouses method of WareHouse Data Layer
            return WareHouseDataAccessLayer.GetWareHouses();
        }

        /// <summary>
        /// Method to GET WareHouse details by WareHouseId
        /// </summary>
        /// <param name="wareHouseID">Reprents WareHouse id</param>
        /// <returns></returns>
        public WareHouse GetWareHouseByWareHouseID(string wareHouseID)
        {
            try
            {
                //WareHouse Id should not be null
                if (wareHouseID != null)
                {
                    //Calls the GetWareHouseByWareHouseID method of WareHouse Data Layer
                    return WareHouseDataAccessLayer.GetWareHouseByWareHouseID(wareHouseID);
                }
                else
                {
                    return null;
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        /// Method to REMOVE WareHouse by WareHouseID
        /// </summary>
        /// <param name="wareHouseID">Reprents WareHouse id</param>
        public void RemoveWareHouseByWareHouseID(string wareHouseID)
        {
            try
            {
                //WareHouse Id should not be null
                if (wareHouseID != null)
                {
                    //Calls the RemoveWareHouseByWareHouseID method of WareHouse Data Layer
                    WareHouseDataAccessLayer.RemoveWareHouseByWareHouseID(wareHouseID);
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        /// Method to REMOVE WareHouse by WareHouse Name
        /// </summary>
        /// <param name="wareHouseName">Represents WareHouse Name</param>
        public void RemoveWareHouseByWareHouseName(string wareHouseName)
        {

            try
            {
                //WareHouse Name should not be null
                if (wareHouseName != null)
                {
                    //Calls the RemoveWareHouseByWareHouseName method of WareHouse Data Layer
                    WareHouseDataAccessLayer.RemoveWareHouseByWareHouseName(wareHouseName);
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message); 
            }
        }

        /// <summary>
        /// Method to UPDATE the WareHouse Name
        /// </summary>
        /// <param name="wareHouse">Represents the WareHouse object</param>
        public void UpdateWareHouseName(WareHouse wareHouse)
        {

            try
            {
                //WareHouse Id should not be null
                if (wareHouse.WareHouseId != null)
                {
                    //Calls the UpdateWareHouseName method of WareHouse Data Layer
                    WareHouseDataAccessLayer.UpdateWareHouseName(wareHouse);
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message);
            }
        }

        /// <summary>
        ///Method to UPDATE ManagerName
        /// </summary>
        /// <param name="wareHouse">Represents the WareHouse object</param>
        public void UpdateManagerName(WareHouse wareHouse)
        {

            try
            //WareHouse Id should not be null
            {
                if (wareHouse.WareHouseId != null)
                {
                    //Calls the UpdateManagerName method of WareHouse Data Layer
                    WareHouseDataAccessLayer.UpdateManagerName(wareHouse);
                }
            }
            catch (WareHouseException ex)
            {
                throw new WareHouseException(ex.Message); 
            }
        }
        /// <summary>
        /// Method to check whether WareHouseId exists or not
        /// </summary>
        /// <param name="whId">Represents WareHouse id</param>
        /// <returns></returns>
        public bool CheckWareHouseId(string whId)
        {
            //Calls the CheckWareHouseId method of WareHouse Data Layer
            return WareHouseDataAccessLayer.CheckWareHouseId(whId);
        }



    }
}
