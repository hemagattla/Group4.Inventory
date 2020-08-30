namespace Znalytics.Inventory.StockMaintain.Entities
{
    /// <summary>
    /// Stock Details
    /// </summary>
    public class Stock
    {
        //Private fields
        private string _wareHouseID;
        private string _addressID;
        private string _productID;
        private string _stockID;
        private int _editStock;




        //Property of WareHouseID
        public string WareHouseID
        {
            set
            {
                //if input value and WareHouseID present in database matches then the value will be assigned to the _WareHouseID
                //else it will throw an exception
                if ((value.Length == 6) && (value.StartsWith("WHID")))
                {
                    _wareHouseID = value;

                }
                else
                {
                    throw new System.Exception("Entered AddressID is invalid");
                }

            }

            get
            {
                return _wareHouseID;
            }
        }
        //Property of AddressName
        public string AddressID
        {
            set
            {
                //if input value and AddressID present in database matches then the value will be assigned to the _AddressID
                //else it will throw an exception
                if ((value.Length <= 6) && (value.StartsWith("W")))
                {
                    _addressID = value;
                }
                else
                {
                    throw new System.Exception("Entered AddressID is invalid");
                }
            }
            get
            {
                return _addressID;
            }
        }

        //Property of ProductID
        public string ProductID
        {
            set
            {
                //if input value and ProductID present in database matches then the value will be assigned to the _ProductID
                //else it will throw an exception
                if (value != "")
                {
                    _productID = value;
                }
                else
                {
                    throw new System.Exception("Entered ProductID is invalid");
                }
            }
            get
            {
                return _productID;
            }
        }
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
        public int EditStock
        {
            set
            {
                if (value != 0)
                {
                    //it takes in put value and add to the exsisting quantity
                    _editStock = value;
                }
            }
            get
            {
                return _editStock;
            }
        }

        public int Quantity
        {
            set;
            get;
        }
        public int TotalQuantity
        {
            set;
            get;
        }


    }
}
