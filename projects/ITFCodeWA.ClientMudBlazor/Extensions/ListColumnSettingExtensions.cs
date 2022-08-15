using ITFCodeWA.ClientMudBlazor.Models.ColumnSettings;
using static ITFCodeWA.ClientMudBlazor.Static.ColumnSettings.ColumnSettingFactory;

namespace ITFCodeWA.ClientMudBlazor.Extensions
{
    internal static class ListColumnSettingExtensions
    {
        public static List<ColumnSetting<T>> AddSetting<T>(this List<ColumnSetting<T>> self,
            string name, string label = default!, string filterName = default!, bool visible = true, bool @fixed = true,
            bool sortable = true, Type type = default!, Func<T, object> view = default!)
        {
            self.Add(Create(name, label, filterName, visible, @fixed, sortable, type, view));

            return self;
        }
    }
}
