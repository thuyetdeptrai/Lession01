using Lab2_TodoList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab2_TodoList.Controllers
{
    public class TodoController : Controller
    {
        private static List<TaskItem> tasks = new List<TaskItem>()
        {
            new TaskItem { Id = 1, TaskName = "Ôn tập HTML" },
            new TaskItem { Id = 2, TaskName = "Ôn tập CSS" },
            new TaskItem { Id = 3, TaskName = "Ôn tập Bootstrap" }
        };

        public IActionResult Index()
        {
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            task.Id = tasks.Count + 1;
            tasks.Add(task);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(TaskItem updatedTask)
        {
            var task = tasks.Find(t => t.Id == updatedTask.Id);
            if (task != null)
            {
                task.TaskName = updatedTask.TaskName;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
            }
            return RedirectToAction("Index");
        }
    }
}
