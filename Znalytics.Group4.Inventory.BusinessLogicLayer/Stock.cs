using System.Dynamic;
/// <summary>
/// Stock Details
/// </summary>
public class Stock
{
    //Private fields
    private int _WareHouseID;
    private int _AddressID;
    private int _ProductID;
    private int _Quantity = 0;
    /// <summary>
    /// Add method with 4 parameters 
    /// </summary>
    /// <param name="WHID">Represents WareHouseID</param>
    /// <param name="AID">Represents AddressID</param>
    /// <param name="PID">Represents ProductID</param>
    /// <param name="ADD">Represents the no.of quantity u want to add</param>
    public void AddQuantity(int WHID, int AID, int PID, int ADD)
    {
            WareHouseID = WHID;
            AddressID = AID;
            ProductID = PID;  
            Add=ADD;
    }
    /// <summary>
    /// Delete method with 4 parameters
    /// </summary>
    /// <param name="WHID">Represents WareHouseID</param>
    /// <param name="AID">Represents AddressID</param>
    /// <param name="PID">Represents ProductID</param>
    /// <param name="SUB">Represents the no.of quamtities u want to delete</param>
    public void DeleteQuantity(int WHID, int AID, int PID, int SUB)
    {
        WareHouseID = WHID;
        AddressID = AID;
        ProductID = PID;
        Delete = SUB;
    }
    /// <summary>
    /// Update method with 3 parameters
    /// </summary>
    /// <param name="WHID">Represents WareHouseID</param>
    /// <param name="AID">Represents AddressID</param>
    /// <param name="PID">Represents ProductID</param>
    public void UpDateQuantity(int WHID, int AID, int PID)
    {
       
            WareHouseID = WHID;
            AddressID = AID;
            ProductID = PID;
    }
    //Property of WareHouseID
    public int WareHouseID
    {
        set
        {
            //if input value and WareHouseID present in database matches then the value will be assigned to the _WareHouseID
            //else it will throw an exception
            if (1234 == value)
            {
                _WareHouseID = value;

            }
            else
            {
                throw new System.Exception("ur entered WareHouseID is invalid");
            }
        }

        get
        {
            return _WareHouseID;
        }
    }
    public int AddressID
    {
        set
        {
            //if input value and AddressID present in database matches then the value will be assigned to the _AddressID
            //else it will throw an exception
            if (2345 == value)
            {
                _AddressID = value;
            }
            else
            {
                throw new System.Exception("ur entered AddressID is invalid");
            }
        }
        get 
        {
            return _AddressID;
        }
    }

    public int ProductID
    {
        set
        {
            //if input value and ProductID present in database matches then the value will be assigned to the _ProductID
            //else it will throw an exception
            if (value == 3456)
            {
                _ProductID = value;
            }
            else
            {
                throw new System.Exception("ur entered ProductID is invalid");
            }
        }
        get
        {
                return _ProductID;
        }
    }
    
    public int Add
    {
        set
        {
            //it takes in put value and add to the exsisting quantity
            _Quantity += value;
        }
        get
        {
            return _Quantity;
        }
    }
    public int Delete
    {
        set
        {
            //it will take input value and substract from the exsisting quantity
            //after that if the quantity is more than 0 then only it will assign the value
            //else it makes quantity =0 and returns
            _Quantity -= value;
            if (_Quantity > 0)
            {
                _Quantity -= value;
            }
            else
            {
                _Quantity = 0;
            }
        }
        get
        {
            return _Quantity;
        }
    }
    public int UpDate
    {
        get
        {
            return _Quantity;
        }
    }

}
