using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronos
{
    public class TimerCronos
    {
        public string Activity { get; set; } = default!;
        public string DateStart { get; set; } = default!;
        public string DateEnd { get; set; } = default!;

        public int Index { get; set; }
        public int TimeStarted { get; set; }
        public int TimeElapsed { get; set; }
    }
}
