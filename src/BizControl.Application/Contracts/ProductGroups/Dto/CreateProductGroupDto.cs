namespace BizControl.Application.Contracts.ProductGroups.Dto
{
    public class CreateProductGroupDto
    {
        public string Name { get; set; } = "";
        public long? ParentId { get; set; }
    }
}
