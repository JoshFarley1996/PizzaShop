namespace PizzaShop.V2
{
    public class Size
    {   
        public string prompt = "Please choose a Size:";
        public object[,] SizeArray = { { 9.99m, 11.99m, 14.99m, 16.99m }, { "Small", "Medium", "Large", "X-Large" } };        
        public static int sizechoice;
                      

        public static int SelectSize(object[,] selection)
        {
            decimal itemcost = 0.00m;
            for (int i = 0; i < selection.GetLength(1); ++i)
            {
                Console.Write($" {i + 1}){selection[1, i]} {selection[0, i]}");
            }
            Console.WriteLine("");
            
            bool valid = true;

            //while choice is not a valid input or selection or no selection has been made
            while (valid)
            {
                string choice = Console.ReadLine();

                int chosen;
                //When inpute is not a choice or a invalid number
                if (!int.TryParse(choice, out chosen) || chosen <= 0 || chosen > selection.GetLength(1))
                {
                    Console.Write("The input is not a valid choice. Please select a choice using only numbers ");

                    //reprint the valid inputs
                    for (int i = 1; i <= selection.GetLength(1) - 1; i++)
                    {
                        Console.Write($" {i}, ");
                    }
                    Console.WriteLine($" {selection.GetLength(1)}.");                    
                }
                //read out the selection and cost
                else
                {
                    Console.WriteLine("You chose " + selection[1, chosen - 1] + " for " + selection[0, chosen - 1]);
                    sizechoice = chosen;
                    Cost.cost += Convert.ToDecimal(selection[0, chosen - 1]);
                    itemcost += Convert.ToDecimal(selection[0, chosen - 1]);
                    Console.WriteLine($"Your total is {Cost.cost}.");
                    valid = false;
                }
                
            }
            Cost.itemList.Add(selection[1, sizechoice - 1]);
            Cost.costList.Add(itemcost);
            return sizechoice;          

        }
    }
}
