namespace BizControl.Domain.Common
{
    public interface IHierarchy<T> where T : class
    {
        long? ParentId { get; set; }
        T? Parent { get; set; }
        List<T> Children { get; set; }
    }
}
