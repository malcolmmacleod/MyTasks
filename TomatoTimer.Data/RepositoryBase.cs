using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TomatoTimer.Data
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class RepositoryBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryBase"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public RepositoryBase(TomatoTimerDbContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        public TomatoTimerDbContext Context { get; private set; }
    }
}
