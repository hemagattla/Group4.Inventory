using System.Collections.Generic;//NameSpace of Collections
using Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities;
using Znalytics.Group4.Inventory.RawMaterialModule.BusinessLogicLayer;//NameSpace of rawmaterial BussinessLogicLayer
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.Entitie;
using System;

namespace Znalytics.Group4.Inventory.ProductRawMaterialModule.PresentationLayer
{
    class ProductRawMaterialPresentation
    {
        public void ProductRawMaterial()
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
                        RawMaterial rawMaterial = new RawMaterial();
                        Product product = new Product();
                        ProductBusiness productBusiness = new ProductBusiness();
                        RawMaterialBusinessLogicLayer pb = new RawMaterialBusinessLogicLayer();
                        ProductRawMaterials productRawMaterial = new ProductRawMaterials();
                        ProductRawMaterialBusinessLogicLayer productRawMaterialBusinessLogicLayer = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
                        System.Console.WriteLine("enter ProductID (ProductID must Starts With *PID*)");
                        productRawMaterial.RawMaterialID = System.Console.ReadLine();
                        System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
                        productRawMaterial.RawMaterialID = System.Console.ReadLine();
                        switch (select)
                        {
                            case 1:
                                if (productBusiness.GetProductByProductID(product.ProductID) != null)
                                {
                                    productRawMaterial.ProductID = product.ProductID;
                                    if (pb.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID) != null)
                                    {
                                        RawMaterial prm = pb.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID);
                                        productRawMaterial.RawMaterialID = prm.RawMaterialID;
                                        productRawMaterial.RawMaterialName = prm.RawMaterialName;
                                        AddRawMaterialToProduct(productRawMaterial.ProductID, productRawMaterial.RawMaterialID, productRawMaterial.RawMaterialName);
                                        System.Console.WriteLine("******************* Successfully added RawMaterial Details to ProductID  " + productRawMaterial.ProductID + " ************** ");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("**************entered RawMaterialID " + rawMaterial.RawMaterialID + " does not exists. Pls Try again*************");
                                    }
                                }

                                else
                                {
                                    System.Console.WriteLine("**************entered ProductID  " + productRawMaterial.ProductID + "  doesn't exists. Pls Try again*************");
                                }
                                break;
                            case 2:
                                if (productBusiness.GetProductByProductID(product.ProductID) != null)
                                {
                                    productRawMaterial.ProductID = product.ProductID;
                                    if (pb.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID) != null)
                                    {
                                        RawMaterial prm = pb.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID);
                                        productRawMaterial.RawMaterialID = prm.RawMaterialID;
                                        productRawMaterial.RawMaterialID = prm.RawMaterialName;
                                        DeleteRawMaterialOfProduct(productRawMaterial.ProductID, productRawMaterial.RawMaterialID, productRawMaterial.RawMaterialName);
                                        System.Console.WriteLine("******************* Successfully deleted RawMaterial Details from ProductID  " + productRawMaterial.ProductID + "  ************** ");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("**************entered RawMaterialID  " + rawMaterial.RawMaterialID + "  does not exists. Pls Try again*************");
                                    }
                                }

                                else
                                {
                                    System.Console.WriteLine("**************entered ProductID  " + productRawMaterial.ProductID + "  doesn't exists. Pls Try again*************");
                                }
                                break;

                            case 3:
                                GetRawMaterialByRawMaterialID();
                                /*if (productBusiness.GetProductByProductID(product.ProductID) != null)
                                {
                                    productRawMaterial.ProductID = product.ProductID;
                                    if (pb.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID) != null)
                                    {
                                        RawMaterial prm = pb.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID);
                                        productRawMaterial.RawMaterialID = prm.RawMaterialID;
                                        productRawMaterial.RawMaterialID = prm.RawMaterialName;
                                        ViewRawMaterialOfProduct(productRawMaterial.ProductID, productRawMaterial.RawMaterialID, productRawMaterial.RawMaterialName);
                                        System.Console.WriteLine("******************* Successfully deleted RawMaterial Details from ProductID" + productRawMaterial.ProductID + " ************** ");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("**************entered RawMaterialID " + rawMaterial.RawMaterialID + " does not exists. Pls Try again*************");
                                    }
                                }

                                else
                                {
                                    System.Console.WriteLine("**************entered ProductID" + productRawMaterial.ProductID + "doesn't exists. Pls Try again*************");
                                }*/
                                break;
                            case 4:
                                if (productBusiness.GetProductByProductID(product.ProductID) != null)
                                {
                                    productRawMaterial.ProductID = product.ProductID;
                                    if (pb.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID) != null)
                                    {
                                        RawMaterial prm = pb.GetRawMaterialByRawMaterialID(rawMaterial.RawMaterialID);
                                        productRawMaterial.RawMaterialID = prm.RawMaterialID;
                                        productRawMaterial.RawMaterialID = prm.RawMaterialName;
                                        UpdateRawMaterialOfProduct(productRawMaterial.ProductID, productRawMaterial.RawMaterialID, productRawMaterial.RawMaterialName);
                                        System.Console.WriteLine("******************* U Can see the of Product  ************** ");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("**************entered RawMaterialID  " + rawMaterial.RawMaterialID + "  does not exists. Pls Try again*************");
                                    }
                                }

                                else
                                {
                                    System.Console.WriteLine("**************entered ProductID" + productRawMaterial.ProductID + "doesn't exists. Pls Try again*************");
                                }
                                break;
                           /* case 5:
                                if (productBusiness.GetProductByProductID(product.ProductID) != null)
                                {
                                    productRawMaterial.ProductID = product.ProductID;
                                    GetDetailsByProductID(productRawMaterial.ProductID);
                                }

                                break;*/
                            default:System.Console.WriteLine("enter the correct option");
                                break;
                        
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Please Enter the only digits");
                    }

                   } while (select != 5);
                }
                catch (Exception ex)
                {
                System.Console.WriteLine(ex.Message);
                }
        }
        public static void AddRawMaterialToProduct(string ProductID, string RawMaterialID, string RawMaterialName)
        {
            ProductRawMaterials productRawMaterial = new ProductRawMaterials();
            ProductRawMaterialBusinessLogicLayer productRawMaterialBusinessLogicLayer = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            productRawMaterial.ProductID = ProductID;
            productRawMaterial.RawMaterialID =RawMaterialID;
            productRawMaterial.RawMaterialName = RawMaterialName;
            System.Console.WriteLine("Enter the Quantity");
            productRawMaterial.Quantity = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Enter the Units");
            productRawMaterial.Units = System.Console.ReadLine();
            productRawMaterialBusinessLogicLayer.AddRawMaterialToProduct(productRawMaterial);
        }
        public static void DeleteRawMaterialOfProduct(string ProductID, string RawMaterialID, string RawMaterialName)
        {
            ProductRawMaterials productRawMaterial = new ProductRawMaterials();
            ProductRawMaterialBusinessLogicLayer productRawMaterialBusinessLogicLayer = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            productRawMaterial.ProductID = ProductID;
            productRawMaterial.RawMaterialID = RawMaterialID;
            productRawMaterial.RawMaterialName = RawMaterialName;
            //System.Console.WriteLine("Enter the Quantity");
            //productRawMaterial.Quantity = System.Convert.ToDouble(System.Console.ReadLine());
            //System.Console.WriteLine("Enter the Units");
            //productRawMaterial.Units = System.Console.ReadLine();
            productRawMaterialBusinessLogicLayer.DeleteRawMaterialOfProduct(productRawMaterial);
        }
        public static void GetRawMaterialByRawMaterialID()
        {
            ProductRawMaterials productRawMaterial = new ProductRawMaterials();
            ProductRawMaterialBusinessLogicLayer productRawMaterialBusinessLogicLayer = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            List<ProductRawMaterials> rms = productRawMaterialBusinessLogicLayer.GetRawMaterialByRawMaterialID();// call the GetRawMaterial method with no arguments in the BusinessLogicLayer by using Refernce Variable
            System.Console.WriteLine("**********************************************************************************");
            foreach (ProductRawMaterials rm in rms)//to print the list
            {
                System.Console.WriteLine("ProductID:-"+ productRawMaterial.ProductID+"           RawMaterialID:-" + productRawMaterial.RawMaterialID  + "            RawMaterialName:-" + productRawMaterial.RawMaterialName + "          Quantity:-" + rm.Quantity + "" + rm.Units );
            }
            System.Console.WriteLine("**********************************************************************************");
        }
        public static void UpdateRawMaterialOfProduct(string ProductID, string RawMaterialID, string RawMaterialName)
        {
            ProductRawMaterials productRawMaterial = new ProductRawMaterials();
            ProductRawMaterialBusinessLogicLayer productRawMaterialBusinessLogicLayer = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            productRawMaterial.ProductID = ProductID;
            productRawMaterial.RawMaterialID = RawMaterialID;
            productRawMaterial.RawMaterialName = RawMaterialName;
            System.Console.WriteLine("Enter the new Quantity");
            productRawMaterial.Quantity = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Enter the Units");
            productRawMaterial.Units = System.Console.ReadLine();
            productRawMaterialBusinessLogicLayer.UpdateRawMaterialOfProduct(productRawMaterial);
        }
        /*public static void GetDetailsByProductID(productRawMaterial.ProductID)
        {

        }*/

    }
}
