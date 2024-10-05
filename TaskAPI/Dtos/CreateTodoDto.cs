using System.ComponentModel.DataAnnotations;
using TaskAPI.Models;

namespace TaskAPI.Dtos
{
    public class CreateTodoDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public TodoStatus.Status Status { get; set; } //new,inprogress,completed
    }
}
