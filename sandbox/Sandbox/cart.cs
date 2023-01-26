using System;
using System.Collections.Generic;

class Cart
{
    public List<Item> _items = new List<Item>();

    // ----------------------------------------------------------------------
    public void Display()
    {
        System.Console.WriteLine("Cart----------");
        foreach (Item item in _items)
        {
            item.Display();
        } 
    }

    // ----------------------------------------------------------------------
    public void AddItem()
    {
        System.Console.Write("Enter Description: ");
        string desc = Console.ReadLine();

        System.Console.Write("Enter Price: ");
        float price = float.Parse(Console.ReadLine());

        System.Console.Write("Enter Count: ");
        int count = int.Parse(Console.ReadLine());

        Item newItem = new Item();
        newItem._desc = desc;
        newItem._price = price;
        newItem._count = count;

        _items.Add(newItem);
    }

    // ----------------------------------------------------------------------
    public void RemoveItem()
    {
        Display();

        int count = _items.Count;
        System.Console.Write($"Enter index to remove (1 - {count}): ");
        int index = 0;
        do
        {
            index = int.Parse(Console.ReadLine());
        }
        while (index < 1 || index > count);

        _items.RemoveAt(index);
    }

    // ----------------------------------------------------------------------
    public bool DoesItemExist(string desc)
    {
        foreach (Item item in _items)
        {
            if (desc == item._desc)
            {
                return true;
            }
        } 
        return false;

    }

    // ----------------------------------------------------------------------
    public float GetTotal()
    {
        float total = 0;
        foreach (Item item in _items)
        {
            total += item._price * item._count;
        } 
        return total;
    }

}

