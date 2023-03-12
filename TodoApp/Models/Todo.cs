using Microsoft.AspNetCore.Mvc;

namespace TodoApp.Models
{
    public class Todo : Controller
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime DueDate { get; set; }

        public Todo()
        {
        }
        public Todo(int id, string title, string description, bool status, DateTime dueDate)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
            DueDate = dueDate;
        }
    }
}
