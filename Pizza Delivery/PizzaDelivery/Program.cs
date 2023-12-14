Console.WriteLine("Welcome to the pizza delivery service");

var smallPizzaValues = new Dictionary<string, int>
{
    {"base", 15},
    {"pepperoni", 2},
    {"cheese", 1}
};

var mediumPizzaValues = new Dictionary<string, int>
{
    {"base", 20},
    {"pepperoni", 2},
    {"cheese", 1}
};

var largePizzaValues = new Dictionary<string, int>
{
    {"base", 25},
    {"pepperoni", 3},
    {"cheese", 1}
};

var pizzaMenu = new Dictionary<string, Dictionary<string, int>>
{
    {"small", smallPizzaValues},
    { "medium", mediumPizzaValues},
    { "large", largePizzaValues}
};

Console.WriteLine("What size pizza do you want? Choose small, medium or large");
string size = Console.ReadLine()!.ToLower();
int totalPrice = 0;
var prices = pizzaMenu[size];
totalPrice += prices["base"];
Console.WriteLine("Do you want pepperoni on your pizza? Type yes or no.");
string pepperoni = Console.ReadLine()!;
if (pepperoni == "yes")
{
    totalPrice += prices["pepperoni"];
}
Console.WriteLine("Do you want extra cheese on your pizza? Type yes or no.");
string cheese = Console.ReadLine()!;
if (cheese == "yes")
{
    totalPrice += prices["cheese"];
}
Console.WriteLine($"Your total price is ${totalPrice}.00");
