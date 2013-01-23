using System.Collections.Generic;
using System.Web.Http;
using Todo.Models;

namespace Todo.Controllers
{
    public class TodoListController : ApiController
    {
        public static List<TodoItem> TodoItems = new List<TodoItem>();

        public List<TodoItem> Get()
        {
            return TodoItems;
        } 
    }
}