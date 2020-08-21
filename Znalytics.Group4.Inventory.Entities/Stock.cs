namespace Znalytics.Inventory.StockMaintain.Entities
{
    /// <summary>
    /// Stock Details
    /// </summary>
    public class Stock
    {
        //Private fields
        private string _wareHouseID;
        private string _addressName;
        private string _productID;
        private string _stockID;
        private int _quantity;

        //Property of WareHouseID
        public string WareHouseID
        {
            set
            {
                //if input value and WareHouseID present in database matches then the value will be assigned to the _WareHouseID
                //else it will throw an exception
                if ((value.Length==5)&&(value.StartsWith("WID")))
                {
                    _wareHouseID = value;

                }
                else
                {
                    throw new System.Exception("ur entered WareHouseID is invalid");
                }
            }

            get
            {
                return _wareHouseID;
            }
        }
        //Property of AddressName
        public string AddressName
        {
            set
            {
                //if input value and AddressID present in database matches then the value will be assigned to the _AddressID
                //else it will throw an exception
                if ((value.Length==5)&&(value.StartsWith("AID")))
                {
                    _addressName = value;
                }
                else
                {
                    throw new System.Exception("ur entered AddressID is invalid");
                }
            }
            get
            {
                return _addressName;
            }
        }

        //Property of ProductID
        public string ProductID
        {
            set
            {
                //if input value and ProductID present in database matches then the value will be assigned to the _ProductID
                //else it will throw an exception
                if ((value.Length==5)&&(value.StartsWith("PID")))
                {
                    _productID = value;
                }
                else
                {
                    throw new System.Exception("ur entered ProductID is invalid");
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
                if (value.Length <= 2)
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

        public int Add
        {
            set
            {
                //it takes in put value and add to the exsisting quantity
                _quantity += value;
            }
            get
            {
                return _quantity;
            }
        }
      
        public int Quantity
        {
            set
            {
            }
            get
            {
                return _quantity;
            }
        }

    }
}
