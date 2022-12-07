using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class AudiFuelComparer : IComparer<AudiCar>
    {
        public int Compare(AudiCar? x, AudiCar? y)
        {
            if (x.Fuel > y.Fuel)
            {
                return 1;
            }
            else if (x.Fuel < y.Fuel)
            {
                return -1;

            }
            else
            {
                return 0;
            }
        }
    }
}
