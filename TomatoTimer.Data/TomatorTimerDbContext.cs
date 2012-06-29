using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using TomatoTimer.Domain;

namespace TomatoTimer.Data
{
    /// <summary>
    /// MemoryDbContext
    /// </summary>
    public class TomatoTimerDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the tasks.
        /// </summary>
        /// <value>
        /// The memories.
        /// </value>
        public DbSet<Task> Tasks { get; set; }
    }
}
