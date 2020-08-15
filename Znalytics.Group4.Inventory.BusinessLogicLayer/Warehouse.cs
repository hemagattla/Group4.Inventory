/// <summary>
/// Represents Inventory Warehouse
/// </summary>
public class WareHouse
{

    private string _managerName;
    private string _warehouseId;
    private string _locationId;
    private string _locationName;
    private string _pincode;
    private int _warehouseCapacity;
    //private string _warehouseStatus;




    /// <summary>
    /// Sets value into _managerName
    /// </summary>
    /// <param name="value">Value to assign into _managerName</param>
    public void SetMangerName(string value)
    {
        if (value.Length <= 30)
        {
            _managerName = value;
        }
    }
    /// <summary>
    /// Gets the value of _managerName
    /// </summary>
    /// <returns>Returns _managerName</returns>
    public string GetManagerName()
    {
        return _managerName;
    }
    /// <summary>
    /// Sets value into _warehouseId
    /// </summary>
    /// <param name="value">Value to assign into _warehouseId</param>
    public void SetWarehouseId(string value)
    {
        bool isSpaceFound = false;
        for (int i = 0; i < value.Length; i++)
        {
            if (value[i] == ' ')
            {
                isSpaceFound = true;
            }
        }
        if (isSpaceFound == false)
        {
            _warehouseId = value;
        }

    }
    /// <summary>
    /// Gets value of _warehouseId
    /// </summary>
    /// <returns>Returns  _warehouseId</returns>
    public string GetWarehouseId()
    {
        return _warehouseId;
    }
    /// <summary>
    /// Sets value into _locationId
    /// </summary>
    /// <param name="value">Value to assign into _locationId</param>
    public void SetLocationId(string value)
    {
        if (value.Length == 2)
        {
            bool isSpaceFound = false;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == ' ')
                {
                    isSpaceFound = true;
                }
            }
            if (isSpaceFound == false)
            {
                _warehouseId = value;
            }
        }
    }
    /// <summary>
    /// Gets value of _locationId
    /// </summary>
    /// <returns>Returns _locationId</returns>
    public string GetLocationId()
    {
        return _locationId;

    }
    /// <summary>
    /// Sets value into _locationName
    /// </summary>
    /// <param name="value">Value to assign into _locationName</param>
    public void SetLocationName(string value)
    {
        if (value.Length <= 30)
        {
            _locationName = value;
        }
    }
    /// <summary>
    /// Gets value of _locationName
    /// </summary>
    /// <returns>Returns _locationName</returns>
    public string GetLocationName()
    {
        return _locationName;
    }
    /// <summary>
    /// Sets value into _pincode
    /// </summary>
    /// <param name="value">Value to assign into pincode</param>
    public void SetPincode(string value)
    {
        if (value.Length == 6)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < '0' || value[i] > 9)
                {
                    _pincode = value;
                }
            }
        }
    }
    /// <summary>
    /// Gets the value of _pincode
    /// </summary>
    /// <returns>Returns pincode</returns>
    public string GetPincode()
    {
        return _pincode;
    }
    /// <summary>
    ///Sets value into warehouseCapacity
    /// </summary>
    /// <param name="value">Value to assign into _warehouseCapacity</param>
    public void SetCapacity(int value)
    {
        _warehouseCapacity = value;
    }
    /// <summary>
    /// Gets value of _warehouseCapacity
    /// </summary>
    /// <returns>Returns the value of _warehouseCapacity</returns>
    public int GetCapacity()
    {
        return _warehouseCapacity;
    }





    public void Add()
    {



    }
    public void Display()
    {

    }

    public void Update()
    {

    }
    public void Delete()
    {

    }
    public void Exit()
    {

    }


}
