namespace BlazorTodoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
        public DateTime DueDate { get; set; }
    }
}