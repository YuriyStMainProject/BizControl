namespace BizControl.Application.Contracts.Products.Dto
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class CreateProductDto
    {
        /// <summary>
        /// Назва товару.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Ідентифікатор групи товарів.
        /// </summary>
        public long GroupId { get; set; }
    }
}
