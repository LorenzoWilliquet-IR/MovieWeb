using MediatR;
using MovieWeb.Application.Common.Interfaces;

namespace Microservices.Orders.Application.Common.Orders.Commands.CreateOrder
{
    public class CreateMovieHandler : IRequestHandler<CreateMovieCommand, int>
    {
        private readonly IMovieService movieService;

        public CreateMovieHandler(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public async Task<int> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            return await movieService.CreateMovieAsync(request.CreateMovieDto);
        }
    }
}
