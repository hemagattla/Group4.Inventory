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

        WareHouseDataAccessLayer d;

        //Constructor
        public WareHouseBusinessLogicLayer()
        {
            //Creating object for DataAcessLayer and storing  in reference variable
            d = new WareHouseDataAccessLayer();
        }

        //Method to ADD WareHouse details to the list
        public void AddWareHouse(WareHouse n)
        {

            try
            {
                //WareHouse Id should not be null 
                if (n.WareHouseId != null)
                {

                    d.AddWareHouse(n);
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        // Method to GET the added details
        public List<WareHouse> GetWareHouses()
        {
            return d.GetWareHouses();
        }

        //Method to GET WareHouse details by WareHouseId
        public WareHouse GetWareHouseByWareHouseID(string wareHouseID)
        {
            try
            {
                //WareHouse Id should not be null
                if (wareHouseID != null)
                {
                    return d.GetWareHouseByWareHouseID(wareHouseID);
                }
                else
                {
                    return null;
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        //Method to REMOVE WareHouse  by WareHouseId
        public void RemoveWareHouseByID(string wareHouseID)
        {
            try
            {
                //WareHouse Id should not be null
                if (wareHouseID != null)
                {
                    d.RemoveWareHouseByID(wareHouseID);
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        //Method to REMOVE WareHouse  by WareHouseName
        public void RemoveWareHouseByName(string wareHouseName)
        {

            try
            {
                //WareHouse Name should not be null
                if (wareHouseName != null)
                {
                    d.RemoveWareHouseByName(wareHouseName);
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        //Method to UPDATE WareHouseName
        public void UpdateWareHouseName(WareHouse wareHouse)// update product Name
        {

            try
            {
                //WareHouse Id should not be null
                if (wareHouse.WareHouseId != null)
                {
                    d.UpdateWareHouseName(wareHouse);
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }

        //Method to UPDATE ManagerName
        public void UpdateManagerName(WareHouse wareHouse)// update product Name
        {

            try
            //WareHouse Id should not be null
            {
                if (wareHouse.WareHouseId != null)
                {
                    d.UpdateManagerName(wareHouse);
                }
            }
            catch (WareHouseException ex)
            {
                throw;
            }
        }


        public int getStockQuantity()
        {
            return 0;
        }

        public int getStockQuantity(int productID)
        {
            throw new System.NotImplementedException();
        }
    }
}
