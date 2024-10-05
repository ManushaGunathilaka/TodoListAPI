using Microsoft.IdentityModel.Tokens;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public class AuthorSqlService : IAuthorRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }
    }
}
