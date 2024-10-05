using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoRepository _todoService;

        public TodosController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var myTodos= _todoService.AllTodos();
            return Ok(myTodos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var myTodo = _todoService.GetTodo(id);
            if(myTodo is null)
            {
                return NotFound();
            }
            return Ok(myTodo);
        }


    }
}
