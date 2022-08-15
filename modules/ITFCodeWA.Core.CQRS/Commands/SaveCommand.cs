using ITFCodeWA.Core.CQRS.Commands.Base;

namespace ITFCodeWA.Core.CQRS.Commands
{
    public abstract class SaveCommand<TEntityDTO> : CommandBase<TEntityDTO> where TEntityDTO : class
    {
        #region Public Properteis 

        public TEntityDTO Entity { get; }

        public bool SaveChanges { get; }

        #endregion

        #region Constructors 

        public SaveCommand(TEntityDTO entity, bool saveChanges = true)
        {
            Entity = entity;
            SaveChanges = saveChanges;
        }

        #endregion
    }
}