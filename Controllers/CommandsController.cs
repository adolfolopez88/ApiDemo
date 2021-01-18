using System.Collections.Generic;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Api.Data;
using Commander.Data;

namespace Api.Controller 
{
    // api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase 
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }


        // GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands() {
            
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        // GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id) {

            var CommandItem = _repository.GetCommandById(id);

            return Ok(CommandItem);

        }
    }
}