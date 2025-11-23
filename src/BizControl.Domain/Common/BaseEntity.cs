using System.ComponentModel.DataAnnotations;

namespace BizControl.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
