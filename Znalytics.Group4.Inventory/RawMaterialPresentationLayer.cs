//Created By Hema
//Raw Materials Module of Inventory Management System
//PresentationLayer
using System.Collections.Generic;//NameSpace of Collections
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;//NameSpace of EntityLayer
using Znalytics.Group4.Inventory.RawMaterialModule.BusinessLogicLayer;//NameSpace of BussinessLogicLayer
using Znalytics.Group4.Inventory.RawMaterialModule.EntityLayer;
using Newtonsoft.Json;
using System.IO;
//NameSpace of PresentationLayer
namespace Znalytics.Group4.Inventory.RawMaterialModule.PresentationLayer
{
    /// <summary>
    /// RawMaterialPresentationLayer is a Internal class
    /// </summary>
    class RawMaterialPresentationLayer
    {
        //Execution starts from MainMethod
        public void RawMaterialMenu()
        {
            System.Console.WriteLine("========================Raw Material==========================");
            int select;//local varialbe
            bool q;//local variable
            try
            {
                do
                {
                    System.Console.WriteLine("1.Add Raw Material");
                    System.Console.WriteLine("2.Delete Raw Material");
                    System.Console.WriteLine("3.view Raw Material");
                    System.Console.WriteLine("4.Update Raw Material");
                    System.Console.WriteLine("5.GetRawmaterial By RawMaterialID");
                    System.Console.WriteLine("6.Exit");
                    System.Console.WriteLine("enter the choice");
                    System.Console.WriteLine("=======================================================");
                    q = int.TryParse(System.Console.ReadLine(), out select);//Trypase:- we are converting string to int

                    if (q == true)
                    {
                        RawMaterial rawMaterial = new RawMaterial();//creating object of entity class
                        RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
                        switch (select)
                        {
                            case 1:
                                System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
                                rawMaterial.RawMaterialID = System.Console.ReadLine();
                                if (rawMaterialBusinessLogicLayer.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID) == null)//Checks wheather entered RawMaterialID exists in list or not
                                {
                                    AddRawMaterial(rawMaterial.RawMaterialID);//Static method we can call directly
                                    System.Console.WriteLine("******************* Successfully added RawMaterial Details of ID" + rawMaterial.RawMaterialID + " ************** ");
                                }
                                else
                                {
                                    System.Console.WriteLine("**************entered RawMaterialID" + rawMaterial.RawMaterialID + "already exists. Pls Try again*************");
                                }
                                break;
                            case 2:
                                System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
                                rawMaterial.RawMaterialID = System.Console.ReadLine();
                                if (rawMaterialBusinessLogicLayer.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID) != null)//Checks wheather entered RawMaterialID exists in list or not
                                {
                                    DeleteRawMaterialByRawMaterialID(rawMaterial.RawMaterialID);//Static method we can call directly
                                    System.Console.WriteLine("******************* Successfully Deleted RawMaterialID" + rawMaterial.RawMaterialID + " * ************** ");
                                }
                                else
                                {
                                    System.Console.WriteLine("**************entered RawMaterialID " + rawMaterial.RawMaterialID + " does not exists. Pls Try again*************");
                                }
                                break;
                            case 3:
                                GetRawMaterial();//Static method we can call directly
                                break;
                            case 4:
                                System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
                                rawMaterial.RawMaterialID = System.Console.ReadLine();
                                if (rawMaterialBusinessLogicLayer.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID) != null)//Checks wheather entered RawMaterialID exists in list or not
                                {
                                    UpdateRawMaterial(rawMaterial.RawMaterialID);//Static method we can call directly
                                    System.Console.WriteLine("******************* Updated successfully *************** ");
                                }
                                else
                                {
                                    System.Console.WriteLine("**************entered RawMaterialID " + rawMaterial.RawMaterialID + " does not exists. Pls Try again*************");
                                }
                                break;
                            case 5:
                                System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
                                rawMaterial.RawMaterialID = System.Console.ReadLine();
                                if (rawMaterialBusinessLogicLayer.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID) != null)//Checks wheather entered RawMaterialID exists in list or not
                                {
                                    GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID);//Static method we can call directly
                                    System.Console.WriteLine("******************* U can see the details now *************** ");
                                }
                                else
                                {
                                    System.Console.WriteLine("**************entered RawMaterialID " + rawMaterial.RawMaterialID + " does not exists. Pls Try again*************");
                                }
                                break;
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Please Enter the only digits");
                    }

                } while (select != 6);
            }
            catch (RawMaterialException ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            

        }

        /// <summary>
        /// AddRawMaterial is a static method
        /// </summary>
        /// <param name="RawMaterialID">Repesents ID of the RawMaterial</param>
        public static void AddRawMaterial(string RawMaterialID)
        {
            RawMaterial rawMaterial = new RawMaterial();//creating object of entity class
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class

            rawMaterial.RawMaterialID = RawMaterialID;
            System.Console.WriteLine("Enter RawMaterialName");
            rawMaterial.RawMaterialName = System.Console.ReadLine();
            System.Console.WriteLine("Enter Quantity");
            rawMaterial.Quantity = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Enter units");
            rawMaterial.Units = System.Console.ReadLine();
            System.Console.WriteLine("Enter Price");
            rawMaterial.Price = System.Convert.ToDouble(System.Console.ReadLine());
            rawMaterialBusinessLogicLayer.AddRawMaterial(rawMaterial);//calling the AddRawMaterial method prsent in businessLogicLayer by using Reference variable

        }

       
        //deletes the rawmaterial from the list if RawMaterialID matches
        /// <summary>
        /// DeleteRawMaterialByRawMaterialID is a Static Method
        /// </summary>
        /// <param name="RawMaterialID">Repesents ID of the RawMaterial</param>
        public static void DeleteRawMaterialByRawMaterialID(string RawMaterialID)
        {
            RawMaterial rawMaterial = new RawMaterial();
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();

            rawMaterial.RawMaterialID = RawMaterialID;
            System.Console.WriteLine("Enter RawMaterialName");
            rawMaterial.RawMaterialName = System.Console.ReadLine();
            System.Console.WriteLine("Enter Quantity");
            rawMaterial.Quantity = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Enter units");
            rawMaterial.Units = System.Console.ReadLine();
            System.Console.WriteLine("Enter Price");
            rawMaterial.Price = System.Convert.ToDouble(System.Console.ReadLine());
            rawMaterialBusinessLogicLayer.DeleteRawMaterial(rawMaterial);//calling the DeleteRawMaterial method prsent in businessLogicLayer by using Reference variable
        }

        
        //Display the details of RawMaterial present in the list
        /// <summary>
        /// GetRawMaterial is a static Method
        /// </summary>
        public static void GetRawMaterial()
        {
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
            List<RawMaterial> rms = rawMaterialBusinessLogicLayer.GetRawMaterial();// call the GetRawMaterial method with no arguments in the BusinessLogicLayer by using Refernce Variable
            System.Console.WriteLine("**********************************************************************************");
            foreach (RawMaterial rm in rms)//to print the list
            {
                System.Console.WriteLine("RawMaterialID:-" + rm.RawMaterialID+"            RawMaterialName:-" + rm.RawMaterialName + "          Quantity:-" + rm.Quantity + "" + rm.Units + "    Price:-" + rm.Price);
            }
            System.Console.WriteLine("**********************************************************************************");
        }


        /// <summary>
        ///GetRawMaterialByRawMaterialID is a static method used to display the RawMaterial details of Corresponding RawMaterialID
        /// </summary>
        /// <param name="RawMaterialID">Repesents ID of the RawMaterial</param>
        public static void GetRawMaterialByRawMaterialID(string RawMaterialID)
        {
            RawMaterial rawMaterial = new RawMaterial();
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
            
            rawMaterial.RawMaterialID = RawMaterialID;
            RawMaterial a = rawMaterialBusinessLogicLayer.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID);
            System.Console.WriteLine("RawMaterialID:-" + a.RawMaterialID + "            RawMaterialName:-" + a.RawMaterialName + "        Quantity:-" + a.Quantity + a.Units + "        Price:-" + a.Price);
        }

        //we can change the details based on RawMaterialID
        /// <summary>
        /// UpdateRawMaterial is a static Method
        /// </summary>
        /// <param name="RawMaterialID">Repesents ID of the RawMaterial</param>
        public static void UpdateRawMaterial(string RawMaterialID)
        {
            RawMaterial rawMaterial = new RawMaterial();
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
            
            rawMaterial.RawMaterialID = RawMaterialID;
            System.Console.WriteLine("Enter RawMaterialName");
            rawMaterial.RawMaterialName = System.Console.ReadLine();
            System.Console.WriteLine("1.want to change price");
            System.Console.WriteLine("2.want to change Quantity");
            System.Console.WriteLine("enter the choice of changing quantity/price");
            int i = System.Convert.ToInt32(System.Console.ReadLine());
            switch (i)
            {
                case 1:
                    ChangePrice();
                    break;
                case 2:
                    ChangeQuantity();
                    break;
                default:
                    System.Console.WriteLine("entered choice is invalid");
                    break;
            }
            //Local function (it can access variables and parameters of the method)
            void ChangePrice()
            {
                System.Console.WriteLine("Enter the new Price");
                rawMaterial.Price = System.Convert.ToDouble(System.Console.ReadLine());
                rawMaterialBusinessLogicLayer.UpdateRawMaterialPrice(rawMaterial);//calling the UpdateRawMaterialPrice method prsent in businessLogicLayer by using Reference variable
            }
            //Local function (it can access variables and parameters of the method)
            void ChangeQuantity()
            {
                System.Console.WriteLine("Enter new Quantity");
                rawMaterial.Quantity = System.Convert.ToDouble(System.Console.ReadLine());
                rawMaterialBusinessLogicLayer.UpdateRawMaterialQuantity(rawMaterial);//calling the UpdateRawMaterialQuantity method prsent in businessLogicLayer by using Reference variable
            }
        }
    }
}
