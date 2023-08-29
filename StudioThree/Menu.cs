using StudioThreeRestaurantMenu;

namespace StudioThreeRestaurantMenu
{
    internal class Menu
{
    private string Item { get; set; }
    private bool IsNew { get; set; } = false;
    private string LastUpdate { get; set; }//use DateTime built in method


}
}

//Fields:
        //private List<MenuItem> menuItems: A list to store all the menu items in the menu.
//Constructors:
        //public Menu(): Initializes the menu with an empty list of menu items.
//Methods:
        //public void AddMenuItem(MenuItem menuItem): Adds a new menu item to the list of menu items.
        //public void RemoveMenuItem(MenuItem menuItem): Removes a menu item from the list of menu items.
        //public List<MenuItem> GetMenuItems(): Returns a list of all the menu items in the menu.
        //public List<MenuItem> GetNewItems(): Returns a list of menu items that are marked as new.
        //public List<MenuItem> GetItemsInCategory(string category): Returns a list of menu items in the specified category.
