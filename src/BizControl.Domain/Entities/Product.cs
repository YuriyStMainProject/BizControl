using BizControl.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizControl.Domain.Entities
{
    [Table("products")]
    public class Product : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = null!;
    }
}
