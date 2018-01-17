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

        [HttpGet("{id}")]
        public IActionResult Edit()
        {
            return View(todoRepo.GetList());
        }

        [HttpPost("{id}")]
        public IActionResult EditTodo(Todo todo)
        {
            todoRepo.Edit(todo);
            return RedirectToAction("Index");
        }
    }
}
