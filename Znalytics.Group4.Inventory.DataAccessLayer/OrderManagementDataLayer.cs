
//Written By Dhanasri
using System.Collections.Generic;
using Znalytics.Inventory.AddressModule.Entities;
using Znalytics.Inventory.OrderManagementModule.Entities;
using Znalytics.Inventory.ProductModule.Entitie;
using System.Linq;
using Znalytics.Inventory.Module.Entities;
using Znalytics.Group4.Inventory.DataAccessLayer;
using System;
using Newtonsoft.Json;
using System.IO;
using Znalytics.Inventory.Module.DataAccessLayer;
namespace Znalytics.Inventory.OrderManagementModule.DataAccessLayer
{/// <summary>
///  Represents the OrderManagement Details in DataLayer
/// </summary>
    public class OrderManagementDataLayer : OrderManagmentDataLayerAbstract
    {
        private static List<OrderManagement> _orders;
        public OrderManagementDataLayer()
        {
            _orders = new List<OrderManagement>(){new OrderManagement()
            {
                ProductId="PID03",WareHouseAddressId="W1A1",CustomerAddressId=3,TotalPrice=567.00,Quantity=43,OrderID=1
            } };
                

           
        }
        



    /// <summary>
    /// Method For Saving FileInformation
    /// </summary>
        public void SaveIntoFile()
        {

            string s = JsonConvert.SerializeObject(_orders);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Documents.OrderManagementJson.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        /// <summary>
        /// Method For Getting Data From File
        /// </summary>
        /// <returns></returns>
        public  List<OrderManagement> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Documents.OrderManagementJson.txt");
            string s1 = streamReader.ReadToEnd();
            List<OrderManagement> orders = JsonConvert.DeserializeObject<List<OrderManagement>>(s1);
            return orders;

        }

        /// <summary>
        /// Method for Adding OrderDetails
        /// </summary>
        /// <param name="values"></param>

        public void AddOrderDetails(OrderManagement values)
        {
            _orders.Add(values);
            SaveIntoFile();
        }

        /// <summary>
        /// GetOrderDetails
        /// </summary>
        /// <returns></returns>
        public List<OrderManagement> GetOrderDetails()
        {
            return GetFiledata();
           
           
        }

       /// <summary>
       /// Cancel OrderDetails By Using OrderID
       /// </summary>
       /// <param name="values"></param>
        public void CancelOrder(int value)
        {
          OrderManagement order= _orders.Find(temp => temp.OrderID == value);
            _orders.Remove(order);
        }
        

        /// <summary>
        /// Get OrderDetails by WareHouseID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override List<OrderManagement> GetOrderDetailsByAddressID(string value)
        {
            List<OrderManagement> order = new List<OrderManagement>();
            foreach (var orders in _orders)
            {
                if (orders.WareHouseAddressId == value)
                {

                    order.Add(orders);
                }

            }

            return order;
        }
        /// <summary>
        /// Get OrderDetails by using ProductID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override List<OrderManagement> GetOrderDetailsByProductID(string value)
        {
            List<OrderManagement> order = new List<OrderManagement>();



            foreach (var orders in _orders)
            {

                if (orders.ProductId == value)
                {
                    order.Add(orders);


                }
            }

            
            return order;
        }
        /// <summary>
        /// Get OrderDetails By using CustomerID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderManagement> GetOrderDetailsByCustomerID(int value)
        {
            List<OrderManagement> order = new List<OrderManagement>();


            foreach (var orders in _orders)
            {
                if (orders.CustomerAddressId == value)
                {
                    order.Add(orders);
                }

            }

            return order;
        }
        /// <summary>
        /// OrderID Generation
        /// </summary>
        /// <returns></returns>
        public int OrderIdGeneration()
        {
           int orderid= _orders.Max(temp => temp.CustomerAddressId);
            return ++orderid;
        }
        /// <summary>
        /// Update ProductDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateProductDetails(int orderid,string value)
        {
            OrderManagement order = _orders.Find(temp => temp.OrderID == orderid);
           

            order.ProductId = value;
            SaveIntoFile();
            }
        /// <summary>
        /// UpdateWareHouse AddressDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
  
        public void UpdateWareHouseAddressDetails(int orderid, string value)
        {
            OrderManagement order = _orders.Find(temp => temp.OrderID == orderid);
            order.WareHouseAddressId = value;
            SaveIntoFile();
        }
        /// <summary>
        /// Update CustomerAddressDetails
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateCustomerAddressDetails(int orderid, int value)
        {
            OrderManagement order = _orders.Find(temp => temp.OrderID == orderid);
            
            order.CustomerAddressId = value;
            SaveIntoFile();
        }
        public void UpdateQuantity(int orderid, int value)
        {
            OrderManagement order = _orders.Find(temp => temp.OrderID == orderid);

            order.Quantity = value;
            SaveIntoFile();
        }




    }
}













