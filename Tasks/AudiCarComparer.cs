using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class AudiCarComparer : IComparer<AudiCar>
    {
        public int Compare(AudiCar? x, AudiCar? y)
        {
            return string.Compare(x.Model, y.Model, StringComparison.Ordinal);
        }
    }
}
