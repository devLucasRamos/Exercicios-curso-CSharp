using System;
namespace Alfa.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }
        public UsedProduct(string name, double price, DateTime manufactureDate, string priceTag) : base(name,price, priceTag)
        {
            this.manufactureDate = manufactureDate;
        }
    }
}
