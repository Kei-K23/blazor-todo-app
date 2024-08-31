using BlazorTodoApp.Models;

namespace BlazorTodoApp.Services
{
    public class TodoService
    {
        // Initialize the Todos list
        private List<TodoItem> Todos = new List<TodoItem>();

        // Get all todos
        public IEnumerable<TodoItem> GetTodos() => Todos;

        // Add a new todo item
        public void AddTodo(TodoItem newTodoItem)
        {
            // Print the values before adding to the list
            Console.WriteLine("Title: " + newTodoItem.Title);
            Console.WriteLine("Description: " + newTodoItem.Description);
            Console.WriteLine("DueDate: " + newTodoItem.DueDate);

            // Assign a unique ID
            newTodoItem.Id = Todos.Count > 0 ? Todos.Max(t => t.Id) + 1 : 1;

            // Add to the list
            Todos.Add(newTodoItem);

            // Print the entire list to confirm it was added
            Console.WriteLine("Todos List:");
            foreach (var todo in Todos)
            {
                Console.WriteLine($"ID: {todo.Id}, Title: {todo.Title}, Description: {todo.Description}, DueDate: {todo.DueDate}, Completed: {todo.IsCompleted}");
            }
        }


        // Update an existing todo item
        public void UpdateTodo(TodoItem todo)
        {
            var existingTodo = Todos.Find(x => x.Id == todo.Id);

            if (existingTodo != null)
            {
                existingTodo.Title = todo.Title;
                existingTodo.Description = todo.Description;
                existingTodo.IsCompleted = todo.IsCompleted;
                existingTodo.DueDate = todo.DueDate;
            }
        }

        // Remove a todo item
        public void RemoveTodo(int id)
        {
            var todo = Todos.Find(x => x.Id == id);
            if (todo != null)
            {
                Todos.Remove(todo);
            }
        }
    }
}
