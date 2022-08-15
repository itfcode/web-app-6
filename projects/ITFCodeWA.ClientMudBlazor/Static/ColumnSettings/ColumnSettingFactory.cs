using ITFCodeWA.ClientMudBlazor.Models.ColumnSettings;
using System.Linq.Expressions;

namespace ITFCodeWA.ClientMudBlazor.Static.ColumnSettings
{
    internal static class ColumnSettingFactory
    {
        public static ColumnSetting<T> Create<T>(string name, string label = default!, string filterName = default!, 
            bool visible = true, bool @fixed = true, bool sortable = true, Type type = default!, Func<T, object> view = default!)
        {
            return new ColumnSetting<T>
            {
                Name = name,
                Label = label ?? name,
                FilterName = filterName ?? name,
                Visible = visible,
                Fixed = @fixed,
                Sortable = sortable,
                FilterType = type,
                View = view ?? GetViewFunc<T>(name)
            };
        }

        private static Func<T, object> GetViewFunc<T>(string propertyName) 
        {
            var property = typeof(T).GetProperty(propertyName);
            var objParameterExpr = Expression.Parameter(typeof(T), "ins");
            var instanceExpr = Expression.TypeAs(objParameterExpr, property.DeclaringType);
            var propertyExpr = Expression.Property(instanceExpr, property);
            var propertyObjExpr = Expression.Convert(propertyExpr, typeof(object));
            return Expression.Lambda<Func<T, object>>(propertyObjExpr, objParameterExpr).Compile();
        }
    }
}
