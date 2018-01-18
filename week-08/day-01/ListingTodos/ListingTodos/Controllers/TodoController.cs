using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ListingTodos.Controllers
{
    [Route("")]
    public class TodoController : Controller
    {
        private TodoRepository todoRepo;

        public TodoController(TodoRepository todoRepo)
        {
            this.todoRepo = todoRepo;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(todoRepo.GetList());
        }

        [HttpPost("add")]
        public IActionResult Add()
        {
            return View(todoRepo.GetList());
        }

        [HttpPost("newtodo")]
        public IActionResult NewTodo(Todo todo)
        {
            todoRepo.Add(todo);
            return RedirectToAction("Index");
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromQuery]long id)
        {
            todoRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(long id)
        {
            return View(todoRepo.GetTodo(id));
        }

        [HttpPost("edit/{id}")]
        public IActionResult EditTodo(long id, Todo todo)
        {
            todoRepo.ChangeTodo(id, todo);
            return RedirectToAction("Index");
        }
    }
}
