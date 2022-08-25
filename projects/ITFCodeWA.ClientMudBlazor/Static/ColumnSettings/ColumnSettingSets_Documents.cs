using ITFCodeWA.ClientMudBlazor.Extensions;
using ITFCodeWA.ClientMudBlazor.Models.ColumnSettings;
using ITFCodeWA.Models.Documents;

namespace ITFCodeWA.ClientMudBlazor.Static.ColumnSettings
{
    public static partial class ColumnSettingSets
    {
        public static IReadOnlyList<ColumnSetting<WeightRegistratorModel>> WeightRegistrators =>
            new List<ColumnSetting<WeightRegistratorModel>>()
                .AddSetting(name: nameof(WeightRegistratorModel.DateMonth), label: "Период", view: x => x.DateMonth.ToString("yyyy MMMM"))
                .AddSetting(name: nameof(WeightRegistratorModel.PersonFullName), label: "Физ. особа", view: x => x.PersonFullName)
                .AddSetting(name: nameof(WeightRegistratorModel.Min), label: "Min")
                .AddSetting(name: nameof(WeightRegistratorModel.Max), label: "Max")
                .AddSetting(name: nameof(WeightRegistratorModel.Avg), label: "Avg")
                .AddSetting(name: nameof(WeightRegistratorModel.Comment), label: "Комментарий", view: x => x.Comment);
    }
}