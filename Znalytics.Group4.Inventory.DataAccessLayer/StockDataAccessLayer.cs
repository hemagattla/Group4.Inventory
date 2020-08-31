//created by R.Kruushal


using System.Collections.Generic;
using System.Linq;
using Znalytics.Inventory.StockMaintain.Entities;
using Znalytics.Inventory.StockMaintain.CustomException;
using Newtonsoft.Json;
using System.IO;


namespace Znalytics.Inventory.StockMaintain.DataAccessLayer
{
    /// <summary>
    /// This class represents data access logic for Stock
    /// </summary>
    public class StockDataAccessLogic 
    {
        //creating a List private List property
        private static List<Stock> _stocks
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor Stock Data Access Logic that initializes collection
        /// </summary>
        static StockDataAccessLogic()
        {
            _stocks = new List<Stock>()// creating the Stock List object
            {
                new Stock(){ StockID="1",WareHouseID="WHID01",AddressID="W1A1",ProductID="PID10",Quantity=10 }

            };
            if (_stocks.Count == 0 && File.Exists(@"C:\Users\Administrator\Desktop\StockData.txt")) 
            {
                _stocks = GetFiledata();
            }
           

        }

        /// <summary>
        /// used to add stock details into the stocks List
        /// </summary>
        /// <param name="stock">its of Stock class type which contains stock details to be stored into the list</param>
        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            SaveIntoFile();

        }


        /// <summary>
        /// used to calculate total Quantity of product
        /// </summary>
        /// <param name="warehouseID">calculation will be done if the warehouseID exits in the stokcs list</param>
        /// <param name="addressID">calculation will be done if the addressID exits in the stokcs list</param>
        /// <returns></returns>

        public int TotalQuantity(string warehouseID, string addressID)
        {
            bool result = _stocks.Exists(temp => temp.WareHouseID == warehouseID && temp.AddressID == addressID);

            if (result == true)
            {
                return _stocks.Select(x => x.Quantity).Sum();
              
            }
            else
            {
                throw new StockException("no stock id");
            }

        }
        /// <summary>
        /// Displaying the number of Stocks available of product in each ware house
        /// </summary>
        /// <param name="stock">it contains the user entered warehouse id and warehouse adddress</param>
        /// <returns> returns Stock List</returns>
        public List<Stock> DisplayStock(string warehouseID, string addressID)
        {
            bool result = _stocks.Exists(temp => temp.WareHouseID ==warehouseID && temp.AddressID ==addressID);
            if (result == true)
            {
                return _stocks;
            }
            else
            {
                throw new StockException("invlaid WarehouseID or AdressID");
            }
        }

        /// <summary>
        /// used to Update the quntity of Stock of Product of Particular WarehouseID and warehouse AddressId
        /// </summary>
        /// <param name="stock">contains user entered information like Warehouseid,warehouse addreesid and Productid</param>
        public void UpdateStockQuantity(Stock stock)
       {
            Stock stock1 = _stocks.Find(n => n.WareHouseID==stock.WareHouseID&&n.AddressID==stock.AddressID&&n.ProductID==stock.ProductID);
            if(stock1!=null)
            {
                stock1.Quantity = stock.Quantity;
            }
            else
            {
                throw new StockException("No such WareHouseId or AddressId or ProductId found");
            }

        }


        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        public void SaveIntoFile()
        {

            string s = JsonConvert.SerializeObject(_stocks);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\StockData.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        /// <summary>
        /// reading the data from Json file and return the data in the file in List format
        /// </summary>
        /// <returns>return List of products avaliable int ProductData.Txt</returns>
        public static List<Stock> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\StockData.txt");
            string s2 = streamReader.ReadToEnd();
            List<Stock> stocks2 = JsonConvert.DeserializeObject<List<Stock>>(s2);
            streamReader.Close();
            return stocks2;

        }

    }
}
