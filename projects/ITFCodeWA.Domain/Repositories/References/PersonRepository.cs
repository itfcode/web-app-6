using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.References.Interfaces;

namespace ITFCodeWA.Domain.Repositories.References
{
    public class PersonRepository : ReferenceRepository<LifeDataContext, Person>, IPersonRepository
    {
        #region Constructors 

        public PersonRepository(LifeDataContext context) : base(context) { }

        #endregion
    }
}
