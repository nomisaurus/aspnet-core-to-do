using System.Collections.Generic;
using ProjectToDo.Core;
using System.Linq;

namespace ProjectToDo.Data
{
    public class InMemoryToDoData : IToDoData
    {
        readonly List<ToDo> todoList;

        public InMemoryToDoData()
        {
            todoList = new List<ToDo>()
            {
                new ToDo() { Id = 1, Name = "Task 1", Priority = ToDoPriority.Low },
                new ToDo() { Id = 2, Name = "Task 2", Priority = ToDoPriority.High },
                new ToDo() { Id = 3, Name = "Task 3", Priority = ToDoPriority.Medium }
            };
        }

        public IEnumerable<ToDo> GetAll()
        {
            return from t in todoList
                   orderby t.Name
                   select t;
        }
    }
}
