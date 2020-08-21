using Znalytics.Group4.Inventory.Entities;
using Znalytics.Group4.Inventory.DataAccessLayer;
using System.Collections.Generic;

namespace Group4.Inventory.BusinessLogicLayer
{

    public class ShippingAddressBusinessLogic
    {
        ShippingAddressDataLayer dl = new ShippingAddressDataLayer();

        /// <summary>
        /// Adding ProductName to collections
        /// </summary>
        /// <param name="value"></param>
        public void AddressDetails(ProductShippingAddress values)
        {
            if (values.PruductName != null)
            {
                dl.AddShippingDetails(values);
            }
            else
            {
                throw new System.Exception("Enter valid Address Details");
            }

            /// <summary>
            /// Adding ProductID to collections
            /// </summary>
            /// <param name="value"></param>
            if (values.ProductID.Length == 10)
            {
                dl.AddShippingDetails(values);
            }
            else
            {
                throw new System.Exception("enter 10 digit productID");
            }
            /// <summary>
            /// Adding ProductPrice to Collections
            /// </summary>
            /// <param name="value"></param>


            if (values.ProductPrice > 0)
            {
                dl.AddShippingDetails(values);
            }
            else { throw new System.Exception("Enter valid product price"); }

            /// <summary>
            /// Add CustomerName to Collections
            /// </summary>
            /// <param name="value"></param>

            if (values.CustomerName != null)
            {
                dl.AddShippingDetails(values);
            }
            else { throw new System.Exception("Enter valid CustomerName"); }

        
        /// <summary>
        /// Add CountryName to Collections
        /// </summary>
        /// <param name="value"></param>
        
            if (values.CustomerName != null)
            {
                dl.AddShippingDetails(values);
            }
            else {throw new System.Exception("Enter valid CountryName");}

        
        /// <summary>
        /// Add StateName to Collections
        /// </summary>
        /// <param name="value"></param>
        
            if (values.StateName != null)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Enter valid product price");
        
        /// <summary>
        /// Add DistrictName to Collections
        /// </summary>
        /// <param name="value"></param>
        
            if (values.DistrictName != null)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Enter valid StateName");

        /// <summary>
         /// AddCity Name
         /// </summary>
         /// <param name="value"></param>

       
            if (values.CityName != null)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Enter valid CityName");
        
        /// <summary>
        /// Add ColonyName to Collections
        /// </summary>
        /// <param name="value"></param>
       
            if (values.Colony != null)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Enter valid ColonyName");
        
        //Add homeno to Collections
       
        
            if (values.HomeNo != null)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Enter valid HomeNo");
        
        /// <summary>
        /// ADD pincode To Collections
        /// </summary>
        /// <param name="value"></param>
        
            if (values.PinCode != null)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Enter valid Pincode");
        
        /// <summary>
        /// Add MobileNumber to Collections
        /// </summary>
        /// <param name="value"></param>
       
            if (values.MobileNumber.Length == 10)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Enter valid Mobile Number");
        
        //Add EmailID to collections
        
        
            bool flag = true;
            for (int i = 0; i < values.EmailID.Length; i++)
                if (values.EmailID[i] == ' ')
                {
                    flag = false;

                }
            if (flag == true)
            {
                dl.AddShippingDetails(values);
            }

            else throw new System.Exception("Enter valid HomeNo");
        }
        public List<ShippingAddress> ShippingAddressesDetails()
        {
            return dl.ShippingAddressDetails();

        }
    }
}
    
   
   