using MediatR;
using MovieWeb.Application.Common.Actors.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb.Application.Common.Actors.Queries.GetActors
{
    public class GetActorsQuery : IRequest<GetActorsDto[]>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
