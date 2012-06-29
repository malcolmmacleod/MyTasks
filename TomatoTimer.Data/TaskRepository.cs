using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TomatoTimer.Domain;
using TomatoTimer.Domain.Repository;


namespace TomatoTimer.Data
{
    public class TaskRepository : RepositoryBase, ITaskRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRepository"/> class.
        /// </summary>
        public TaskRepository() : base(new TomatoTimerDbContext())
        {
        }

        #endregion


        public IEnumerable<Task> GetAll()
        {
            return Context.Tasks.AsEnumerable();
        }

        public Task Get(int id)
        {
            return Context.Tasks.Where(t => t.Id == id).SingleOrDefault();
        }

        public void Add(Task item)
        {
            Context.Tasks.Add(item);
            Context.SaveChanges();
        }

        public void Update(int id, Task item)
        {
            var foundItem = Context.Tasks.Where(t => t.Id == id).Single();

            if (foundItem != null)
            {
                foundItem.IsComplete = item.IsComplete;
                foundItem.Name = item.Name;
                foundItem.Priority = item.Priority;

                Context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var foundItem = Context.Tasks.Where(t => t.Id == id).Single();

            if (foundItem != null)
            {
                Context.Tasks.Remove(foundItem);
                Context.SaveChanges();
            }
            
        }
    }
}
