using BizControl.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace BizControl.Domain.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = null!;

        [Required]
        public long GroupId { get; set; }
        public ProductGroup Group { get; set; } = null!;
    }
}
