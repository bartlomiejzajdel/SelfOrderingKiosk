namespace SelfOrderingKiosk.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
    }
}
