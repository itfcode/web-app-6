using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace ITFCodeWA.Core.Domain.Extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static EntityTypeBuilder<TEntity> ConfigProperty<TEntity, TProperty>(this EntityTypeBuilder<TEntity> builder,
            Expression<Func<TEntity, TProperty>> propertyExpression, string columnName, bool IsRequired = false, int? maxLength = default)
            where TEntity : class
        {
            ArgumentNullException.ThrowIfNull(propertyExpression, nameof(propertyExpression));
            ArgumentNullException.ThrowIfNull(columnName, nameof(columnName));

            var prop = builder.Property(propertyExpression)
                .HasColumnName(columnName)
                .IsRequired(IsRequired);

            if (typeof(TProperty) == typeof(string) && maxLength.HasValue) 
                prop.HasMaxLength(maxLength.Value);

            return builder;
        }

        public static EntityTypeBuilder<TEntity> AddIndex<TEntity>(this EntityTypeBuilder<TEntity> builder,
            Expression<Func<TEntity, object?>> indexExpression, string? indexName = default, bool isUnique = false)
            where TEntity : class
        {
            ArgumentNullException.ThrowIfNull(indexExpression, nameof(indexExpression));

            var index = builder.HasIndex(indexExpression).IsUnique(isUnique);

            if (!string.IsNullOrWhiteSpace(indexName))
                index.HasDatabaseName(indexName);

            return builder;
        }
    }
}
