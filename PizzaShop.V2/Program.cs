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

using PizzaShop.V2;
using System;
// Need to clean up cost display and space out text in prompt for visual clarity
// Need to fix bug where user can be charged for extra None option. 

while (Order.ordercomplete)
{

    Order order = new Order();
    Console.WriteLine("Please enter a name for your order.");
    order.Name = Console.ReadLine();
    Console.WriteLine($"Your order name is {order.Name}.");
    
    //start off the order
    Console.WriteLine("Please select a choice using only numbers when making a selection.");
    
    //Get Size choice for Order
    Size size = new Size();
    Console.WriteLine(size.prompt);
    Size.SelectSize(size.SizeArray);

    //Get Sauce choice for Order
    Sauce sauce = new Sauce();
    Sauce.Prompt(sauce.SauceArray, sauce.sauce);
    Sauce.SelectSauce(sauce.SauceArray);

    //Get Veggie choice for Order
    Veggie veggie = new Veggie();
    Veggie.Prompt(veggie.VeggieArray, veggie.veggie);
    Veggie.SelectVeggie(veggie.VeggieArray);

    //Get Meat choice for Order
    Meat meat = new Meat();
    Meat.Prompt(meat.MeatArray, meat.meat);
    Meat.SelectMeat(meat.MeatArray);
    //decimal sumcost = Size.cost + Sauce.cost + Veggie.cost + Meat.cost;
    Cost.StoreOrder();
    Order.NewOrder();
}

//calculates subtotal, tax, total price
Cost cost = new Cost();
//Cost.OrderRecipt();
Cost.OrderDescription();
Cost.OrderCost(Cost.cost);
//Cost.OrderCost(Cost.cost);

//end of order
Console.WriteLine("THANK YOU!!!!!");












