﻿namespace StudioThreeRestaurantMenu
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

        public string NewItem()
        {
            if(IsNew)
            {
                return ("this is new");
            }
            else
            {
                return ("Not a new item");
            }
        }
        //TODO:
        //HACK: 
        public override bool Equals(object? obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
