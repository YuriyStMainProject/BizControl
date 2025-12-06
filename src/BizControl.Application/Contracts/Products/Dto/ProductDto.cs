using BizControl.Application.Contracts.Common;

namespace BizControl.Application.Contracts.Products.Dto
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class ProductDto : IHasId
    {
        /// <summary>
        /// Ідентифікатор товару.
        /// </summary>
        public long Id { get; set; }
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
