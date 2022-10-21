namespace MovieWeb.Application.Common.Interfaces
{
    public interface ICommandHandler<TIn>
    {
        Task<int> Execute(TIn request, CancellationToken cancellationToken);
    }
}
