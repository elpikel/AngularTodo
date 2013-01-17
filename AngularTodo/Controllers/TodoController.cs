using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularTodo.Models;

namespace AngularTodo.Controllers
{
    public class TodoController : ApiController
    {
        public HttpResponseMessage Put(TodoItem todoItem)
        {
            TodoListController.TodoItems.Add(todoItem);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        public HttpResponseMessage Update(TodoItem todoItem)
        {
            TodoItem todoItemToUpdate = TodoListController.TodoItems
                .Find(t => string.Equals(todoItem.Name, t.Name, StringComparison.InvariantCultureIgnoreCase));
            
            if (todoItemToUpdate == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            
            todoItemToUpdate.IsDone = todoItem.IsDone;

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}