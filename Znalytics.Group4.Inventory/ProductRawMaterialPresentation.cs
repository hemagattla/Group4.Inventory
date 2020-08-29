/*using System;
using System.Collections.Generic;
using System.Linq;
using Znalytics.Group4.Inventory.RawMaterialModule.EntityLayer;

namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.PresentationLayer
{
    class ProductRawMaterialPresentation
    {
        static void Main()
        {
           
                System.Console.WriteLine("========================Product Raw Material==========================");
                int select;//local varialbe
                bool q;//local variable
                try
                {
                    do
                    {
                        System.Console.WriteLine("1.Add Raw Material Details into Product");
                        System.Console.WriteLine("2.Delete Raw Material Details from the Product");
                        System.Console.WriteLine("3.view Raw Material Details of Product");
                        System.Console.WriteLine("4.Update Raw Material of the product");
                        System.Console.WriteLine("5.GetProductRawmaterial Details By ProductID");
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

            System.Console.Read();

        }
              
            }
        }
    }
}
*/