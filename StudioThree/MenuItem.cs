namespace StudioThreeRestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; } = false;

        public MenuItem(string name, double price, string description, string category, bool isNew)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
            // = $"{Name}\nPrice: ${Price}{Environment.NewLine}{Category}{Environment.NewLine}New Item: {IsNew.ToString()}";
        }

    }
}
