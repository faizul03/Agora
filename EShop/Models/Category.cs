using System.ComponentModel.DataAnnotations;

namespace EShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public int DisplayOrder { get; set; }
        public float Price { get; set; }
        public int Quntity { get; set; }

    }
}
