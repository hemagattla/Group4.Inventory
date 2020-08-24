

namespace Znalytics.Group4.Inventory.RawMaterial.Entities
{
    public class RawMaterial
    {
        private string _wareHouseID;
        private string _rawMaterialName;
        private string _rawMaterialID;
        private string _quantity;
        private string _units;
        private double _price;
       
        public string WareHouseID
        {
            set
            {
                if((value.Length==6)&&(value.StartsWith("WHID")))
                        {
                    _wareHouseID = value;
                }
                else
                {
                    throw new System.Exception("ur entered warehouseID is invalid");
                }
            }
            get
            {
                return _wareHouseID;
            }
        }
        public string RawMaterialName
        {
            set
            {
                if (value != null)
                {
                    _rawMaterialName = value;
                }
            
                else
                {
                    throw new System.Exception("ur entered rawmaterialname null");
                }
            }
            get
            {
                return _rawMaterialName;
            }
        }
        public string RawMaterialID
        {
            set
            {
                if ((value.Length == 6) && (value.StartsWith("RMID")))
                {
                    _rawMaterialID = value;
                }
                else
                {
                    throw new System.Exception("ur entered RawMaterialID is invalid");
                }
            }
            get
            {
                return _rawMaterialID;
            }
        }
        public string Quantity
        {
            set
            {
                if (value!=null)
                {
                    _quantity = value;
                }
                else
                {
                    throw new System.Exception("ur entered quantity is invalid");
                }
            }
            get
            {
                return _quantity;
            }
        }
        public double Price
        {
            set
            {
                if (value== 0D)
                {
                    _price = value;
                }
                else
                {
                    throw new System.Exception("ur entered price is invalid");
                }
            }
            get
            {
                return _price;
            }
        }
        public string Units
        {
            set
            {
                if (value!=null)
                {
                    _units = value;
                }
                else
                {
                    throw new System.Exception("ur entered units is invalid");
                }
            }
            get
            {
                return _units;
            }
        }
    }
}
