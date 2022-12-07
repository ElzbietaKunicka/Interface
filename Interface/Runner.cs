using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Runner
    {
        public ICanRun CanRun { get; set; }

        public void MakeRunnerRun()
        {
            CanRun.Run();
        }
    }
}
