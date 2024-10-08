﻿using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Due { get; set; }
        [Required]
        public TodoStatus.Status Status { get; set; } //new,inprogress,completed
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
