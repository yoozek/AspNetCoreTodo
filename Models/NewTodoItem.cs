using System.ComponentModel.DataAnnotations;
using System;
namespace AspNetCoreTodo.Models
{
    public class NewTodoItem
    {
        [Required]
        public string Title { get; set; }

        public DateTime? DueDate { get; set; }
    }
}