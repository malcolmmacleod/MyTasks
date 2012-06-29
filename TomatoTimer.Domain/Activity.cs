using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomatoTimer.Domain
{
    public class Activity : Task
    {
        #region Properties

        public Pomodoro Pomodoro { get; private set; }

        public bool IsComplete { get; set; }


        #endregion
    }
}
