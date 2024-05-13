using System;

namespace CourseWork
{
    public class ProductWithExpirationData : ItemWithDescription 
    {
        public ProductWithExpirationData(int id, string name, float cost, DateTime manufactureData, string description,
            DateTime expirationDate, int quantity) : base(id, name, cost, manufactureData, description, quantity)
        {
            ExpirationDate = expirationDate;
        }

        public DateTime ExpirationDate { get; set; }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, ManufactureData, ExpirationDate);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ProductWithExpirationData item)) return false;

            return Id == item.Id && item.ManufactureData == ManufactureData && ExpirationDate == item.ExpirationDate;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}\nProduct: {1}\nCost: {2}$\nDescription: {3}\nDate of manifacture: {4}" +
                "\nExpires: {5}\nQuantity: {6}\n",
                Id, Name, Math.Round(Cost, 2), Description, ManufactureData, ExpirationDate, Quantity);
        }
    }
}
