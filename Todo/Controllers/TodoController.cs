using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Todo.Models;

namespace Todo.Controllers
{
    public class TodoController : ApiController
    {
        public HttpResponseMessage Put(TodoItem todoItem)
        {
            if (TodoListController.TodoItems.All(t => t.Name != todoItem.Name))
            {
                TodoListController.TodoItems.Add(todoItem);

                return Request.CreateResponse(HttpStatusCode.OK, todoItem);
            }

            return Request.CreateResponse(HttpStatusCode.Conflict, new HttpError("Avoid duplicate."));
        } 
    }
}