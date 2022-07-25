using ITFCodeWA.Core.Models.Common.Base.Interfaces;

namespace ITFCodeWA.Services.DataServices.Base.Interfaces
{
    public interface IDataService<TEntityModel, TKey> : IReadonlyDataService<TEntityModel, TKey>
        where TEntityModel : class, IModel<TKey>
        where TKey : IComparable
    {
    }
}
