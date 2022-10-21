using MediatR;
using MovieWeb.Application.Common.Interfaces;

namespace MovieWeb.Application.Common.Movies.Commands.UpdateMovie
{
    public class UpdateMovieHandler : IRequestHandler<UpdateMovieCommand, bool>
    {
        private readonly IMovieService movieService;

        public UpdateMovieHandler(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public async Task<bool> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            return await movieService.UpdateMovieAsync(request.UpdateMovieDto, request.MovieId);
        }
    }
}
