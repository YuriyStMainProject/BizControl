namespace BizControl.Application.Contracts.ProductGroups.Dto
{
    /// <summary>
    /// Група товарів.
    /// </summary>
    public class UpdateProductGroupDto
    {
        /// <summary>
        /// Назва групи товарів.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        ///  Ідентифікатор батьківської групи товарів. Якщо null – це коренева група.
        /// </summary>
        public long? ParentId { get; set; }
    }
}
