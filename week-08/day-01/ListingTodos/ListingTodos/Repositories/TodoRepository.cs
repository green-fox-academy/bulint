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

        public List<Todo> GetList(Todo todo)
        {
            todoContext.Todos.Add(todo);
            return todoContext.Todos.ToList();
        }
    }
}
