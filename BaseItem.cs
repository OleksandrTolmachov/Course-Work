using System;

namespace CourseWork
{
    public abstract class BaseItem
    {
        protected BaseItem(int id, string name, float cost, int quantity)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Quantity = quantity;
        }

        public int Id { get; }
        public string Name { get; }
        public float Cost { get; private set; }
        public int Quantity { get; private set; }

        public void ChangeQuantity(int quantity)
        {
            // check if quantity value is greater than zero
            Quantity = Math.Max(quantity, 0);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BaseItem baseItem)) return false;

            return Id == baseItem.Id;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}\nProduct: {1}\nCost: {2}$\nQuantity: {3}\n", Id, Name, Math.Round(Cost, 2), Quantity);
        }
    }
}
