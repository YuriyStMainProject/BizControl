namespace BizControl.Application.Contracts.Products.Dto
{
    public class CreateProductDto
    {
        public string Name { get; set; } = "";
        public long GroupId { get; set; }
    }
}
