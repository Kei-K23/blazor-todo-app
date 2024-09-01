using BlazorTodoApp.Models;
using System.Collections.Generic;


namespace BlazorTodoApp.Services
{
    public class TodoService
    {
        // Initialize the Todos list
        private List<TodoItem> Todos = new List<TodoItem>();

        // Get all todos, sorted by IsCompleted (completed items at the bottom)
        public IEnumerable<TodoItem> GetTodos()
        {
            return Todos.OrderByDescending(t => !t.IsCompleted); // Incomplete items first
        }

        // Add a new todo item
        public void AddTodo(TodoItem newTodoItem)
        {
            newTodoItem.Id = Todos.Count > 0 ? Todos.Max(t => t.Id) + 1 : 1;
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

        // Mark an existing todo item as completed or incomplete
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
