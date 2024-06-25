using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalgeoBits_Task.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }


        [Required, MaxLength(10)]
        public string Brand { get; set; }

        [Required, MaxLength(10)]
        public string Model { get; set; }

        [Required, MaxLength(10)]
        public string Color { get; set; }

        [Column(TypeName = "decimal(12,2)"), DefaultValue(0)]
        public decimal Price { get; set; }
    }
}
