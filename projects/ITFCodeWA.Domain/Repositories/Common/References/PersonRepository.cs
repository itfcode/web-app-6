using ITFCodeWA.Core.Domain.Repositories.Base;
using ITFCodeWA.Data.Common.Reference;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Common.References.Interfaces;

namespace ITFCodeWA.Domain.Repositories.Common.References
{
    public class PersonRepository : Repository<LifeDataContext, Person, int>, IPersonRepository
    {
        #region Constructors 

        public PersonRepository(LifeDataContext context) : base(context) { }

        #endregion
    }
}
