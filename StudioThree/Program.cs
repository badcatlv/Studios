// See https://aka.ms/new-console-template for more information
using StudioThreeRestaurantMenu;

List<MenuItem> list = new List<MenuItem>();

Menu menu = new Menu("Menu", list);
MenuItem Burger = new MenuItem("burger", 8.49, "Quarter pound burger", "Main Course", true);
menu.AddItem(Burger);
menu.PrintMenu();