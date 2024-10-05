using TaskAPI.Models;

namespace TaskAPI.Dtos
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public string Status { get; set; } //new,inprogress,completed
        public int AuthorId { get; set; }
    }
}
