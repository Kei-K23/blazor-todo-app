using BlazorTodoApp.Models;

namespace BlazorTodoApp.Services
{
    public class TodoService
    {
        private List<TodoItem> Todos = [];

        public IEnumerable<TodoItem> GetTodos => Todos;

        public void AddTodo(TodoItem newTodoItem)
        {
            newTodoItem.Id = Todos.Count + 1;
            Todos.Add(newTodoItem);
        }

        public void UpdateTodo(TodoItem todo)
        {
            var existingTodo = Todos.Find(x => x.Id == todo.Id);

            if (existingTodo != null)
            {
                existingTodo.Title = todo.Title;
                existingTodo.Description = todo.Description;
                existingTodo.IsDeleted = todo.IsDeleted;
                existingTodo.DueDate = todo.DueDate;
            }
        }

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