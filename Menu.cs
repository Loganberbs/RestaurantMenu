using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
    public string Name { get; set; }
    public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    
    private static int NextId = 1;
    
    public readonly int id;

    public Menu()
        {
            id = NextId;
            NextId++;
        }

    }
}











