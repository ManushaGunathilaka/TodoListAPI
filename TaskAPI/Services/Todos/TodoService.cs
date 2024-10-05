using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public List<Todo> AllTodos(int authorId )
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Test 1",
                Description = "Description for Test 1",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.Status.New
            };

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Test 2",
                Description = "Description for Test 2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Status.Inprogress
            };
            var todo3 = new Todo
            {
                Id = 3,
                Title = "Test 3",
                Description = "Description for Test 3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.Status.Completed
            };

            todos.Add(todo1);
            todos.Add(todo2);
            todos.Add(todo3);
            return todos;
        }

        public Todo GetTodo(int authorId,int id)
        {
            throw new NotImplementedException();
        }
    }
}
