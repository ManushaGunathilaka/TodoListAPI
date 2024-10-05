using TaskAPI.Models;

namespace TaskAPI.Dtos
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
