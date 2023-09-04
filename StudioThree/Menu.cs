namespace StudioThreeRestaurantMenu
{
    public class Menu
    {
        public string Item { get; set; }
        public List<MenuItem> MenuList { get; set; }
        public DateTime LastUpdate { get; set; }//use DateTime built in method
        public Menu(string item, List<MenuItem> menuItems)
        {
            Item = item;
            LastUpdate = DateTime.Now;
            MenuList = menuItems;
            //PrintMenu(LastUpdate, MenuList);
        }

        public void AddItem(MenuItem item)
        {
            MenuList.Add(item);
        }
        public void RemoveItem(MenuItem item)
        {
            if (MenuList.Contains(item))
            {
                MenuList.Remove(item);
            }
        }

        public void PrintMenuItem(MenuItem menuItem)
        {
            // foreach (MenuItem item in MenuList)

            Console.WriteLine("Item: " + menuItem.Name + "\nPrice: $" + menuItem.Price + "\nDescription: " + menuItem.Description + "\n");

        }

        public void PrintMenu()
        {
            foreach (MenuItem item in MenuList)
            {
                Console.WriteLine(item.Name);

            }
            //Console.WriteLine(Environment.NewLine + LastUpdate);
        }

        public void IsNewItem()
        {
            foreach (MenuItem item in MenuList)
            {
                if (item.IsNew)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
