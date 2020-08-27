// Created By Nitya

//Importing Statements
using System.Collections.Generic;
using Znalytics.Inventory.WareHouseModule.Entities;
using Znalytics.Inventory.WareHouseModule.DataAccessLayer;
using Znalytics.Group4.Inventory.IBusinessLogicLayer;
using System;

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
                //WareHouse Id should not be null and should not be duplicate
                if (n.WareHouseId != null)
                {

                    d.AddWareHouse(n);
                }
            }
            catch (Exception ex)
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
            return d.GetWareHouseByWareHouseID(wareHouseID);
        }

        //Method to REMOVE WareHouse  by WareHouseId
        public void RemoveWareHouseByID(string wareHouseID)
        {
            if (wareHouseID != null)
            {
                d.RemoveWareHouseByID(wareHouseID);
            }
        }

        //Method to REMOVE WareHouse  by WareHouseName
        public void RemoveWareHouseByName(string wareHouseName)
        {
            if (wareHouseName != null)
            {
                d.RemoveWareHouseByName(wareHouseName);
            }
        }

        //Method to UPDATE WareHouseName
        public void UpdateWareHouseName(WareHouse wareHouse)// update product Name
        {

            if (wareHouse.WareHouseId != null)
            {
                d.UpdateWareHouseName(wareHouse);
            }
        }

        //Method to UPDATE ManagerName
        public void UpdateManagerName(WareHouse wareHouse)// update product Name
        {

            if (wareHouse.WareHouseId != null)
            {
                d.UpdateManagerName(wareHouse);
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
