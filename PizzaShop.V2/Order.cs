namespace PizzaShop.V2
{
    internal class Order
    {
        public static string name;
        public static bool ordercomplete = true;

        //public static List<string> ordernameList = new List<string>();

        public string Name 
        {
            get
            {              
                return name; 
            } 
            set { name = value; } 
        }



        public static bool NewOrder()
        {
            bool valid = true;
            int chosen;
            string order;
                        
            Cost.itemList.Clear();
            Cost.costList.Clear();

            Console.WriteLine("Would you like to order another pizza?");

            while (valid)
            {
                string choice = Console.ReadLine();
                if (!int.TryParse(choice, out chosen) || chosen <= 0 || chosen > 2)
                {
                    Console.WriteLine("The input is not a valid choice. Please select a choice using 1 for Yes and 2 for No. ");
                }
                //read out the selection
                else if (chosen == 1)
                {
                    Console.WriteLine("Please create your new order.");
                    valid = false;
                }
                else
                {

                    Console.WriteLine("\nYour order is complete");
                    valid = false;
                    ordercomplete = false;
                }
            }
            return ordercomplete;
        }
    }
}
