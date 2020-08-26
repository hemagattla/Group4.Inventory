﻿using System;
using System.Collections.Generic;

using Znalytics.Group4.Inventory.RawMaterial.Entities;
using Znalytics.Group4.Inventory.RawMaterial.BusinessLogicLayer;

namespace Znalytics.Group4.Inventory.RawMaterial.PresentationLayer
{
    class RawMaterialPresentationLayer
    {
        static void Main()
        {
            System.Console.WriteLine("========================Raw Material==========================");
            int select;
            bool q;
            string i;
            do
            {
                System.Console.WriteLine("1.Add Raw Material");
                System.Console.WriteLine("2.Delete Raw Material");
                System.Console.WriteLine("3.view Raw Material");
                System.Console.WriteLine("4.Update Raw Material");
                q = int.TryParse(System.Console.ReadLine(), out select);
                if (q == true)
                {
                    switch (select)
                    {
                        case 1:
                            AddRawMaterial();
                            break;
                        case 2:
                            DeleteRawMaterial();
                            break;
                        case 3:
                            ViewRawMaterial();
                            break;
                        case 4:
                            UpdateRawMaterial();
                            break;
                    }

                }
                else
                {
                    System.Console.WriteLine("Please Enter the only digits");
                }
                System.Console.WriteLine("u want to add Raw Material (Yes/No)");
                i = System.Console.ReadLine();
            } while (i == "Yes");
        }
        public static void AddRawMaterial()
        {
            RawMaterials rawMaterial = new RawMaterials();
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
            System.Console.WriteLine("Enter RawMaterialName");
            rawMaterial.RawMaterialName = System.Console.ReadLine();
            System.Console.WriteLine("Enter RawMaterialID");
            rawMaterial.RawMaterialID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Quantity");
            rawMaterial.Quantity = System.Console.ReadLine();
            System.Console.WriteLine("Enter units");
            rawMaterial.Units = System.Console.ReadLine();
            System.Console.WriteLine("Enter Price");
            rawMaterial.Price = System.Convert.ToDouble(System.Console.ReadLine());
            rawMaterialBusinessLogicLayer.AddRawMaterial();
        }
        public static void DeleteRawMaterial()
        {
            RawMaterials rawMaterial = new RawMaterials();
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
     
            System.Console.WriteLine("Enter RawMaterialName");
            rawMaterial.RawMaterialName = System.Console.ReadLine();
            System.Console.WriteLine("Enter RawMaterialID");
            rawMaterial.RawMaterialID = System.Console.ReadLine();
            System.Console.WriteLine("Enter Quantity");
            rawMaterial.Quantity = System.Console.ReadLine();
            System.Console.WriteLine("Enter units");
            rawMaterial.Units = System.Console.ReadLine();
            System.Console.WriteLine("Enter Price");
            rawMaterial.Price = System.Convert.ToDouble(System.Console.ReadLine());
            rawMaterialBusinessLogicLayer.DeleteRawMaterial();
        }
        public static void ViewRawMaterial()
        {
            
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
            List<RawMaterials> rms = rawMaterialBusinessLogicLayer.GetRawMaterial();

            foreach (RawMaterial rm in rms)
            {
                System.Console.WriteLine( rm.RawMaterialName + " , " + rm.RawMaterialID + " , " + rm.Quantity + "" + rm.Units + " , " + rm.Price);
            }
        }
        public static void UpdateRawMaterial()
        {
            RawMaterials rawMaterial = new RawMaterials();
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
     
            System.Console.WriteLine("Enter RawMaterialName");
            rawMaterial.RawMaterialName = System.Console.ReadLine();
            System.Console.WriteLine("Enter RawMaterialID");
            rawMaterial.RawMaterialID = System.Console.ReadLine();
           
            System.Console.WriteLine("1.want to change Quantity");
            System.Console.WriteLine("2.want to change price");
            System.Console.WriteLine("enter the choice of changing quantity/price");
            int i=System.Convert.ToInt32(System.Console.ReadLine());
            switch(i)
            {
                case 1:ChangePrice();
                    break;
                case 2:ChangeQuantity();
                    break;
                default:System.Console.WriteLine("entered choice is invalid");
                    break;
            }
            
          
            
        }
        public static void ChangePrice()
        {
            RawMaterials rawMaterial = new RawMaterials();
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
            System.Console.WriteLine("Enter the new Price");
            rawMaterial.Price = System.Convert.ToDouble(System.Console.ReadLine());
        }
        public static void ChangeQuantity()
        {
            RawMaterials rawMaterial = new RawMaterials();
            RawMaterialBusinessLogicLayer rawMaterialBusinessLogicLayer = new RawMaterialBusinessLogicLayer();
            System.Console.WriteLine("Enter Quantity");
            rawMaterial.Quantity = System.Console.ReadLine();
        }
    }
    
}