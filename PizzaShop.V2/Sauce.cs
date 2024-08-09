namespace PizzaShop.V2
{
    internal class Sauce
    {
        public string sauce = "Sauce";
        //public static decimal cost = 0.00m;

        public string[] SauceArray = { "Alfredo", "Marinara", "Buffalo", "None" };

        public static void Prompt(object[] question, string topping)
        {
            Console.WriteLine("\nPlease select a choice using only numbers when making a selection.");
            Console.Write($"Please choose a {topping}:");
            for (int i = 0; i < question.GetLength(0); ++i)
            {
                Console.Write($" {i + 1}){question[i]}");
            }
            Console.WriteLine("");
        }

        public static void SelectSauce(string[] moreselection)
        {
            bool valid = true;
            bool extravalid = true;
            int chosen;
            int otherchosen;
            int amount;

            //while choice is not a valid input or selection or no selection has been made
            while (valid)
            {
                decimal itemcost = 0.99m;
                string choice = Console.ReadLine();

                if (!int.TryParse(choice, out chosen) || chosen <= 0 || chosen > moreselection.GetLength(0))
                {
                    Console.Write("The input is not a valid choice. Please select a choice using only numbers ");

                    //reprint the valid inputs
                    for (int j = 1; j <= moreselection.GetLength(0) - 1; j++)
                    {
                        Console.Write($" {j}, ");
                    }

                    Console.WriteLine($" {moreselection.GetLength(0)}.");
                }
                //read out the selection
                else
                {
                    Console.WriteLine("You chose " + moreselection[chosen - 1]);
                    valid = false;


                    while (extravalid)
                    {
                        Console.WriteLine($"Would you like extra {moreselection[chosen - 1]} for $0.99 1) Yes 2) No.");
                        string otherchoice = Console.ReadLine();

                        if (!int.TryParse(otherchoice, out otherchosen) || otherchosen <= 0 || otherchosen > 2)
                        {
                            Console.WriteLine("The input is not a valid choice. Please select a choice using only numbers 1 and 2.");
                        }
                        else if (otherchosen == 1)
                        {
                            Console.WriteLine($"You selected extra {moreselection[chosen - 1]} for $0.99.");
                            Cost.cost += 0.99m;
                            Cost.itemList.Add($"Extra {moreselection[chosen - 1]}");
                            Cost.costList.Add(itemcost);
                            Console.WriteLine($" Your total is {Cost.cost}.");
                            extravalid = false;
                        }
                        else
                        {
                            Console.WriteLine($"No extra {moreselection[chosen - 1]}");
                            Cost.itemList.Add(moreselection[chosen - 1]);
                            Cost.costList.Add("No extra");
                            extravalid = false;
                        }
                    }
                }
            }                
            
        }
    }
}
