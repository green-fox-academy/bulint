using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ListingTodos.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private TodoRepository todoRepo; 

        public TodoController(TodoRepository todoRepo)
        {
            this.todoRepo = todoRepo;
        }

        [Route("")]
        [Route("list")]
        public IActionResult List(Todo todo)
        {
            return View(todoRepo.GetList(todo));
        }
    }
}
