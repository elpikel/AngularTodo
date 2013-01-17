using System.Collections.Generic;
using AngularTodo.Models;

namespace AngularTodo.Controllers
{
    public class TodoListController
    {
        public static List<TodoItem> TodoItems = new List<TodoItem>();

        public List<TodoItem> Get()
        {
            return TodoItems;
        } 
    }
}