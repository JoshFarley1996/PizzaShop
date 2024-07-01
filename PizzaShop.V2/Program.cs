//Restaurant Menu System:
//1)Create a user navigation to take orders
//2)User needs to be able to navigate between sub menus (such as appetizers, entrees, and deserts)
//Bonus:
//a) user can add menu items to a cart
//b) user can remove menu items from a cart
//c) user can "checkout" and see the subtotal of all cart items 

//Notes
//This will require creative use of loops and conditional statements
//This will require storing data in lists or arrays (possibly multiple 😜 )
//If you want to get fancy, you can use functions

using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.InteropServices;

static void SelectSize(object[,] selection)
{
    bool valid = true;
    int chosen;


    while (valid)
    {
        string choice = Console.ReadLine();

        if (!int.TryParse(choice, out chosen) || chosen <= 0 || chosen > selection.GetLength(1))
        {
            Console.Write("The input is not a valid choice. Please select a choice using only numbers ");

            for (int i = 1; i <= selection.GetLength(1) - 1; i++)
            {
                Console.Write($" {i}, ");
            }
            Console.Write($" {selection.GetLength(1)}.");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("You chose " + selection[1, chosen - 1] + " for " + selection[0, chosen - 1]);
            valid = false;
        }
    }
}

static void Select(object[] moreselection)
{
    bool valid = true;
    int chosen;


    while (valid)
    {
        string choice = Console.ReadLine();

        if (!int.TryParse(choice, out chosen) || chosen <= 0 || chosen > moreselection.GetLength(0))
        {
            Console.Write("The input is not a valid choice. Please select a choice using only numbers ");

            for (int i = 1; i <= moreselection.GetLength(0) - 1; i++)
            {
                Console.Write($" {i}, ");
            }

            Console.Write($" {moreselection.GetLength(0)}.");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("You chose " + moreselection[chosen - 1]);
            valid = false;
        }
    }
}

static void Prompt(object[] question, string topping)
{
    Console.WriteLine("Please select a choice using only numbers when making a selection.");
    Console.Write($"Please choose a {topping}:");
    for (int i = 0; i < question.GetLength(0); ++i)
    {
        Console.Write($" {i + 1}){question[i]}");
    }
    Console.WriteLine("");
}

string sauce = "Sauce";
string veggie = "Veggie";
string meat = "Meat";



object[,] SizeArray = { { 9.99m, 11.99m, 14.99m, 16.99m }, { "Small", "Medium", "Large", "X-Large" } };
object[] SauceArray = {  "Alfredo", "Marinara", "Buffalo", "None"  };
object[] VeggieArray = { "Mushrooms", "Tomatoes", "Spinage", "Bell Peppers", "Olives", "None"  };
object[] MeatArray = {  "Beef", "Italian", "Chicken", "Pepperoni",  "None" };

Console.WriteLine("Please select a choice using only numbers when making a selection.");
Console.Write("Please choose a size:");
for (int i = 0; i < SizeArray.GetLength(1); ++i)
{
    Console.Write($" {i+1}){SizeArray[1, i]} {SizeArray[0, i]}");
}
Console.WriteLine("");

SelectSize(SizeArray);

Prompt(SauceArray, sauce);
Select(SauceArray);

Prompt(VeggieArray, veggie);
Select(VeggieArray);

Prompt(MeatArray, meat);
Select(MeatArray);


Console.WriteLine("THANK YOU!!!!!");












