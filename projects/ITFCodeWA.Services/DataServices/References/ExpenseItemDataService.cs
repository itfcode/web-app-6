using AutoMapper;
using ITFCodeWA.Core.Services.DataServices.Base;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using ITFCodeWA.Models.References;
using ITFCodeWA.Services.DataServices.References.Interfaces;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Services.DataServices.References
{
    public class ExpenseGroupDataService : ReferenceDataService<IExpenseGroupRepository, ExpenseGroup, ExpenseGroupModel>, IExpenseGroupDataService
    {
        #region Constructros 

        public ExpenseGroupDataService(ILogger<ExpenseGroupDataService> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            IExpenseGroupRepository repository) : base(logger, currentUserService, mapper, repository)
        {
        }

        #endregion
    }
}
