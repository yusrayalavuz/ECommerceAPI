using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Data;
using ECommerceAPI.Models;
using ECommerceAPI.DTOs;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderResponseDto>>> GetOrders()
        {
            var orders = await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .ToListAsync();

            return orders.Select(MapToDto).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderResponseDto>> GetOrder(int id)
        {
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
                return NotFound();

            return MapToDto(order);
        }

        [HttpPost]
        public async Task<ActionResult<OrderResponseDto>> CreateOrder(CreateOrderDto dto)
        {
            var order = new Order
            {
                UserId = dto.UserId,
                AddressId = dto.AddressId,
                Date = DateTime.UtcNow,
                Status = 1,
                OrderItems = new List<OrderItem>()
            };

            decimal totalPrice = 0;

            foreach (var item in dto.Items)
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                if (product == null)
                    return BadRequest($"Ürün bulunamadı: ID {item.ProductId}");

                var lineTotal = product.UnitPrice * item.Amount;
                totalPrice += lineTotal;

                order.OrderItems.Add(new OrderItem
                {
                    ProductId = product.Id,
                    Amount = item.Amount,
                    UnitPrice = product.UnitPrice,
                    LineTotal = lineTotal
                });
            }

            order.TotalPrice = totalPrice;

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Ürün bilgilerini yüklemek için tekrar çekiyoruz
            await _context.Entry(order).Collection(o => o.OrderItems).Query().Include(oi => oi.Product).LoadAsync();

            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, MapToDto(order));
        }

        private static OrderResponseDto MapToDto(Order order)
        {
            return new OrderResponseDto
            {
                Id = order.Id,
                UserId = order.UserId,
                AddressId = order.AddressId,
                Date = order.Date,
                TotalPrice = order.TotalPrice,
                Status = order.Status,
                Items = order.OrderItems.Select(oi => new OrderItemResponseDto
                {
                    ProductId = oi.ProductId,
                    ProductName = oi.Product.ItemName,
                    Amount = oi.Amount,
                    UnitPrice = oi.UnitPrice,
                    LineTotal = oi.LineTotal
                }).ToList()
            };
        }
    }
}