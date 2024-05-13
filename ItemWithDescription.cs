using System;

namespace CourseWork
{
    public class ItemWithDescription : BaseItem 
    {
        public ItemWithDescription(int id, string name, float cost, DateTime manufactureData, string description, int quantity)
            : base (id, name, cost, quantity)
        {
            ManufactureData = manufactureData;
            Description = description;
        }

        public DateTime ManufactureData { get; }
        public string Description { get; }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, ManufactureData);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ItemWithDescription item)) return false;

            return Id == item.Id && item.ManufactureData == ManufactureData;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}\nProduct: {1}\nCost: {2}$\nDescription: {3}\nDate of manifacture: {4}\nQuantity: {5}\n",
                Id, Name, Math.Round(Cost, 2), Description, ManufactureData, Quantity);
        }
    }
}
