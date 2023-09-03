namespace StudioThreeRestaurantMenu
{
    public class Menu
    {
        //private string Item { get; set; }
        public List<string> MenuList { get; set; }
        public DateTime LastUpdate { get; set; }//use DateTime built in method
        public Menu(DateTime dateTime, List<string> items)
        {
            LastUpdate = dateTime;
            MenuList = items;
            PrintMenu(LastUpdate, MenuList);
        }

        public void PrintMenu(DateTime dateTime, List<string> strings) 
        {
            foreach (string item in strings)
            {
                int i = 0;
                Console.WriteLine(i + item);
                i++;
                Console.WriteLine(dateTime);
            }
            Console.WriteLine(Environment.NewLine + dateTime);
        }

        //public void AddItem(Dictionary<string, string> menuItem)
        //{
        //    //List<Dictionary<string, string>> MenuList = new List<Dictionary<string, string>>();
        //    if (!MenuList.Contains(menuItem))
        //    {
        //        MenuList.Add(menuItem);
        //        LastUpdate = DateTime.Now;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Item already on Menu.");
        //    }


        //}

        //public void RemoveItem(Dictionary<string, string> menuItem)
        //{
        //    //List<Dictionary<string, string>> MenuList = new List<Dictionary<string, string>>();
        //    foreach (Dictionary<string, string> item in MenuList)
        //    {
        //        if (item.Equals(menuItem))
        //        {
        //            MenuList.Remove(menuItem);
        //        }
        //    }
        //    if (MenuList.Contains(menuItem))
        //    {
        //        MenuList.Remove(menuItem);
        //        LastUpdate = DateTime.Now;
        //    }
        //}
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
