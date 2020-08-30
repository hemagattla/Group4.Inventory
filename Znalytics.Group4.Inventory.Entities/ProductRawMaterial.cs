using System;


namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities
{
    public class ProductRawMaterial
    {
        private string _productId;
        private string _rawMaterialName;
        private string _rawMaterialID;
        private double _quantity;
        private string _units;

        public string ProductID
        {
            set
            {
                if (value != "")
                {
                    _productId = value;
                }
                else
                {
                    throw new Exception("Product ID Should not NULL");
                }
            }
            get
            {
                return _productId;
            }
        }
        /// <summary>
        /// write and read Property of string data type
        /// </summary>
        public string RawMaterialName
        {
            set
            {
                try
                {

                    if (!string.IsNullOrEmpty(value))//value should not be null and empty
                    {
                        char[] ch = value.ToCharArray();
                        for (int i = 0; i < ch.Length; i++)
                        {
                            if (('A' <= ch[i] && ch[i] <= 'Z') || ('a' <= ch[i] && ch[i] <= 'z'))//input should contains only alphabets
                            {
                                _rawMaterialName = value;
                            }
                            else
                            {
                                throw new Exception("******ur entered input contain other than Alphabets.pls enter the input which contains only Alphabets**********");
                            }
                        }
                    }

                    else
                    {
                        throw new Exception("************ur entered rawmaterialname null**************");
                    }
                }
                catch
                {
                    throw;
                }
            }
            get
            {
                return _rawMaterialName;
            }
        }
        /// <summary>
        /// property for RawMaterialID of string data type
        /// </summary>
        public string RawMaterialID
        {
            set
            {
                try
                {
                    if (!string.IsNullOrEmpty(value))//value should not be null and empty
                    {
                        if ((value.Length == 6) && (value.StartsWith("RMID")))//value must start with RMID and length shold be 6
                        {
                            _rawMaterialID = value;
                        }
                        else
                        {
                            throw new Exception("************ur entered RawMaterialID is invalid*************");
                        }
                    }
                    else
                    {
                        throw new Exception("************ur entered RawMaterialID is contains space/Null.pls try again*************");
                    }
                }
                catch
                {
                    throw;
                }
            }
            get
            {
                return _rawMaterialID;
            }
        }
        /// <summary>
        /// Property for Quantity of double data type
        /// </summary>
        public double Quantity
        {
            set
            {
                try
                {
                    if (value != 0D)// value should not be default value
                    {

                        _quantity = value;
                    }
                    else
                    {
                        throw new Exception("***********ur entered quantity is invalid***********");
                    }
                }
                catch
                {
                    throw;
                }
            }
            get
            {
                return _quantity;
            }
        }
       
        /// <summary>
        /// Property for units of string data type
        /// </summary>
        public string Units
        {
            set
            {
                try
                {
                    if (!string.IsNullOrEmpty(value))//value should not be null or empty
                    {
                        //value should match below condition
                        if (value.Equals("Kgs", StringComparison.OrdinalIgnoreCase) || value.Equals("Liters", StringComparison.OrdinalIgnoreCase) || value.Equals("Nos", StringComparison.OrdinalIgnoreCase) || value.Equals("Pices", StringComparison.OrdinalIgnoreCase))
                        {
                            _units = value;
                        }
                        else
                        {
                            throw new Exception("************* ur entered units are must contains only Alphabets and it should be like *kgs/liters/nos/pices*   ************* ");
                        }
                    }
                    else
                    {
                        throw new Exception("************* ur entered units are invalid. must contains only Alphabets and it should be like *kgs/liters/nos/pices*   ************ ");
                    }
                }
                catch
                {
                    throw;
                }
            }
            get
            {
                return _units;
            }
        }
    }
}
