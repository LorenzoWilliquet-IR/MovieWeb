using MediatR;
using MovieWeb.Application.Common.Interfaces;

namespace MovieWeb.Application.Common.Movies.Commands.DeleteMovie
{
    public class DeleteMovieHandler : IRequestHandler<DeleteMovieCommand, bool>
    {
        private readonly IMovieService movieService;

        public DeleteMovieHandler(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public async Task<bool> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            return await movieService.DeleteMovieAsync(request.MovieId);
        }
    }
}
