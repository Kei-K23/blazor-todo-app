namespace BlazorTodoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DueDate { get; set; }
    }
}