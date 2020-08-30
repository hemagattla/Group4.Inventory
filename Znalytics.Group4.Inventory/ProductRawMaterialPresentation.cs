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
        public void ProductRawMaterialMenu()
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
                        //RawMaterial rawMaterial = new RawMaterial();
                        //Product product = new Product();
                        //ProductBusiness productBusiness = new ProductBusiness();
                        //RawMaterialBusinessLogicLayer pb = new RawMaterialBusinessLogicLayer();
                        ProductRawMaterial productRawMaterial = new ProductRawMaterial();
                        ProductRawMaterialBusinessLogicLayer prbl = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
                        
                        switch (select)
                        {
                            case 1:
                                System.Console.WriteLine("enter ProductID (ProductID must Starts With *PID*)");
                                productRawMaterial.ProductID = System.Console.ReadLine();
                               
                                if (prbl.GetProductByProductID(productRawMaterial.ProductID) != null)
                                {
                                    Product a = prbl.GetProductByProductID(productRawMaterial.ProductID);
                                    productRawMaterial.ProductID = a.ProductID;
                                    System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
                                    productRawMaterial.RawMaterialID = System.Console.ReadLine();
                                    if (prbl.GetRawMaterialByRawMaterialID(productRawMaterial.RawMaterialID) != null)
                                    {
                                        RawMaterial prm = prbl.GetRawMaterialByRawMaterialID(productRawMaterial.RawMaterialID);
                                        productRawMaterial.RawMaterialID = prm.RawMaterialID;
                                        productRawMaterial.RawMaterialName = prm.RawMaterialName;
                                        AddRawMaterialToProduct(productRawMaterial.ProductID, productRawMaterial.RawMaterialID, productRawMaterial.RawMaterialName);
                                        System.Console.WriteLine("******************* Successfully added RawMaterial Details to ProductID  " + productRawMaterial.ProductID + " ************** ");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("**************entered RawMaterialID " + productRawMaterial.RawMaterialID + " does not exists. Pls Try again*************");
                                    }
                                }

                                else
                                {
                                    System.Console.WriteLine("**************entered ProductID  " + productRawMaterial.ProductID + "  doesn't exists. Pls Try again*************");
                                }
                                break;
                            case 2:
                                System.Console.WriteLine("enter ProductID (ProductID must Starts With *PID*)");
                                productRawMaterial.ProductID = System.Console.ReadLine();
                                
                                if (prbl.GetProductByProductID(productRawMaterial.ProductID) != null)
                                {
                                    productRawMaterial.ProductID = productRawMaterial.ProductID;
                                    System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
                                    productRawMaterial.RawMaterialID = System.Console.ReadLine();
                                    if (prbl.GetRawMaterialByRawMaterialID(productRawMaterial.RawMaterialID) != null)
                                    {
                                        RawMaterial prm = (prbl.GetRawMaterialByRawMaterialID(productRawMaterial.RawMaterialID));
                                        productRawMaterial.RawMaterialID = prm.RawMaterialID;
                                        productRawMaterial.RawMaterialID = prm.RawMaterialName;
                                        DeleteRawMaterialOfProduct(productRawMaterial.ProductID, productRawMaterial.RawMaterialID, productRawMaterial.RawMaterialName);
                                        System.Console.WriteLine("******************* Successfully deleted RawMaterial Details from ProductID  " + productRawMaterial.ProductID + "  ************** ");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("**************entered RawMaterialID  " + productRawMaterial.RawMaterialID + "  does not exists. Pls Try again*************");
                                    }
                                }

                                else
                                {
                                    System.Console.WriteLine("**************entered ProductID  " + productRawMaterial.ProductID + "  doesn't exists. Pls Try again*************");
                                }
                                break;

                            case 3:
                                GetProductRawMaterial();
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
                                System.Console.WriteLine("enter ProductID (ProductID must Starts With *PID*)");
                                productRawMaterial.ProductID = System.Console.ReadLine();
                                
                                if (prbl.GetProductByProductID(productRawMaterial.ProductID) != null)
                                {
                                    productRawMaterial.ProductID = productRawMaterial.ProductID;
                                    System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
                                    productRawMaterial.RawMaterialID = System.Console.ReadLine();
                                    if (prbl.GetRawMaterialByRawMaterialID(productRawMaterial.RawMaterialID) != null)
                                    {
                                        RawMaterial prm =(prbl.GetRawMaterialByRawMaterialID(productRawMaterial.RawMaterialID));
                                        productRawMaterial.RawMaterialID = prm.RawMaterialID;
                                        productRawMaterial.RawMaterialID = prm.RawMaterialName;
                                        UpdateRawMaterialOfProduct(productRawMaterial.ProductID, productRawMaterial.RawMaterialID, productRawMaterial.RawMaterialName);
                                        System.Console.WriteLine("******************* U Can see the of Product  ************** ");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("**************entered RawMaterialID  " + productRawMaterial.RawMaterialID + "  does not exists. Pls Try again*************");
                                    }
                                }

                                else
                                {
                                    System.Console.WriteLine("**************entered ProductID" + productRawMaterial.ProductID + "doesn't exists. Pls Try again*************");
                                }
                                break;
                            case 5:
                                System.Console.WriteLine("enter ProductID (ProductID must Starts With *PID*)");
                                productRawMaterial.ProductID = System.Console.ReadLine();
                                if (prbl.GetProductByProductID(productRawMaterial.ProductID) != null)
                                {
                                    productRawMaterial.ProductID = productRawMaterial.ProductID;
                                    GetDetailsByProductID(productRawMaterial.ProductID);
                                    System.Console.WriteLine("******************* U Can see the of Product  ************** ");
                                }

                                else
                                {
                                    System.Console.WriteLine("**************entered ProductID" + productRawMaterial.ProductID + "doesn't exists. Pls Try again*************");
                                }

                                break;
                            case 6:
                                GetDetailsUsingOriderBy();
                                System.Console.WriteLine("1st preference tp productID , then RawMaterialID and then RwmaterialName");

                                break;
                            default:System.Console.WriteLine("enter the correct option");
                                break;
                        
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Please Enter the only digits");
                    }

                   } while (select != 7);
                }
                catch (Exception ex)
                {
                System.Console.WriteLine(ex.Message);
                }
           
        }
        public static void AddRawMaterialToProduct(string ProductID, string RawMaterialID, string RawMaterialName)
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
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
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
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
        public static void GetProductRawMaterial()
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
            ProductRawMaterialBusinessLogicLayer productRawMaterialBusinessLogicLayer = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            List<ProductRawMaterial> rms = productRawMaterialBusinessLogicLayer.GetProductRawMaterial();// call the GetRawMaterial method with no arguments in the BusinessLogicLayer by using Refernce Variable
            System.Console.WriteLine("**********************************************************************************");
            foreach (ProductRawMaterial rm in rms)//to print the list
            {
                System.Console.WriteLine("ProductID:-"+ productRawMaterial.ProductID+"           RawMaterialID:-" + productRawMaterial.RawMaterialID  + "            RawMaterialName:-" + productRawMaterial.RawMaterialName + "          Quantity:-" + rm.Quantity + "" + rm.Units );
            }
            System.Console.WriteLine("**********************************************************************************");
        }
        public static void UpdateRawMaterialOfProduct(string ProductID, string RawMaterialID, string RawMaterialName)
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
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
        public static void GetDetailsByProductID(string ProductID)
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
            productRawMaterial.ProductID = ProductID;
            System.Console.WriteLine("ProductID:-" + ProductID);
            ProductRawMaterialBusinessLogicLayer productRawMaterialBusinessLogicLayer = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            List<ProductRawMaterial> prm= productRawMaterialBusinessLogicLayer.GetDetailsByProductID(productRawMaterial);
            
            foreach (ProductRawMaterial rm in prm)//to print the list
            {
                System.Console.WriteLine("RawMaterialID:-" + productRawMaterial.RawMaterialID + "            RawMaterialName:-" + productRawMaterial.RawMaterialName + "          Quantity:-" + rm.Quantity + "" + rm.Units);
            }
            System.Console.WriteLine("**********************************************************************************");
        }
        
        public static void GetDetailsUsingOriderBy()
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
            ProductRawMaterialBusinessLogicLayer productRawMaterialBusinessLogicLayer = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            List<ProductRawMaterial> rms = productRawMaterialBusinessLogicLayer.GetProductRawMaterial();// call the GetRawMaterial method with no arguments in the BusinessLogicLayer by using Refernce Variable
            System.Console.WriteLine("**********************************************************************************");
            foreach (ProductRawMaterial rm in rms)//to print the list
            {
                System.Console.WriteLine("ProductID:-" + productRawMaterial.ProductID + "           RawMaterialID:-" + productRawMaterial.RawMaterialID + "            RawMaterialName:-" + productRawMaterial.RawMaterialName + "          Quantity:-" + rm.Quantity + "" + rm.Units);
            }
            System.Console.WriteLine("**********************************************************************************");
        }

    }
}
