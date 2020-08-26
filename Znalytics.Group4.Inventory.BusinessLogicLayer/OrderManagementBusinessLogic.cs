using System.Collections.Generic;

namespace Znalytics.Inventory.OrderManagementModule.BusinessLogicLayer
{
    public class OrderManagementBusinessLogic
    {
        OrderManagementDataLayer dl;


        public OrderManagementBusinessLogic()
        {
            dl = new OrderManagementDataLayer();
        }

        IProductBusinessLogicLayer i = new ProductBusiness();

        public ProductEntitie ProductDetails(int ProductID)
        {
            return i.GetProductByProductID(ProductID);

        }
        public


        /// <summary>
        /// Adding OrderDetails to collections
        /// </summary>
        /// <param name="value"></param>
        public void AddOrderDetails(OrderManagement values)
        {
            if (values.Products != null)
            {
                dl.AddOrderDetails(values);
            }
            else
            {
                throw new System.Exception("Select Atleast one product");
            }
            /// <summary>
            /// Add WareHouseAddress to the Collections
            /// </summary>
            /// <param name="value"></param>

            if (values.WareHouseAddress != null)
            {
                dl.AddShippingDetails(values);
            }
            else { throw new System.Exception("Select Warehouse Address"); }


            /// <summary>
            /// Add CustomerAdddress to the Collections
            /// </summary>
            /// <param name="value"></param>

            if (values.CustomerAddress != null)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Select Customer Address");

            /// <summary>
            /// Add Price to Collections
            /// </summary>
            /// <param name="value"></param>

            if (values.Price>0)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Please Caluclate the Price Correctly ");

            /// <summary>
            /// Add Shipping Status To the Collections
            /// </summary>
            /// <param name="value"></param>


            if (values.ShippingStatus==true||values.ShippingStatus==false)
            {
                dl.AddShippingDetails(values);
            }
            else throw new System.Exception("Enter either true or False");

            
            
        
        //Delete OrderDetails
        public void DeleteOrderDetails(OrderManagement values)
        {
            dl.DeleteAddressDetails(values);
        }
        public void UpdateAddressDetails()
        {


        }
    }

}  
   

    }
}
