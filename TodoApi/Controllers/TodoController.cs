using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Model;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

//            if (_context.TodoItems.Count() == 0)
//            {
//                _context.TodoItems.Add(new TodoItem { Name = "Item1" });
//                _context.SaveChanges();
//            }
        }

        [HttpGet]
        public String GetAll()
        {
            return "do it!";
        }
    }
}