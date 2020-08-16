public class Stock
{
    private int _WareHouseID;
    private int _AddressID;
    private int _ProductID;
    private int _Quantity = 0;
    public void SetWareHouseID(int value1, int value2, int value3, int value4, int value5)
    {
        if (value1 == 1234)
        {
            _WareHouseID = value1;
            SetAddressID(value2, value3, value4, value5);
        }
        else
        {
            throw new System.Exception("ur entered WareHouseID is invalid");
        }
    }
    public int GetWareHouseID()
    {
        return _WareHouseID;
    }
    public void SetAddressID(int value2, int value3, int value4, int value5)
    {
        if (value2 == 2345)
        {
            _AddressID = value2;
            SetProductID(value3, value4, value5);
        }
        else
        {
            throw new System.Exception("ur entered AddressID is invalid");
        }
    }
    public int GetAddressID()
    {
        return _AddressID;
    }
    public void SetProductID(int value3, int value4, int value5)
    {
        if (value3 == 3456)
        {
            _ProductID = value3;
            switch (value4)
            {
                case 1:
                    AddQuantity(value5);
                    break;
                case 2:
                    DeleteQuantity(value5);
                    break;
                case 3:
                    UpDateQuantity();
                    break;
            }
        }
        else
        {
            throw new System.Exception("ur entered ProductID is invalid");
        }
    }
    public int GetProductID()
    {
        return _ProductID;
    }
    public void AddQuantity(int value5)
    {
        _Quantity += value5;
    }
    public void DeleteQuantity(int value5)
    {
        _Quantity -= value5;
        if (_Quantity > 0)
        {
            _Quantity -= value5;
        }
        else
        {
            _Quantity = 0;
        }
    }
    public int UpDateQuantity()
    {
        return _Quantity;
    }

}
