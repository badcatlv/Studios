// See https://aka.ms/new-console-template for more information
using StudioThreeRestaurantMenu;

List<string> list = new List<string>();
MenuItem menuItem = new MenuItem();
menuItem.AddMenuItem("cheese", 9.99, "appetizer", true, list);
menuItem.AddMenuItem("bread", 5.99, "appetizer", false, list);
menuItem.AddMenuItem("cheese", 9.99, "appetizer", true, list);
menuItem.AddMenuItem("lobster", 29.99, "main course", true, list);
menuItem.AddMenuItem("lobster", 29.99, "main course", false, list);

Menu menu = new Menu(DateTime.Now, list);
menu.PrintMenu(DateTime.Now, list);