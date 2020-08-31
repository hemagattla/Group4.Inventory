using System.Collections.Generic;//NameSpace of Collections
using Znalytics.Group4.Inventory.ProductRawMaterialModule.Entities;
using Znalytics.Group4.Inventory.RawMaterialModule.BusinessLogicLayer;//NameSpace of rawmaterial BussinessLogicLayer
using Znalytics.Group4.Inventory.RawMaterialModule.Entities;
using Znalytics.Inventory.ProductModule.BusinessLogicLayer;
using Znalytics.Group4.Inventory.ProductRawMaterialModule.BusinessLogicLayer;
using Znalytics.Inventory.ProductModule.Entitie;
using System;
using Newtonsoft.Json;


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
                        System.Console.WriteLine("4.Update Quantity of Raw Material");
                        System.Console.WriteLine("5.GetProductRawmaterial Details By ProductID");
                        System.Console.WriteLine("6.GetDetailsUsingOriderBy");
                        System.Console.WriteLine("7.Exit");
                        System.Console.Write("enter the choice:-");
                    q = int.TryParse(System.Console.ReadLine(), out select);//Trypase:- we are converting string to in
                    System.Console.Write("\n");
                    System.Console.WriteLine("=======================================================");
                       

                    if (q == true)
                    {
                        //RawMaterial rawMaterial = new RawMaterial();
                        //Product product = new Product();
                        //ProductBusiness productBusiness = new ProductBusiness();
                        //RawMaterialBusinessLogicLayer pb = new RawMaterialBusinessLogicLayer();
                        //ProductRawMaterial productRawMaterial = new ProductRawMaterial();
                        //ProductRawMaterialBusinessLogicLayer prbl = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
                        
                        switch (select)
                        {
                            case 1:AddRawMaterialToProduct();
                                break;
                            case 2:DeleteRawMaterialOfProduct();
                                break;

                            case 3:GetProductRawMaterial();
                                break;
                            case 4:
                                UpdateQuantityOfProduct();
                                break;
                            case 5: GetDetailsByProductID();
                                break;
                            case 6:
                                GetDetailsUsingOrderBy();
                                System.Console.WriteLine("1st preference to productID , then RawMaterialID and then RwmaterialName");

                                break;
                            default:System.Console.WriteLine("enter the correct option");
                                break;
                        
                        }

                    }
                    else
                    {
                        throw new Exception("Please Enter the only digits");
                    }

                   } while (select != 7);
                }
                catch (Exception ex)
                {
                System.Console.WriteLine(ex.Message);
                }

        }
        public static void AddRawMaterialToProduct()
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
            ProductRawMaterialBusinessLogicLayer prbl = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            System.Console.WriteLine("enter ProductID (ProductID must Starts With *PID*)");
            productRawMaterial.ProductID = System.Console.ReadLine();
            Product a = prbl.GetProductByProductID(productRawMaterial.ProductID);
            if (a != null)
            {
                //Product a = prbl.GetProductByProductID(productRawMaterial.ProductID);
                productRawMaterial.ProductID = a.ProductID;
                System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
                productRawMaterial.RawMaterialID = System.Console.ReadLine();
                RawMaterial prm = prbl.GetRawMaterialByRawMaterialID(productRawMaterial.RawMaterialID);
                if (prm != null)
                {
                   // RawMaterial prm = prbl.GetRawMaterialByRawMaterialID(productRawMaterial.RawMaterialID);
                    productRawMaterial.RawMaterialID = prm.RawMaterialID;
                    productRawMaterial.RawMaterialName = prm.RawMaterialName;
                    if (prbl.GetDetailsByProductIDAndRawMaterialID(productRawMaterial) == null)
                    {
                        System.Console.WriteLine("Enter the Quantity");
                        productRawMaterial.Quantity = System.Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Enter the Units");
                        productRawMaterial.Units = System.Console.ReadLine();
                        prbl.AddRawMaterialToProduct(productRawMaterial);
                    }
                    else
                    {
                        System.Console.WriteLine("*************** Entered all ready exits ********************");
                    }
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
        }
         public static void DeleteRawMaterialOfProduct()
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
            ProductRawMaterialBusinessLogicLayer prbl = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            System.Console.WriteLine("enter ProductID (ProductID must Starts With *PID*)");
            productRawMaterial.ProductID = System.Console.ReadLine();
            System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
            productRawMaterial.RawMaterialID = System.Console.ReadLine();
            if(prbl.GetProductRawMaterialByID(productRawMaterial.ProductID, productRawMaterial.RawMaterialID) != null)
            {
                prbl.DeleteRawMaterialOfProduct(productRawMaterial);
                System.Console.WriteLine("******************* Successfully deleted RawMaterial Details from ProductID  " + productRawMaterial.ProductID + "  ************** ");
            }
            else
            {
                System.Console.WriteLine("**************entered ProductID  " + productRawMaterial.ProductID + " and RawMaterialID  " + productRawMaterial.RawMaterialID + "  doesn't exists. Pls Try again*************");
            }
         }
        public static void GetProductRawMaterial()
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
            ProductRawMaterialBusinessLogicLayer prbl = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            List<ProductRawMaterial> rms = prbl.GetProductRawMaterial();// call the GetRawMaterial method with no arguments in the BusinessLogicLayer by using Refernce Variable
            System.Console.WriteLine("**********************************************************************************");
            foreach (ProductRawMaterial rm in rms)//to print the list
            {
                System.Console.WriteLine("ProductID:-"+rm.ProductID+"           RawMaterialID:-" +rm.RawMaterialID  + "            RawMaterialName:-" + rm.RawMaterialName + "          Quantity:-" + rm.Quantity + "" + rm.Units );
            }
            System.Console.WriteLine("**********************************************************************************");
        }
        public static void UpdateQuantityOfProduct()
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
            ProductRawMaterialBusinessLogicLayer prbl = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            System.Console.WriteLine("enter ProductID (ProductID must Starts With *PID*)");
            productRawMaterial.ProductID = System.Console.ReadLine();
            System.Console.WriteLine("enter RawMaterialID (RawMaterialID must Starts With *RMID* and length should be *6*)");
            productRawMaterial.RawMaterialID = System.Console.ReadLine();
            if (prbl.GetProductRawMaterialByID(productRawMaterial.ProductID,productRawMaterial.RawMaterialID) != null)
            {  
                System.Console.WriteLine("Enter the Quantity");
                productRawMaterial.Quantity = System.Convert.ToDouble(System.Console.ReadLine());
                prbl.UpdateQuantityOfProduct(productRawMaterial);
                System.Console.WriteLine("******************* Successfully added RawMaterial Details to ProductID  " + productRawMaterial.ProductID + " ************** ");
            }
            else
            {
                System.Console.WriteLine("**************entered ProductID  " + productRawMaterial.ProductID + " and RawMaterialID  " + productRawMaterial.RawMaterialID+"  doesn't exists. Pls Try again*************");
            }
        }
       
        public static void GetDetailsByProductID()
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
            System.Console.WriteLine("enter ProductID (ProductID must Starts With *PID*)");
            productRawMaterial.ProductID = System.Console.ReadLine();
            System.Console.WriteLine("ProductID:-" +productRawMaterial.ProductID);
            ProductRawMaterialBusinessLogicLayer prbl = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
           List<ProductRawMaterial> prm= prbl.GetDetailsByProductID(productRawMaterial);
            
            foreach (ProductRawMaterial rm in prm)//to print the list
            {
                System.Console.WriteLine("RawMaterialID:-" + rm.RawMaterialID + "            RawMaterialName:-" + rm.RawMaterialName + "          Quantity:-" + rm.Quantity + "" + rm.Units);
            }
            System.Console.WriteLine("**********************************************************************************");
        }
        
        public static void GetDetailsUsingOrderBy()
        {
            ProductRawMaterial productRawMaterial = new ProductRawMaterial();
            ProductRawMaterialBusinessLogicLayer prbl = new ProductRawMaterialBusinessLogicLayer();//creating object of businessLogicLayer class
            List<ProductRawMaterial> rms = prbl.GetDetailsUsingOrderBy();// call the GetRawMaterial method with no arguments in the BusinessLogicLayer by using Refernce Variable
            System.Console.WriteLine("**********************************************************************************");
            foreach (ProductRawMaterial rm in rms)//to print the list
            {
                System.Console.WriteLine("ProductID:-" + rm.ProductID + "           RawMaterialID:-" + rm.RawMaterialID + "            RawMaterialName:-" + rm.RawMaterialName + "          Quantity:-" + rm.Quantity + "" + rm.Units);
            }
            System.Console.WriteLine("**********************************************************************************");
        }

    }
}
