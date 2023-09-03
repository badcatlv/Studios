namespace StudioThreeRestaurantMenu
{
    public class Menu
    {
        private string Item { get; set; }
        public List<MenuItem> MenuList { get; set; }
        public DateTime LastUpdate { get; set; }//use DateTime built in method
        public Menu(string item, List<MenuItem> items)
        {
            Item = item;
            LastUpdate = DateTime.Now;
            MenuList = items;
            //PrintMenu(LastUpdate, MenuList);
        }

        public void AddItem(MenuItem item)
        {
            MenuList.Add(item);
        }

        public void PrintMenu()
        {
            foreach (MenuItem item in MenuList)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(Environment.NewLine + LastUpdate);
        }
    }
}
