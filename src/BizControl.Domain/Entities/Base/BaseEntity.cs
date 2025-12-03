using System.ComponentModel.DataAnnotations;

namespace BizControl.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
