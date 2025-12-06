using BizControl.Application.Contracts.Common;

namespace BizControl.Application.Contracts.ProductGroups.Dto
{
    /// <summary>
    /// Група товарів.
    /// </summary>
    public class ProductGroupDto : IHasId
    {
        /// <summary>
        /// Ідентифікатор групи товарів.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Назва групи товарів.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Ідентифікатор батьківської групи товарів. Якщо null – це коренева група.
        /// </summary>
        public long? ParentId { get; set; }
    }
}
