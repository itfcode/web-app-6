using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class PersonService : ApiReferenceService<PersonModel>, IPersonService
    {
        #region Constractor

        public PersonService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.PERSONS)
        {
        }

        #endregion
    }
}