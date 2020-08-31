//Created By Hema
//Raw Materials Module of Inventory Management System
//EntityLayer
using System;
using Znalytics.Group4.Inventory.RawMaterialModule.EntityLayer;
//NameSpace of EntityLayer
namespace Znalytics.Group4.Inventory.RawMaterialModule.Entities
{
    /// <summary>
    /// RawMaterial is a public class we can access out side the class also
    /// </summary>
    /// <param name="rawmaterialname ">Represents Name Of the RawMaterial</param>
    /// /// <param name="rawmaterialID ">Represents ID Of the RawMaterial</param>
    /// /// <param name="quantity ">Represents Quantity Of the RawMaterial</param>
    /// /// <param name="units ">Represents units Of the RawMaterial</param>
    /// /// <param name="price ">Represents Price Of the RawMaterial</param>
    public class RawMaterial
    {
        //private fileds
        private string _rawMaterialName;
        private string _rawMaterialID;
        private double _quantity;
        private string _units;
        private double _price;




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
                                _rawMaterialName = value.ToLower();
                               
                            }
                            else
                            {
                                throw new RawMaterialException("******ur entered input contain other than Alphabets.pls enter the input which contains only Alphabets**********");
                            }
                        }
                    }

                    else
                    {
                        throw new RawMaterialException("************ur entered rawmaterialname null**************");
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
                            throw new RawMaterialException("************ur entered RawMaterialID is invalid*************");
                        }
                    }
                    else
                    {
                        throw new RawMaterialException("************ur entered RawMaterialID is contains space/Null.pls try again*************");
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
                        throw new RawMaterialException("***********ur entered quantity is invalid***********");
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
        /// property for price of double data type
        /// </summary>
        public double Price
        {
            set
            {
                try
                {
                    if (value != 0D)//value should not be default
                    {
                        _price = value;
                    }
                    else
                    {
                        throw new RawMaterialException("***********ur entered price is invalid*************");
                    }
                }
                catch
                {
                    throw;
                }
            }
            get
            {
                return _price;
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
                        if (value.Equals("Kgs", StringComparison.OrdinalIgnoreCase) || value.Equals("Liters", StringComparison.OrdinalIgnoreCase) || value.Equals("Nos", StringComparison.OrdinalIgnoreCase) || value.Equals("Pices", StringComparison.OrdinalIgnoreCase) || value.Equals("ml", StringComparison.OrdinalIgnoreCase)|| value.Equals("gms", StringComparison.OrdinalIgnoreCase))
                        {
                            _units = value.ToLower();
                        }
                        else
                        {
                            throw new RawMaterialException("************* ur entered units are must contains only Alphabets and it should be like *kgs/liters/nos/pices*   ************* ");
                        }
                    }
                    else
                    {
                        throw new RawMaterialException("************* ur entered units are invalid. must contains only Alphabets and it should be like *kgs/liters/nos/pices*   ************ ");
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
