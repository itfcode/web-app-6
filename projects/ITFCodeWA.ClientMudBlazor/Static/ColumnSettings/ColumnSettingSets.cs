using ITFCodeWA.ClientMudBlazor.Models.ColumnSettings;

namespace ITFCodeWA.ClientMudBlazor.Static.ColumnSettings
{
    public static partial class ColumnSettingSets
    {
        private static ColumnSetting<T> Create<T>(string name, string label = default!, string filterName = default!, bool visible = true, bool @fixed = true,
            bool sortable = true, Type type = default!, Func<T, object> view = default!)
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
                View = view
            };
        }
    }

    internal static class ListColumnSettingExtensions
    {
        public static List<ColumnSetting<T>> AddSetting<T>(this List<ColumnSetting<T>> self,
            string name, string label = default!, string filterName = default!, bool visible = true, bool @fixed = true,
            bool sortable = true, Type type = default!, Func<T, object> view = default!)
        {
            self.Add(new ColumnSetting<T>
            {
                Name = name,
                Label = label ?? name,
                FilterName = filterName ?? name,
                Visible = visible,
                Fixed = @fixed,
                Sortable = sortable,
                FilterType = type,
                View = view
            });

            return self;
        }
    }
}
