using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class ExpenseItemService : ApiReferenceService<ExpenseItemModel>, IExpenseItemService
    {
        #region Constractor

        public ExpenseItemService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.EXPENSE_ITEMS)
        {
        }

        #endregion
    }
}