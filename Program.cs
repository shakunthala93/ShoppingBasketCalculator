using System;
using System.Collections.Generic;

Console.WriteLine("Shopping Basket Calculator");
Console.WriteLine("--------------------------");
Console.WriteLine("Enter items separated by commas:");

string input = Console.ReadLine() ?? "";

List<string> items = string.IsNullOrWhiteSpace(input)
    ? new List<string>()
    : new List<string>(input.Split(','));

ShoppingBasket basket = new ShoppingBasket();

try
{
    int total = basket.CalculateTotal(items);
    Console.WriteLine("--------------------------");
    Console.WriteLine("Total Price: " + total + "p");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}