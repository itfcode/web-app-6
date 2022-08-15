using ITFCodeWA.ClientMudBlazor.Models.ColumnSettings;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References.Interfaces;
using ITFCodeWA.Core.Models.Common.References.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Pages.Project.Basis.Catalogs
{
    public abstract partial class ReferenceBasePage<TModel, TApiService> : GeneralBasePage
        where TModel : class, IReferenceModel
        where TApiService : class, IApiReferenceService<TModel>
    {
        #region Private & Protected Fields 

        protected MudTable<TModel> _table;
        protected TModel _selectedItem;
        protected IReadOnlyList<ColumnSetting<TModel>> _columns;
        protected QueryOptions _queryOptions = new QueryOptions();
        protected QueryOptions _queryOptionsByColumns = new QueryOptions();
        protected bool _generatedByColumn = false;

        #endregion

        #region Protected Properties 

        protected IReadOnlyList<ColumnSetting<TModel>> VisibleColumns => _columns.Where(x => x.Visible).ToList();
        protected Func<TableState, Task<TableData<TModel>>> ServerData => new(GetPage);

        #endregion

        #region Parameters 

        [Inject]
        public virtual TApiService ApiService { get; set; }

        #endregion

        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            InitColumns();

            await Task.Delay(500);

            Loading = false;
        }

        protected abstract void InitColumns();

        #endregion

        #region Protected Methods 

        protected async Task<TableData<TModel>> GetPage(TableState state)
        {
            Console.WriteLine($"GetPage starts ..");

            Loading = true;
            LoadFailed = false;

            //var dlg = DialogService.Show<DlgLoadingProgress>();

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

            //dlg.Close();
            return tableData;
        }

        protected virtual void SetQueryOptions()
            => _queryOptions = new QueryOptions();

        protected virtual void SetQueryOptionsByColumns()
        {
            _queryOptionsByColumns = new QueryOptions();

            _queryOptionsByColumns.IsAsc = _queryOptions.IsAsc;
            _queryOptionsByColumns.Skip = _queryOptions.Skip;
            _queryOptionsByColumns.SortField = _queryOptions.SortField;
            _queryOptionsByColumns.Take = _queryOptions.Take;

            _queryOptionsByColumns.Filters.AddRange(_queryOptions.Filters);

            //foreach (var filterName in _filterValuesByColumns.Keys)
            //{
            //    var column = _columns.First(x => x.FilterName == filterName);

            //    if (column.FilterType == typeof(NumericFilterValue))
            //        AddNumericFilterByColumn(filterName, filterName);

            //    if (column.FilterType == typeof(StringFilterValue))
            //        AddStringFilterByColumn(filterName, filterName);

            //    if (column.FilterType == typeof(DateFilterValue))
            //        AddDateFilterByColumn(filterName, filterName);

            //    if (column.FilterType == typeof(GuidFilterValue))
            //        AddGuidFilterByColumn(filterName, filterName);
            //}
        }


        #endregion
    }
}