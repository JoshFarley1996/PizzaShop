using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.V2
{
    //Need to change this class to Prompt and make method that puts prompt in for each selection
    public class Cost
    {
        public static decimal cost = 0.00m;

        public static List<object> costList = new List<object>();
        public static List<object> itemList = new List<object>();

        public static void OrderCost(decimal cost)
        {
            decimal taxprice = 0.00m;
            decimal taxrate = 0.0825m;
            decimal totalcost = 0.00m;

            taxprice = Math.Round(cost * taxrate,2);          
            totalcost = Math.Round(cost + taxprice,2);

            Console.WriteLine(Order.name);

            foreach (object item in itemList.Zip(costList, (item, cost) => $"{item}: {cost}"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Order Price: {cost}");
            Console.WriteLine($"Taxes: {taxprice}");
            Console.WriteLine($"Total Cost: {totalcost}");           

        }
    
    }
}
