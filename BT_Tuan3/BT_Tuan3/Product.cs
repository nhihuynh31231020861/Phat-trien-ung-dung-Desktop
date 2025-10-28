namespace BT_Tuan3
{
    internal class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }

        public Product() { }
        public Product(string code, string name, decimal price, int stock, string category)
        {
            Code = code; Name = name; Price = price; Stock = stock; Category = category;
        }
    }
}