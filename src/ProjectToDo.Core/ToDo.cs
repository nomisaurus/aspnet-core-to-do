using System;

namespace ProjectToDo.Core
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
        public ToDoPriority Priority { get; set; }
    }
}
