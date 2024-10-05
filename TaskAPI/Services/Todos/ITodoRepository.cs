using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos(int authorId);
        public Todo GetTodo(int authorId,int id);
    }
}
