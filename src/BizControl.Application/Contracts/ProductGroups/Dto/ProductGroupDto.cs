using BizControl.Application.Contracts.Common;

namespace BizControl.Application.Contracts.ProductGroups.Dto
{
    public class ProductGroupDto : IHasId
    {
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public long? ParentId { get; set; }
    }
}
