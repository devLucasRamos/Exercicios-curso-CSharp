namespace Alfa.Entities
{
    class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string priceTag { get; set; }

        public Product(string name, double price, string priceTag)
        {
            Name = name;
            Price = price;
            this.priceTag = priceTag;
        }

        public Product(string priceTag)
        {
            this.priceTag = priceTag;
        }
    }
}
