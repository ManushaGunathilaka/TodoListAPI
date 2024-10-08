﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Dtos;
using TaskAPI.Models;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository repository, IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetTodos(int authorId)
        {
            var myTodos= _todoService.AllTodos(authorId);
            var mappedTodos = _mapper.Map<ICollection<TodoDto>>(myTodos);
            return Ok(mappedTodos);
        }

        [HttpGet("{id}",Name ="GetTodo")]
        public ActionResult<TodoDto> GetTodo(int authorId, int id)
        {
            var myTodo = _todoService.GetTodo(authorId,id);
            if(myTodo is null)
            {
                return NotFound();
            }
            var mappedTodo =_mapper.Map<TodoDto>(myTodo);
            return Ok(mappedTodo);
        }

        [HttpPost]
        public ActionResult<TodoDto> AddTodo(int authorId, CreateTodoDto todoDto)
        {
            var todoEntity = _mapper.Map<Todo>(todoDto);
            var newTodo = _todoService.AddTodo(authorId,todoEntity);
            var todoForReturn = _mapper.Map<TodoDto>(newTodo);
            return CreatedAtRoute("GetTodo", new { authorId= authorId, id = todoForReturn.Id },
                todoForReturn);
        }
    }
}
