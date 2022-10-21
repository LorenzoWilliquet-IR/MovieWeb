using MediatR;
using MovieWeb.Application.Common.Movies.Dtos;

namespace Microservices.Orders.Application.Common.Orders.Commands.CreateOrder
{
    public class CreateMovieCommand : IRequest<int>
    {
        public CreateMovieDto CreateMovieDto { get; set; }
    }
}
