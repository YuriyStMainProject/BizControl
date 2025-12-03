namespace BizControl.Application.Contracts.ProductGroups.Dto
{
    public class UpdateProductGroupDto
    {
        public string Name { get; set; } = "";
        public long? ParentId { get; set; }
    }
}
