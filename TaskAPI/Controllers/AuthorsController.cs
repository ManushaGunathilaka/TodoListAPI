using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Dtos;
using TaskAPI.Services.Authors;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorSqlService;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository repository,IMapper mapper)
        {
            _authorSqlService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors()
        {
            var authors = _authorSqlService.GetAllAuthors();
            var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);
            return Ok(mappedAuthors);
        }

        [HttpGet("{id}")]
        public ActionResult<AuthorDto> GetAuthor(int id)
        {
            var author = _authorSqlService.GetAuthor(id);
            if(author is null)
            {
                return NotFound();
            }
            
            var mappedAuthor = _mapper.Map<AuthorDto>(author);
            return Ok(mappedAuthor);
        }
    }
}
