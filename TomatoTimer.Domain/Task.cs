using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomatoTimer.Domain
{
    public class Task
    {
        #region Constructor

        public Task()
        {
            
        }

        public Task(string name, Priority priority)
        {
            Name = name;
            Priority = priority;
            IsComplete = false;
        }


        #endregion

        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public Priority Priority { get; set; }

        public bool IsComplete { get; set; }

        #endregion
    }
}
