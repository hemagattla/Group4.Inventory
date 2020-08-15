public class rawmaterials
{
    private int _rawmaterialID;
    private string _rawmaterialName;
    private double _quantity;
    private double _availableunits;
    private double _unitsused;
    private double _price;


    public void SetRawmaterialID(int value)
    {
        _rawmaterialID = value;
    }
    public int GetRawmaterialID()
    {
        return _rawmaterialID;
    }
    public void SetRawmaterialName(string value)
    {
        _rawmaterialName = value;
    }
    public string GetRawmaterialName()
    {
        return _rawmaterialName;
    }
    public void Setquantity(double value)
    {
        _quantity = value;
    }
    public double GetQuantity()
    {
        return _quantity;
    }
    public void SetUnitsused(double value)
    {
        _unitsused = value;
    }
    public double GetUnitsused()
    {
        return _unitsused;
    }
    public void SetAvailableunits()
    {
        _availableunits = _quantity - _unitsused;

    }
    public double GetAvailableunits()
    {
        return _availableunits;
    }
    public void SetPrice(double value)
    {
        _price = value * _quantity;
    }
    public double GetPrice()
    {
        return _price;
    }



}

