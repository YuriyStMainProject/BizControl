using BizControl.Domain.Common;
using BizControl.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace BizControl.Domain.Entities
{
    public class ProductGroup : BaseEntity, IHierarchy<ProductGroup>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = null!;

        public long? ParentId { get; set; }
        public ProductGroup? Parent { get; set; }

        public List<ProductGroup> Children { get; set; } = [];

        public List<Product> Products { get; set; } = [];
    }
}
