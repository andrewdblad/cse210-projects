using System;
using System.Collections.Generic;

// Shopping Cart Program (With Classes)

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Cart cart = new Cart();

        menu.Display();

        cart.AddItem();
        cart.AddItem();
        cart.Display();
        Console.WriteLine($"Total = {cart.GetTotal()}");
    }
}