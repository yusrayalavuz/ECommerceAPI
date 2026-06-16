namespace ECommerceAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public string Category1 { get; set; } = string.Empty;
        public string Category2 { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}