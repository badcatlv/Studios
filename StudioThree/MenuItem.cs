namespace StudioThreeRestaurantMenu
{
    internal class MenuItem
    {
        private string Item { get; set; }
        private string Price { get; set; }
        private string Description { get; set; }
        private string Category { get; set; }
        private bool IsNew { get; set; }
        //private string NewItem { get; set; }
        private DateTime LastUpdate { get; set; }


        public MenuItem(string item, string price, string description, string category, bool isNew, DateTime lastUpdate)
        {
            Item = item;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
            LastUpdate = lastUpdate;
            string stringIsNew = IsNew.ToString();//consider an if else statement to print yes or no instead of true or false or some other alternative

            Dictionary<string, string> singleMenuItem = new Dictionary<string, string>();
            singleMenuItem.Add("Item", Item);
            singleMenuItem.Add("Price", Price);
            singleMenuItem.Add("Description", Description);
            singleMenuItem.Add("New Item", stringIsNew);

            List<Dictionary<string, string>> MenuItems = new List<Dictionary<string, string>>();
            if (!MenuItems.Contains(singleMenuItem))
            {
                MenuItems.Add(singleMenuItem);
            }
        }


    }
}
//Fields:
//private string name: The name of the menu item.
//private decimal price: The price of the menu item.
//private string description: A brief description of the menu item.
//private string category: The category of the menu item (appetizer, main course, dessert).
//private bool isNew: Indicates whether the menu item is new.
//private DateTime lastUpdated: Stores the date and time when the menu item was last updated.
//Constructors:
//public MenuItem(string name, decimal price, string description, string category):
//Initializes the menu item with the provided name, price, description, and category.
//Automatically sets isNew to true and lastUpdated to the current date and time.
//Methods: (Add later, as needed.)
//public void UpdateMenuItem(string name, decimal price, string description, string category):
//Updates the menu item's details and sets isNew to true.
//Updates the lastUpdated field to the current date and time.
//public void MarkAsNotNew(): Sets isNew to false.
