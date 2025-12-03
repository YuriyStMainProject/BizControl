using BizControl.Application.Contracts.Common;

namespace BizControl.Application.Contracts.Products.Dto
{
    public class ProductDto : IHasId
    {
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public long GroupId { get; set; }
    }
}
