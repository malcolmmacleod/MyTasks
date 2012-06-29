using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomatoTimer.Domain
{
    public class Pomodoro
    {
        #region Properties

        public DateTime TimeStarted { get; private set; }

        public int AllocatedTime { get; set; }

        public int TimeTaken { get; private set; }

        #endregion
    }
}
