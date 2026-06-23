using System.ComponentModel.DataAnnotations;

namespace ECommerceAPI.DTOs
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "Ürün kodu zorunludur.")]
        public string ItemCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        [MinLength(2, ErrorMessage = "Ürün adı en az 2 karakter olmalıdır.")]
        public string ItemName { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır.")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Kategori zorunludur.")]
        public string Category1 { get; set; } = string.Empty;

        public string Category2 { get; set; } = string.Empty;

        [Required(ErrorMessage = "Marka zorunludur.")]
        public string Brand { get; set; } = string.Empty;
    }
}