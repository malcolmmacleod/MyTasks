using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TomatoTimer.Domain;
using TomatoTimer.Domain.Repository;

namespace TomatorTimer.Service
{
    public class TaskService : ServiceBase
    {
        #region Fields

        private ITaskRepository _repository;

        #endregion

        #region Constructor

        public TaskService()
        {
            _repository = RepositoryFactory.TaskRepository;
        }
        #endregion

        #region Methods

        public IEnumerable<Task> GetTasks()
        {
            return _repository.GetAll();
        }

        public bool AddTask(Task task)
        {
            var foundTask = _repository.Get(task.Id);

            if (foundTask != null)
            {
                return false;
            }

            _repository.Add(task);

            return true;
        }


        #endregion



        public void PopulateTasks()
        {
            _repository.Add(new Task {Name = "New task 1"});
            _repository.Add(new Task { Name = "New task 2" });
        }

        public bool UpdateTask(int id, Task task)
        {
            // ensure we have something to update

            var foundTask = _repository.Get(id);

            if (foundTask == null)
            {
                return false;
            }

            _repository.Update(id, task);
            return true;
        }

        /// <summary>
        /// Removes the task.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public bool RemoveTask(int id)
        {
            var foundTask = _repository.Get(id);

            if (foundTask == null)
            {
                return false;
            }

            _repository.Delete(id);
            return true;
        }
    }
}
