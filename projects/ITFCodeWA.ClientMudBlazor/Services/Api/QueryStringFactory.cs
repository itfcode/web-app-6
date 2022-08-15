using ITFCodeWA.Core.Models.QueryFilters;
using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters.Diapason;
using ITFCodeWA.Core.Models.QueryFilters.Range;
using ITFCodeWA.Core.Models.QueryFilters.Range.Base;
using ITFCodeWA.Core.Models.QueryFilters.Single;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace ITFCodeWA.ClientMudBlazor.Services.Api
{
    /// <summary>
    /// Helping Class for building query params set
    /// </summary>
    public static class QueryStringFactory
    {
        public static string Generate(string uri, QueryOptions queryOptions)
        {
            if (queryOptions != null)
            {
                var queryParams = new Dictionary<string, string>
                {
                    ["skip"] = $"{queryOptions.Skip}",
                    ["take"] = $"{queryOptions.Take}",
                };

                if (!string.IsNullOrWhiteSpace(queryOptions.SortField))
                {
                    queryParams["sortField"] = queryOptions.SortField;
                    queryParams["isAsc"] = $"{queryOptions.IsAsc}";
                }

                if (queryOptions.Filters.Count > 0)
                    AddFilterParams(queryParams, queryOptions.Filters);

                uri = QueryHelpers.AddQueryString(uri, queryParams);
            }

            return uri;
        }

        private static void AddFilterParams(Dictionary<string, string> queryParams, IList<IQueryFilter> filters)
        {
            var i = 0;
            foreach (var filter in filters)
            {
                AddParamsToFilter(queryParams, i, type: filter.Type, matchMode: filter.PropertyName);

                if (filter is GuidSingleFilter guidFilter)
                    AddParamsToFilter(queryParams, i, value: guidFilter.Value);

                else if (filter is BoolSingleFilter boolFilter)
                    AddParamsToFilter(queryParams, i, value: boolFilter.Value);

                else if (filter is StringSingleFilter stringFilter)
                    AddParamsToFilter(queryParams, i, value: stringFilter.Value, matchMode: stringFilter.MatchMode);

                else if (filter is NumericSingleFilter numericFilter)
                    AddParamsToFilter(queryParams, i, value: numericFilter.Value, matchMode: numericFilter.MatchMode);

                else if (filter is DateSingleFilter dateFilter)
                    AddParamsToFilter(queryParams, i, value: dateFilter.Value, matchMode: dateFilter.MatchMode);

                else if (filter is NumericDiapasonFilter numericDiapasonFilter)
                    AddParamsToFilter(queryParams, i, from: numericDiapasonFilter.From, to: numericDiapasonFilter.To);

                else if (filter is DateDiapasonFilter dateDiapasonFilter)
                    AddParamsToFilter(queryParams, i, from: GetDateView(dateDiapasonFilter.From), to: GetDateView(dateDiapasonFilter.To));

                else if (filter is DateRangeFilter dateRangeFilter)
                    AddRangeParamsToFilter(queryParams, i, dateRangeFilter);

                else if (filter is GuidRangeFilter guidRangeFilter)
                    AddRangeParamsToFilter(queryParams, i, guidRangeFilter);

                else if (filter is NumericRangeFilter numericRangeFilter)
                    AddRangeParamsToFilter(queryParams, i, numericRangeFilter);

                else if (filter is StringRangeFilter stringRangeFilter)
                    AddRangeParamsToFilter(queryParams, i, stringRangeFilter);

                i++;
            }
        }

        private static void AddParamsToFilter(Dictionary<string, string> queryParams, int i, object type = default!, object property = default!,
            object value = default!, object matchMode = default!, object from = default!, object to = default!)
        {
            if (type is not null)
                queryParams[$"filters[{i}].type"] = $"{type}";

            if (property is not null)
                queryParams[$"filters[{i}].property"] = $"{property}";

            if (value is not null)
                queryParams[$"filters[{i}].value"] = $"{value}";

            if (matchMode is not null)
                queryParams[$"filters[{i}].matchMode"] = $"{matchMode}";

            if (from is not null)
                queryParams[$"filters[{i}].from"] = $"{from}";

            if (to is not null)
                queryParams[$"filters[{i}].to"] = $"{to}";
        }

        private static void AddRangeParamsToFilter<TValue>(Dictionary<string, string> queryParams, int i, QueryRangeFilter<TValue> rangeFilter)
        {
            var j = 0;
            foreach (var item in rangeFilter.Values)
            {
                var value = JsonConvert.SerializeObject(item).Replace("\"", "");
                queryParams[$"filters[{i}].values[{j}]"] = $"{value}";
                j++;
            }
        }

        private static string GetDateView(DateTimeOffset date)
            => JsonConvert.SerializeObject(date).Replace("\"", "")[0..19];
    }
}