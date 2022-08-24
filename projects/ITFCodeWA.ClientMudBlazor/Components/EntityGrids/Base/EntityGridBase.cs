using ITFCodeWA.ClientMudBlazor.Models.ColumnSettings;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityGrids.Base
{
    public abstract partial class EntityGridBase<TModel, TKey, TApiService> : ComponentBase
        where TModel : class, IModel<TKey>
        where TApiService : class, IApiEntityReadService<TModel, TKey>
        where TKey : IComparable
    {
        #region Private & Protected Fields 

        protected MudTable<TModel> _table;
        protected TModel _selectedItem;
        protected IReadOnlyList<ColumnSetting<TModel>> _columns;
        protected QueryOptions _queryOptions = new();
        protected QueryOptions _queryOptionsByColumns = new();
        protected bool _generatedByColumn = false;

        #endregion

        #region Protected Properties

        protected Func<TableState, Task<TableData<TModel>>> ServerData => new(GetPage);

        #endregion

        #region Parameters

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public bool Loading { get; set; } = true;

        [Parameter]
        public bool LoadFailed { get; set; } = false;

        [Parameter]
        public Exception Error { get; set; }

        [Inject]
        public virtual TApiService ApiService { get; set; }

        [Inject]
        protected IDialogService DialogService { get; set; }

        #endregion

        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            InitColumns();
            await Task.Delay(300);
            Loading = false;
        }

        #endregion

        #region Protected Methods  

        protected abstract void InitColumns();

        protected async Task<TableData<TModel>> GetPage(TableState state)
        {
            Loading = true;
            LoadFailed = false;

            if (_generatedByColumn)
                SetQueryOptionsByColumns();
            else
                SetQueryOptions();

            var queryOptions = _generatedByColumn ? _queryOptionsByColumns : _queryOptions;

            queryOptions.Skip = state.Page * state.PageSize;
            queryOptions.Take = state.PageSize;
            if (state.SortDirection != SortDirection.None)
            {
                queryOptions.IsAsc = state.SortDirection == SortDirection.Ascending;
                queryOptions.SortField = state.SortLabel ?? "Number";
            }
            else
            {
                queryOptions.IsAsc = false;
                queryOptions.SortField = "Number";
            }

            TableData<TModel> tableData;

            try
            {
                var pageResult = await ApiService.GetPageAsync(queryOptions);

                tableData = new TableData<TModel>()
                {
                    TotalItems = pageResult.Total,
                    Items = pageResult.Items
                };
            }
            catch (Exception ex)
            {
                LoadFailed = true;
                Error = ex;
                tableData = new TableData<TModel>
                {
                    Items = Enumerable.Empty<TModel>(),
                    TotalItems = 0
                };
            }
            finally
            {
                Loading = false;
                StateHasChanged();
            }

            return tableData;
        }

        protected virtual void SetQueryOptions()
            => _queryOptions = new QueryOptions();

        protected virtual void SetQueryOptionsByColumns()
        {
            _queryOptionsByColumns = new()
            {
                IsAsc = _queryOptions.IsAsc,
                Skip = _queryOptions.Skip,
                SortField = _queryOptions.SortField,
                Take = _queryOptions.Take,
            };

            _queryOptionsByColumns.Filters.AddRange(_queryOptions.Filters);
        }

        #endregion
    }
}