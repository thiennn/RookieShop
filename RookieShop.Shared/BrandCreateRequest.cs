using System.ComponentModel.DataAnnotations;

namespace RookieShop.Shared
{
    public class BrandCreateRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
