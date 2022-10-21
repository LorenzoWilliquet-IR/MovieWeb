using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieWeb.Application.Common.Actors.Dtos;
using MovieWeb.Application.Common.Actors.Queries.GetActors;
using MovieWeb.Application.Common.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieWeb.Api.Controllers
{
    [Route("api/actors")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/actors
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetActorsQuery()));
        }

        // GET api/actors/5
        [HttpGet("{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/actors
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/actors/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/actors/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
