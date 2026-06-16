namespace ECommerceAPI.DTOs
{
    public class CreateOrderDto
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public List<OrderItemDto> Items { get; set; } = new();
    }

    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }
    }
}