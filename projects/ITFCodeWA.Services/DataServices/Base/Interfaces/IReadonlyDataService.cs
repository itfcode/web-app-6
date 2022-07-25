using ITFCodeWA.Core.Models.Common.Base.Interfaces;

namespace ITFCodeWA.Services.DataServices.Base.Interfaces
{
    public interface IReadonlyDataService<TEntityModel, TKey> : IDisposable
        where TEntityModel : class, IModel<TKey>
        where TKey : IComparable
    {
    }
}