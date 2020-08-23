
using System.CodeDom;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
namespace Znalytics.Inventory.Customer.Entities///collection of classes is namespace///
{
    public class Customer
    {
        private int _CustomerId;
        private string _CustomerName;
        private string _Email;
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
        public Customer(int cid, string cstname, string mail, string mblno, string cntry, string ci, string state, string st, string pin, string hno)

        {
            this.CustomerId = cid;///cuuurent method CoustomerId will be called and checks the conditons present in the method ant then asigns the value///
            this.CustomerName = cstname;
            this.Email = mail;
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
                if (value.Length < 30)
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
                if (value.Length == 10 && value[0] != 0)
                {
                    _MblNo = value;
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

        public string Country
        {
            set
            {
                if (value.Length <= 10)
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
}

