using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class ExpenseGroupService : ApiReferenceService<ExpenseGroupModel>, IExpenseGroupService
    {
        #region Constractor

        public ExpenseGroupService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.EXPENSE_GROUPS)
        {
        }

        #endregion
    }
}