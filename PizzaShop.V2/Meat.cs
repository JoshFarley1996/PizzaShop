namespace PizzaShop.V2
{
    internal class Meat
    {
        public string meat = "Meat";
        
        public object[] MeatArray = { "Beef", "Italian", "Chicken", "Pepperoni", "None" };
        public static void Prompt(object[] question, string topping)
        {
            Console.WriteLine("\nPlease select a choice using only numbers when making a selection.");
            Console.Write($"Please choose a {topping}:");
            for (int i = 0; i < question.GetLength(0); ++i)
            {
                Console.Write($" {i + 1}){question[i]}");
            }            
        }

        public static void SelectMeat(object[] moreselection)
        {
            bool valid = true;            
            int chosen;
            int otherchosen;
            int amount;
            decimal itemcost = 0.99m;

            //while choice is not a valid input or selection or no selection has been made
            while (valid)
            {
                //update amount to differ between veggie and meat and set how much of each for each pizza size
                if (Size.sizechoice <= 2)
                {
                    amount = 1;
                    Console.WriteLine($"\nYou get 1 meat topping.");
                }
                else
                {
                    amount = 2;
                    Console.WriteLine($"\nYou get 2 meat toppings.");
                }


                for (int i = 1; i <= amount; i++)
                {
                    bool extravalid = true;

                    Console.WriteLine("Please make a selection.");
                    string choice = Console.ReadLine();

                    if (!int.TryParse(choice, out chosen) || chosen <= 0 || chosen > moreselection.GetLength(0))
                    {
                        Console.Write("The input is not a valid choice. Please select a choice using only numbers ");

                        //reprint the valid inputs
                        for (int j = 1; j <= moreselection.GetLength(0) - 1; j++)
                        {
                            Console.Write($" {j}, ");
                        }
                        i--;

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
                                Console.WriteLine($"You selected extra {moreselection[chosen - 1]} for $0.99.");        //Need to give access to cost
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
}
