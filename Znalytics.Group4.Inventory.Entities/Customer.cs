
using System;
using System.CodeDom;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
namespace Znalytics.Inventory.Module.Entities///collection of classes is namespace///
{
    public class Customer
    {
        private int _CustomerId;
        private string _CustomerName;
        private string _Email;
        private string _PassWord;
        private string _MblNo;
        private string _Country;
        private string _City;
        private string _State;
        private string _Street;
        private string _PinNo;
        private string _HNo;
        public Customer()///default constructor
        {

        }
        /// <summary>
        /// parameterized constructor(when ever an object is created  constructed is called)
        /// 
        /// </summary>
        public Customer(int cid, string cstname, string mail, string password,string mblno, string cntry, string ci, string state, string st, string pin, string hno)

        {
            this.CustomerId = cid;///cuuurent method CoustomerId will be called and checks the conditons present in the method ant then asigns the value///
            this.CustomerName = cstname;
            this.Email = mail;
            this.PassWord = password;
            this.MblNo = mblno;
            this.Country = cntry;
            this.City = ci;
            this.State = state;
            this.Street = st;
            this.PinNo = pin;
            this.HNo = hno;
        }/// <summary>

         /// </summary>
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


        public string CustomerName
        {
            set
            {
                Regex r = new Regex("[a-zA-Z_]$");
                //customerName should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
                { 
                    _CustomerName = value;
                }
                else
                {
                    throw new System.Exception("enter the name having lessthan 30 charecter");
                }
            }
            get
            {
                return _CustomerName;
            }
        }
        public string MblNo
        {
            set
            {
                Regex r = new Regex("[0-9]$");
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value))
                {
                    if (value.Length == 10 && value[0] != 0)
                    {
                        _MblNo = value;
                    }
                }
                else
                {
                    throw new System.Exception("phone no is must contain  10 digits ");
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
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                if (regex.IsMatch(value) == true)
                {
                    _Email = value;
                }
                else
                {
                    throw new Exception("Email should not contain spaces and should include @ symbol.");
                }
                }

            get
            {
                return _Email;
            }
        
          }
    public string PassWord
        {
            set

            {
                Regex r = new Regex("[a-zA-Z0-9]$");
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value))
                {
                    if (value.Length == 6)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            if (value[i] > 0 || value[i] < 9)
                            {
                                _PassWord = value;
                            }
                        }
                    }
                }
            }
                get
                {
                    return _PassWord;
                }
            }
           

        public string Country
        {
            set
            {

                Regex r = new Regex("[a-zA-Z_]+$");
                //LocationName should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
                {
                    _Country = value;
                }
            }
            get
            {
                return _Country;

            }
        }

        public string State
        {
            set
            {
                Regex r = new Regex("[a-zA-Z_]+$");
                //LocationName should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
                {
                    _State = value;
                }
            }
            get
            {
                return _State;
            }
        }
        
        public string City
        {
            set
            {

                Regex r = new Regex("[a-zA-Z_]+$");
                //LocationName should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
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
                Regex r = new Regex("[a-zA-Z_]+$");
                //street should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
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
                ///pin should not be null or empty it should be length of 6///
                if(!string.IsNullOrEmpty(value) && value.Length <= 6)
                { 
                    for (int i = 0; i < 6; i++)
                    {
                        if (value[i] > 0 || value[i] < 9)
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
                ///home number should not be null or empty///
                if (!string.IsNullOrEmpty(value) && value.Length <= 30)
                {
                    _HNo = value;
                }
            }
            get
            {
                return _HNo;
            }

        }
    }
}

