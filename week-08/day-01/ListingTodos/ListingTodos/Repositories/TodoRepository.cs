using ListingTodos.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        private TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        //public List<Todo> todoList = new List<Todo>()
        //{
        //    new Todo() {Title = "Start a new day"},
        //    new Todo() {Title = "Finish H2 workshop1"},
        //    new Todo() {Title = "Finish JPA workshop2"},
        //    new Todo() {Title = "Create a CRUD project"},
        //};

        public void Add(Todo todo)
        {
            todoContext.Todos.Add(todo);
            todoContext.SaveChanges();
        }

        public void Delete(long id)
        {
            Todo todo = todoContext.Todos.FirstOrDefault(x => x.Id == id);
            todoContext.Todos.Remove(todo);
            todoContext.SaveChanges();
        }

        public List<Todo> GetList()
        {
            return todoContext.Todos.ToList();
        }

        public Todo GetTodo(long id)
        {
            Todo todo = todoContext.Todos.FirstOrDefault(x => x.Id == id);
            return todo;
        }

        public void ChangeTodo(long id, Todo newTodo)
        {
            todoContext.Todos.FirstOrDefault(x => x.Id == id).Title = newTodo.Title;
            todoContext.Todos.FirstOrDefault(x => x.Id == id).IsDone = newTodo.IsDone;
            todoContext.Todos.FirstOrDefault(x => x.Id == id).IsUrgent = newTodo.IsUrgent;
            todoContext.SaveChanges();
        }
    }
}
