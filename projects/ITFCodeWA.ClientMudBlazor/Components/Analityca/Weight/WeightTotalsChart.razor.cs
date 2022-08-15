using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.Analityca.Weight
{
    public partial class WeightTotalsChart : AnallitycaBaseComponent
    {
        #region Private & Protected Fields 

        private readonly ChartOptions options = new()
        {

        };

        #endregion

        #region Parameters 

        [Parameter]
        public List<ChartSeries> Series { get; set; }

        [Parameter]
        public string[] XAxisLabels { get; set; } = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        #endregion

        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        #endregion

    }
}
