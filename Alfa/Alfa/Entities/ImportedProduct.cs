namespace Alfa.Entities
{
    class ImportedProduct : Product
    {
        public ImportedProduct(string priceTag) : base(priceTag)
        {
        }
        public double CustomFee { get; set; }
        public double TotalPrice { get; set; }
        
    }
}
