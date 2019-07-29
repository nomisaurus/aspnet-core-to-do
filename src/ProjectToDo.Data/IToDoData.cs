using System;
using System.Collections.Generic;
using ProjectToDo.Core;

namespace ProjectToDo.Data
{
    public interface IToDoData
    {
        // IEnumerable<ToDO>
        IEnumerable<ToDo> GetAll();
    }
}
