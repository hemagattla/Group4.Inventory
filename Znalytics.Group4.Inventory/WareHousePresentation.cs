class Program
{
    static void Main()
    {

       

        //Created object of Menu
        Menu m = new Menu();
        int Option;

        //Created object for WareHouse
        WareHouse n = new WareHouse();

        //Created object for BusinessLogicsLayer
        WareHouseBusinessLayer wbl = new WareHouseBusinessLayer();

        //do-while loop for menu
        do
        {
            Option = m.Show();
            switch (Option)
            {
                //Add Warehouse
                case 1:
                    {
                        System.Console.WriteLine("you chose to enter the warehouse details");
                        System.Console.WriteLine("Enter Manager Name");
                        n.MangerName = System.Console.ReadLine();
                        System.Console.WriteLine("Enter Warehouse Id");
                        n.WarehouseId = System.Console.ReadLine();
                        System.Console.WriteLine("Enter Location Id");
                        n.LocationId = System.Console.ReadLine();
                        System.Console.WriteLine("Enter Location Name");
                        n.LocationName = System.Console.ReadLine();
                        System.Console.WriteLine("Enter Pincode");
                        n.Pincode = System.Console.ReadLine();
                        System.Console.WriteLine("Enter Warehouse capacity");
                        n.WarehouseCapacity = int.Parse(System.Console.ReadLine());

                       




                        break;
                    }
                //Display Warehouse Details
                case 2:
                    {
                        System.Console.WriteLine("you chose to display the warehouse details");
                        System.Console.WriteLine("ManagerName :" + n.MangerName);
                        System.Console.WriteLine("WarehouseId :" + n.WarehouseId);
                        System.Console.WriteLine("LocationId: " + n.LocationId);
                        System.Console.WriteLine("LocationName: " + n.LocationName);
                        System.Console.WriteLine("Pincode: " + n.Pincode);
                        System.Console.WriteLine("WarehouseCapacity: " + n.WarehouseCapacity);
                        System.Console.WriteLine("WarehouseStatus: " + n.WarehouseStatus);
                       
                        break;

                    }
                //Update Warehouse Details
                case 3:
                    {
                        System.Console.WriteLine("you chose to update the warehouse details");

                        break;
                    }
                //Delete Warehouse Details
                case 4:
                    {
                        System.Console.WriteLine("you chose to delete the warehouse details");

                        break;
                    }
                case 5:
                    {
                        System.Console.WriteLine("you chose to exit ");
                        break;
                    }
                default:
                    break;


            }

            System.Console.ReadKey();
        } while (Option != 6);
    }


    // Class for Menu
    public class Menu
    {
        public int Choice;
        public int Show()
        {
            //System.Console.Clear();
            System.Console.WriteLine("Please enter your option:\n\n 1.Add new WareHouse\n 2. Display Details\n 3.Update\n 4.Delete  ");

            Choice = int.Parse(System.Console.ReadLine());
            return Choice;


        }

    }
}


