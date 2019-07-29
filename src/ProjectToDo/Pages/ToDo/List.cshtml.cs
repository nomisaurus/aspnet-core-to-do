using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using ProjectToDo.Core;
using ProjectToDo.Data;

namespace MyApp.Namespace
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IToDoData todoData;
        public string Message { get; set; }
        public ToDo MyToDo { get; set; }
        public IEnumerable<ToDo> ToDoList { get; set; }

        public ListModel(IConfiguration config, IToDoData todoData)
        {
            this.config = config;
            this.todoData = todoData;
        }

        public void OnGet()
        {
            // Message = "Hello, World!";
            // Message = config["Message"];
            MyToDo = new ToDo() { Name = "Build This To-Do App!" };
            ToDoList = todoData.GetAll();
        }
    }
}