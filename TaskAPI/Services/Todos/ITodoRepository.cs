using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos(int authorId);
        public Todo GetTodo(int authorId,int id);
        public Todo AddTodo(int authorId, Todo todo);
    }
}
