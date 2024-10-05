using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos(int authorId)
        {
            return _context.Todos.Where(t => t.AuthorId == authorId).ToList();
        }

        public Todo GetTodo(int id)
        {
            return _context.Todos.Find(id);
        }
    }
}
