using ITFCodeWA.Models.Totals.Weight;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.Analityca.Weight
{
    public partial class WeightSingleTotals : ComponentBase
    {
        #region Private & Protected Fields 

        private readonly IList<string> _months = new List<string>
        {
            "Jan", "Feb", "Mar", "Apr", "May", "Jun",
            "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        private readonly string _maxStyle = $"background-color:{@Colors.DeepOrange.Darken1};color:#ffffff;font-weight:bold;text-align:center;border-radius:20px;";
        private readonly string _minStyle = $"background-color:{@Colors.Red.Darken4};color:#ffffff;font-weight:bold;text-align:center;border-radius:20px;";

        private decimal _minValue = 0;
        private decimal _maxValue = 0;

        #endregion

        #region Parameters

        [Parameter]
        public IList<PeriodWeightTotalsModel> Totals { get; set; }

        [Parameter]
        public Func<PeriodWeightTotalsModel, decimal> ValueFunc { get; set; } = x => x.Avg;

        [Parameter]
        public string Caption { get; set; } = "Итоги по месяцам (средние значения)";

        [Parameter]
        public string YearThColor { get; set; } = Colors.Teal.Darken4;

        [Parameter]
        public string YearTdColor { get; set; } = Colors.Teal.Lighten3;

        [Parameter]
        public string MonthThColor { get; set; } = Colors.Teal.Darken1;

        #endregion

        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            _minValue = Totals.SelectMany(x => x.SubTotals).Min(x => ValueFunc(x));
            _maxValue = Totals.SelectMany(x => x.SubTotals).Max(x => ValueFunc(x));
        }

        #endregion
    }
}