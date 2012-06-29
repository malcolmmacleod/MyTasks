using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TomatoTimer.Domain;
using TomatorTimer.Service;

namespace TomatoTimer.Web.Controllers.API
{
    public class TaskController : ApiController
    {
        public IEnumerable<Task> GetAllTasks()
        {
            var taskService = new TaskService();

            return taskService.GetTasks();
        }

        public HttpResponseMessage PostTask(Task task)
        {
            var taskService = new TaskService();

            taskService.AddTask(task);

            // Build a response that contains the location of the new movie
            var response = new HttpResponseMessage(HttpStatusCode.Created);
            var relativePath = "/api/Task/" + task.Id;
            response.Headers.Location = new Uri(Request.RequestUri, relativePath);
            return response;
        }

        public bool PutTask(int id, Task task)
        {
            var taskService = new TaskService();

            return taskService.UpdateTask(id, task);
        }

        public bool DeleteTask(int id)
        {
            var taskService = new TaskService();

            return taskService.RemoveTask(id);
        }
    }
}
