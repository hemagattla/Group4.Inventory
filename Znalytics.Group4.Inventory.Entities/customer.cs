
using System.CodeDom;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
public class Customer
{
    private int _CustomerId;
    private string _FirstName;
    private string _LastName;
    private string _Email;
    private string _MblNo;
    public int CustomerId
    {
        set
        {
            if (value >= 0 && value <= 9)
            {
                _CustomerId = value;
            }
        }
        get
        {
            return _CustomerId;

        }
    }


    public string FirstName
    {
        set
        {
            if (value.Length <= 5)
            {
                _FirstName = value;
            }
        }
        get
        {
            return _FirstName;
        }
    }
    public string LastName
    {
        set
        {
            if (value.Length <= 5)
            {
                _LastName = value;
            }
        }
        get
        {
            return _LastName;
        }
    }
    public string MblNo
    {
        set
        {
            if (value.Length == 10 && value[0] != 0)
            {
                _MblNo = value;
            }
            else
            {
                System.Console.WriteLine("phone no is must contain  10 digits ");
            }
        }
        get
        {
            return _MblNo;
        }
    }
    public string Email
    {
        set
        {
            Regex r = new Regex("^[a-zA-Z0-9@.]*$");
            if (r.IsMatch(value))
            {
                _Email = value;
            }
            else
            {
                throw new System.Exception("enter valid email");
            }
        }
        get
        {
            return _Email;
        }
    }
    public string GetEmail()
    {
        return _Email;
    }
}

public class Adress : Customer
{
    private string _country;
    private string _City;
    private string _State;
    private string _Street;
    private string _PinNo;
    private string _HNo;
    public string Country
    {
        set
        {
            if (value.Length <= 10)
            {
                _country = value;
            }
        }
        get
        {
            return _country;

        }
    }

    public string State
    {
        set
        {
            if (value.Length <= 10)
            {
                _State = value;
            }
        }
        get
        {
            return _State;
        }
    }
    public string GetState()
    {
        return _State;
    }
    public string City
    {
        set
        {


            if (value.Length <= 10)
            {
                _City = value;
            }
        }
        get
        {
            return _City;
        }
    }
    public string Street
    {
        set
        {
            if (value.Length <= 10)
            {
                this._Street = value;
            }
        }
        get
        {
            return _Street;
        }
    }




    public string PinNo

    {
        set
        {
            if (value.Length == 6)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (value[i] > 0 && value[i] < 9)
                    {
                        _PinNo = value;
                    }
                }
            }
        }

        get
        {
            return _PinNo;
        }
    }
    public string HNo
    {
        set
        {
            if (value.Length <= 6)
            {
                this._HNo = value;
            }
        }
        get
        {
            return _HNo;
        }

    }

}
