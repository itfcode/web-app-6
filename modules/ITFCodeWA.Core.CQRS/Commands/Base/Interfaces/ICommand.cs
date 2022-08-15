using MediatR;

namespace ITFCodeWA.Core.CQRS.Commands.Base.Interfaces
{
    public interface ICommand<TResponse> : IRequest<TResponse>
    {
    }
}
