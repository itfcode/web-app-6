using ITFCodeWA.Core.CQRS.Commands.Base.Interfaces;

namespace ITFCodeWA.Core.CQRS.Commands.Base
{
    public abstract class CommandBase<TResponse> : ICommand<TResponse>
    {
    }
}
