class Program
{
    static void Main()
    {

        //create object of WareHouse
        WareHouse n = new WareHouse();

        //Create object of Menu
        Menu m = new Menu();
        int Option;

        //do-while loop for menu
        do
        {
            Option = m.Show();
            switch (Option)
            {
                //Add Warehouse
                case 1:
                    {
                        n.Add();
                        //n.SetMangerName();
                        break;
                    }
                //Display Warehouse Details
                case 2:
                    {
                        n.Display();
                        break;
                    }
                //Update Warehouse Details
                case 3:
                    {
                        n.Update();
                        break;
                    }
                //Delete Warehouse
                case 4:
                    {
                        n.Delete();
                        break;
                    }
                case 5:
                    {
                        n.Exit();
                        break;
                    }
                default:
                    break;


            }

            System.Console.ReadKey();
        } while (Option != 6);
    }

}



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


