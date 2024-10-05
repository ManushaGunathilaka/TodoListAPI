using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> GetAllAuthors();
        public Author GetAuthor(int id);
        public Author AddAuthor(Author author);
    }
}
