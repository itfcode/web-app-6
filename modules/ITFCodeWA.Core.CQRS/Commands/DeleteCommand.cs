using ITFCodeWA.Core.CQRS.Commands.Base;

namespace ITFCodeWA.Core.CQRS.Commands
{
    public abstract class DeleteCommand<TEntityDTO, TKey> : CommandBase<bool> where TEntityDTO : class
    {
        #region Public Properties 

        public TKey Id { get; }

        #endregion

        #region Constructors 

        protected DeleteCommand(TKey id)
        {
            Id = id;
        }

        #endregion
    }
}