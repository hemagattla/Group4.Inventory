/// <summary>
/// product shipping address module of inventory management system
/// </summary>
public class ShippingAddressBusinessLogic
{
    ShippingAddressDataLayer dl = new ShippingAddressDataLayer();

    /// <summary>
    /// Adding ProductName to collections
    /// </summary>
    /// <param name="value"></param>
    public void AddProductName(ShippingAddress value)
    {
        if (value.ProductName != null)
        {
            dl.AddShippingDetails(value);
        }
        else
        {
            throw new System.Exception("Enter valid ProductName");
        }
    }
    /// <summary>
    /// Adding ProductID to collections
    /// </summary>
    /// <param name="value"></param>
    public void AddProductID(ShippingAddress value)
    {
        dl.AddShippingDetails(value);
    }
    /// <summary>
    /// Adding ProductPrice to Collections
    /// </summary>
    /// <param name="value"></param>
    public void AddProductPrice(ShippingAddress value)
    {
        if (value.ProductPrice > 0)
        {
            dl.AddShippingDetails(value);
        }
        else { throw new System.Exception("Enter valid product price"); }
    }
    /// <summary>
    /// Add CustomerName to Collections
    /// </summary>
    /// <param name="value"></param>
    public void AddCustomerName(ShippingAddress value)
    {
        if (value.CustomerName != null)
        {
            dl.AddShippingDetails(value);
        }
        else { throw new System.Exception("Enter valid CustomerName"); }

    }
    /// <summary>
    /// Add CountryName to Collections
    /// </summary>
    /// <param name="value"></param>
    public void AddCountryName(ShippingAddress value)
    {
        if (value.CustomerName != null)
        {
            dl.AddShippingDetails(value);
        }
        else throw new System.Exception("Enter valid CountryName");

    }
    /// <summary>
    /// Add StateName to Collections
    /// </summary>
    /// <param name="value"></param>
    public void AddStateName(ShippingAddress value)
    {
        if (value.StateName != null)
        {
            dl.AddShippingDetails(value);
        }
        else throw new System.Exception("Enter valid product price");
    }
    /// <summary>
    /// Add DistrictName to Collections
    /// </summary>
    /// <param name="value"></param>
    public void AddDistictName(ShippingAddress value)
    {
        if (value.DistrictName != null)
        {
            dl.AddShippingDetails(value);
        }
        else throw new System.Exception("Enter valid StateName");

    }/// <summary>
     /// AddCity Name
     /// </summary>
     /// <param name="value"></param>

    public void AddCityName(ShippingAddress value)
    {
        if (value.CityName != null)
        {
            dl.AddShippingDetails(value);
        }
        else throw new System.Exception("Enter valid CityName");
    }
    /// <summary>
    /// Add ColonyName to Collections
    /// </summary>
    /// <param name="value"></param>
    public void AddColonyName(ShippingAddress value)
    {
        if (value.Colony != null)
        {
            dl.AddShippingDetails(value);
        }
        else throw new System.Exception("Enter valid ColonyName");
    }
    //Add homeno to Collections
    public void AddHomeNo(ShippingAddress value)
    {
        if (value.HomeNo != null)
        {
            dl.AddShippingDetails(value);
        }
        else throw new System.Exception("Enter valid HomeNo");
    }
    /// <summary>
    /// ADD pincode To Collections
    /// </summary>
    /// <param name="value"></param>
    public void AddPinCode(ShippingAddress value)
    {
        if (value.PinCode != null)
        {
            dl.AddShippingDetails(value);
        }
        else throw new System.Exception("Enter valid Pincode");
    }
    /// <summary>
    /// Add MobileNumber to Collections
    /// </summary>
    /// <param name="value"></param>
    public void AddMobileNumber(ShippingAddress value)
    {
        if (value.MobileNumber.Length == 10)
        {
            dl.AddShippingDetails(value);
        }
        else throw new System.Exception("Enter valid Mobile Number");
    }
    //set EmailID Method
    public void AddEmailID(ShippingAddress value)
    {
        bool flag = true;
        for (int i = 0; i < value.EmailID.Length; i++)
            if (value.EmailID[i] == ' ')
            {
                flag = false;

            }
        if (flag == true)
        {
            dl.AddShippingDetails(value);
        }

        else throw new System.Exception("Enter valid HomeNo");
    }
}
    /*Get productName Method
    public string GetProductName()
    {
        return _productName;
    }
    //Get ProductID Method
    public string GetProductID()
    {
        return _productID;
    }
    // Get Product Price Method
    public double GetProductPrice()
    {
        return _productPrice;
    }
    //Get CustomerName Method
    public string GetCustomerName()
    {
        return _countryName;
    }
    // Get CountryName Method
    public string GetCountryName()
    {
        return _countryName;
    }
    //Get StateName Method
    public string GetStateName()
    {
        return _stateName;
    }
    //Get District Name Method
    public string GetDistrictName()
    {
        return _districtName;
    }
    //Get CityName Method
    public string GetCityName()
    {
        return _countryName;
    }
    //Get ColonyName Method
    public string Getcolony()
    {
        return _colony;
    }
    //Get HomeNo Method
    public string GetHomeNo()
    {
        return _homeNo;
    }
    //Get PinCode Method
    public string GetPinCode()
    {
        return _pincode;

    }
    //Get MobileNumber Method
    public string GetMobileNumber()
    {
        return _mobileNumber;
    }
    //Get EmailID Method
    public string GetEmailID()
    {
        return _emailID;
    }
}*/