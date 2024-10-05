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
            var authorDto = new List<AuthorDto>();

            //before use automapper
            foreach (var author in authors)
            {
                authorDto.Add(new AuthorDto
                {
                    Id = author.Id,
                    FullName = author.FullName,
                    Address = $"{author.AddressNo},{author.Street},{author.City}"
                });
            }
            return Ok(authorDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorSqlService.GetAuthor(id);
            if(author is null)
            {
                return NotFound();
            }
            var authorDto = new AuthorDto
            {
                Id = author.Id,
                FullName = author.FullName,
                Address = $"{author.AddressNo},{author.Street},{author.City}"
            };
            return Ok(authorDto);
        }
    }
}
