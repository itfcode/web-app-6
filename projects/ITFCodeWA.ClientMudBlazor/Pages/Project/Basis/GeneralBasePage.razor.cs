using Microsoft.AspNetCore.Components;

namespace ITFCodeWA.ClientMudBlazor.Pages.Project.Basis
{
    public abstract partial class GeneralBasePage : ComponentBase
    {
        #region Parameters

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public bool Loading { get; set; } = true;

        [Parameter]
        public bool LoadFailed { get; set; } = false;

        [Parameter]
        public Exception Error { get; set; }

        #endregion

        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        #endregion
    }
}