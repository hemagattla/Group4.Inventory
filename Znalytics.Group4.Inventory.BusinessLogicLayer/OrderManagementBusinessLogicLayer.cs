using System;
using System.Collections.Generic;
using Znalytics.Inventory.OrderManagementModule.DataAccessLayer;

using Znalytics.Group4.Inventory.IBusinessLogicLayer;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytics.Inventory.OrderManagementModule.Entities;

namespace Znalytics.Group4.Inventory.BusinessLogicLayer
{
    class OrderManagementBusinessLogicLayer
    {
            OrderManagementDataLayer dl;


            public OrderManagementBusinessLogicLayer()
            {
                dl = new OrderManagementDataLayer();
            }

            IProductBusinessLogicLayer i = new ProductBusiness();
        /// <summary>
        /// Get ProductDetails By product
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
            public Product ProductDetails(int ProductID)
            {
                return i.GetProductByProductID(ProductID);

            }



        /// <summary>
        /// Adding OrderDetails to collections
        /// </summary>
        /// <param name="value"></param>
        public void AddOrderDetails(Znalytics.Inventory.OrderManagementModule.Entities.OrderManagement values)
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
                dl.AddOrderDetails(values);
            }
            else { throw new System.Exception("Select Warehouse Address"); }


            /// <summary>
            /// Add CustomerAdddress to the Collections
            /// </summary>
            /// <param name="value"></param>

            if (values.CustomerAddress != null)
            {
                dl.AddOrderDetails(values);
            }
            else throw new System.Exception("Select Customer Address");

            /// <summary>
            /// Add Price to Collections
            /// </summary>
            /// <param name="value"></param>

            if (values.Price > 0)
            {
                dl.AddOrderDetails(values);
            }
            else throw new System.Exception("Please Caluclate the Price Correctly ");

            /// <summary>
            /// Add Shipping Status To the Collections
            /// </summary>
            /// <param name="value"></param>


            if (values.ShippingStatus == true || values.ShippingStatus == false)
            {
                dl.AddOrderDetails(values);
            }
            else throw new System.Exception("Enter either true or False");

        }


                //Delete OrderDetails
                public void DeleteOrderDetails(OrderManagement values)
                {
                    dl.DeleteOrder(values);
                }
                public void UpdateAddressDetails()
                {


                }
            }

        }


    


    

