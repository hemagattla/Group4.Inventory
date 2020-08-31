
//created by R.Kruushal

using System.Text.RegularExpressions;
using Znalytics.Inventory.StockMaintain.CustomException;

namespace Znalytics.Inventory.StockMaintain.Entities
{
    /// <summary>
    /// refers Stock class in entite
    /// </summary>
    public class Stock
    {
        //Private fields
        private string _wareHouseID;
        private string _addressID;
        private string _productID;
        private string _stockID;




        /// <summary>
        /// Property of WareHouseID
        /// /// </summary>

        public string WareHouseID
        {
            set
            {
                //Regular Expression for AlphaNumeric values
                Regex r = new Regex("[A-Z0-9]$");
                //WareHouseId should not be null or empty
                if (!string.IsNullOrEmpty(value) && value.StartsWith("WHID") && r.IsMatch(value) && value.Length == 6)
                {


                    _wareHouseID = value;

                }

                else
                {
                    throw new StockException("Enter valid warehouseid.It should not contain spaces and length be exactly 6 and should start with WHID");
                }

            }

            get
            {
                return _wareHouseID;
            }
        }
        /// <summary>
        ///  Property of AddressName
        /// </summary>

        public string AddressID
        {
            set
            {
                //Regular Expression for AlphaNumeric values
                Regex r = new Regex("[A-Z0-9]$");
                //AddressId should not be null or empty
                if (!string.IsNullOrEmpty(value) && value.StartsWith("W") && value.Length == 4 && r.IsMatch(value))
                {

                    _addressID = value;

                }
                else
                {
                    throw new StockException("Invalid addressid. It should not contain spaces or Special Characters and length should be exactly 4 and should start with W");
                }
            }
            get
            {
                return _addressID;
            }
        }

        /// <summary>
        /// Property of ProductID
        /// </summary>
        public string ProductID
        {
            set
            {

                Regex r = new Regex("[A-Z0-9]$");
                if (value != "" && value.StartsWith("PID") && r.IsMatch(value) && value.Length <= 6)
                {
                    _productID = value;
                }
                else
                {
                    throw new StockException("Product ID Should not NULL and ProductID Should Start with PID and 0-9 number and length should be 6");
                }
            }
                get
            {
                return _productID;
            }
        }
        /// <summary>
        /// Property of StockId
        /// </summary>
        public string StockID
        {
            set
            {
                if (value.Length <= 2&!string.IsNullOrEmpty(value))
                {
                    _stockID = value;
                }
                else
                {
                    throw new System.Exception("ur entered stockID is invalid");
                }
            }
            get
            {
                return _stockID;
            }
        }
       
        /// <summary>
        /// autoimplemented property of Quantity
        /// </summary>
        public int Quantity
        {
            set;
            get;
        }
        /// <summary>
        /// autoimplemented property of TotalQuantity
        /// </summary>
        public int TotalQuantity
        {
            
                set;
                get;
            
        }


    }
}
