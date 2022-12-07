using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class BmwCarComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar? x, BmwCar? y)
        {
            return string.Compare(x.Model, y.Model, StringComparison.Ordinal); // pagal did ir mazas raides
        }
    }
}
