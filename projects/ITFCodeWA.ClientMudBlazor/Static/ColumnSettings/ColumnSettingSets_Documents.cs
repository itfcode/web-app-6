using ITFCodeWA.ClientMudBlazor.Extensions;
using ITFCodeWA.ClientMudBlazor.Models.ColumnSettings;
using ITFCodeWA.Models.Documents;

namespace ITFCodeWA.ClientMudBlazor.Static.ColumnSettings
{
    public static partial class ColumnSettingSets
    {
        public static IReadOnlyList<ColumnSetting<WeightRegistratorModel>> WeghtRegistrators =>
            new List<ColumnSetting<WeightRegistratorModel>>()
                .AddSetting(name: nameof(WeightRegistratorModel.DateMonth), label: "Период", view: x => x.DateMonth.ToString("yyyy MMMM"))
                .AddSetting(name: nameof(WeightRegistratorModel.Number), label: "Номер", view: x => x.Number)
                .AddSetting(name: nameof(WeightRegistratorModel.Comment), label: "Комментарий", view: x => x.Comment);
    }
}
