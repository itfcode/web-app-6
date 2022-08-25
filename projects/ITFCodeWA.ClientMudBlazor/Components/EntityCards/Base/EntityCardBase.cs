using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using Microsoft.AspNetCore.Components;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityCards.Base
{
    public partial class EntityCardBase<TModel, TKey, TApiService> : ComponentBase
        where TModel : class, IModel<TKey>, new()
        where TKey : IComparable
        where TApiService : class, IApiEntityCrudService<TModel, TKey>
    {
        #region Private & Protected Fields

        protected TModel _model = new();
        protected bool _loading = true;
        protected bool _hasError = false;
        protected string _errorMessage = string.Empty;

        #endregion

        #region MyRegion

        [Inject]
        public virtual TApiService ApiService { get; set; }

        [Parameter]
        public TKey ModelId { get; set; }

        #endregion

        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            await Task.Delay(250);

            if (!ModelId.Equals(default(TKey)))
            {
                try
                {
                    _model = await ApiService.GetByIdAsync(ModelId);
                }
                catch (Exception ex)
                {
                    _hasError = true;
                    _errorMessage = ex.Message;
                }
            }
            else
            {
                _model = await CreateModel();
            }

            _loading = false;

            StateHasChanged();
        }

        protected async Task SaveModel() 
        {
            await ApiService.SaveAsync(_model);
        }

        protected virtual async Task<TModel> CreateModel() 
        {
            return await Task.Run(() => new TModel());
        }

        #endregion
    }
}