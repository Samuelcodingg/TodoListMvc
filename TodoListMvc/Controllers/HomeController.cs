using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TodoListMvc.Data;
using TodoListMvc.Models;

namespace Todo_List_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Todo> todosList = _context.Todo;
            return View(todosList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Todo todo)
        {
            if (ModelState.IsValid)
            {
                _context.Todo.Add(todo);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var todo = _context.Todo.Find(id);

            if (todo == null)
            {
                return NotFound();
            }

            return View(todo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Todo todo)
        {
            if (ModelState.IsValid)
            {
                _context.Todo.Update(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var todo = _context.Todo.Find(id);

            if (todo == null)
            {
                return NotFound();
            }

            return View(todo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTodo(int? id)
        {

            var todo = _context.Todo.Find(id);

            if (todo == null)
            {
                return NotFound();
            }

            _context.Todo.Remove(todo);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}