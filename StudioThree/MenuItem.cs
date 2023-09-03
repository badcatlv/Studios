namespace StudioThreeRestaurantMenu
{
    public class MenuItem
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; } = false;
        public string Item { get; set; }
        public List<string> ItemList { get; set; }
        //public List<string> ItemListByName { get; set; } = new List<string> { };
        public DateOnly LastUpdate { get; set; }

        public void AddMenuItem(string name, double price, string category, bool isNew, List<string> strings)
        {
            Name = name;
            Price = price;
            Category = category;
            IsNew = isNew;
            ItemList = strings;
            //LastUpdate = lastUpdate;
            //foreach (string item in ItemList)
            //{
            //    item.ToLower();
            //    Name = Name.ToLower();
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //        if (i.Equals(Name))
            //        {
            //            Console.WriteLine("Name already taken");
            //            break;
            //        }
            //    }
            //}

            Item = $"{Name}\nPrice: ${Price}{Environment.NewLine}{Category}{Environment.NewLine}New Item: {IsNew.ToString()}";
            AddItem(Item, ItemList);
        }

        public void AddItem(string itemString, List<string> strings)
        {
            string itemToLower = itemString.ToLower();
            foreach (string item in strings)
            {
                item.ToLower();

                if (!item.Equals(itemToLower))
                {
                    ItemList.Add(item);
                }
            }
        }
        public void RemoveItem(string itemString, List<string> strings)
        {
            if (strings.Contains(itemString))
            {
                strings.Remove(itemString);
            }
        }

        public void PrintMenu(List<string> items)
        {
            foreach (string item in items)
            {
                int i = 0;
                Console.WriteLine(i + item);
                i++;
            }
            Console.WriteLine(Environment.NewLine + LastUpdate);

        }

        //public void AddItem(<Dictionary<string, string>> item)
        //{
        //    foreach (Dictionary<string, string> kvp in ItemList)
        //    {

        //    }
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
