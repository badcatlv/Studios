// See https://aka.ms/new-console-template for more information
using StudioThreeRestaurantMenu;


Menu menu = new Menu("Menu");

MenuItem Steak = new MenuItem("Steak", 15.59, "Fancy steak", "Main Course", true);

Console.WriteLine(Steak.Name + "printed thru dot notation");
Console.WriteLine(Steak.Price);
Console.WriteLine(Steak.Description);
Console.WriteLine(Steak.Category);

MenuItem pumpkinPie = new MenuItem("Pumpkin Pie", 5.67, "Slice of pumpkin pie", "dessert", true);

Console.WriteLine("\nadd items to menu list");
menu.MenuList.Add(Steak);
menu.AddItem(Steak);
menu.AddItem(pumpkinPie);
Console.WriteLine("\n" + menu.MenuList.Count + " print menu");
menu.PrintMenu();
Console.WriteLine("\ntest print item");
menu.PrintMenuItem(Steak);

Console.WriteLine("\nremove a steak");
menu.RemoveItem(Steak);
menu.PrintMenu();


MenuItem nuggets = new MenuItem("Chicken Nuggets", 8.99, "Breaded and fried chicken nuggets", "appetizer", false);
menu.MenuList.Add(nuggets);
Console.WriteLine("\nWith nuggets\nItems on menu: " + menu.MenuList.Count);
menu.PrintMenu();
