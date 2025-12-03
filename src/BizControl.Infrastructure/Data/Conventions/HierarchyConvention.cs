using BizControl.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace BizControl.Infrastructure.Data.Conventions
{
    internal static class HierarchyConvention
    {
        public static void Apply(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.ClrType
                    .GetInterfaces()
                    .Any(i => i.IsGenericType &&
                              i.GetGenericTypeDefinition() == typeof(IHierarchy<>)))
                {
                    modelBuilder.Entity(entityType.ClrType, b =>
                    {
                        b.HasOne("Parent")
                            .WithMany("Children")
                            .HasForeignKey("ParentId")
                            .OnDelete(DeleteBehavior.Restrict);

                        b.HasIndex("ParentId");
                    });
                }
            }
        }
    }
}
