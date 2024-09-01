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
            // Assign a unique ID
            newTodoItem.Id = Todos.Count > 0 ? Todos.Max(t => t.Id) + 1 : 1;

            // Add to the list
            Todos.Add(newTodoItem);
        }


        // Update an existing todo item
        public void UpdateTodo(TodoItem todo)
        {
            var existingTodo = Todos.Find(x => x.Id == todo.Id);

            if (existingTodo != null)
            {
                existingTodo.Title = todo.Title;
                existingTodo.Description = todo.Description;
                existingTodo.DueDate = todo.DueDate;
            }
        }

        // Update an existing todo item
        public void MarkAsComplete(TodoItem todo)
        {
            var existingTodo = Todos.Find(x => x.Id == todo.Id);

            if (existingTodo != null)
            {
                existingTodo.IsCompleted = !existingTodo.IsCompleted;
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
