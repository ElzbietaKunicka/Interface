using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class BmwFuelComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar? x, BmwCar? y)
        {
           if(x.Fuel > y.Fuel)
            {
                return 1;
            }else if(x.Fuel < y.Fuel)
            {
                return -1;

            }else
            {
                //if(x.IsXDrive && !y.IsXDrive)
                //{
                //    return 1;
                //} else if(!x.IsXDrive && y.IsXDrive)
                //{
                //    return -1;
                //}
                //else
                //{
                //    return 0;
                //}
                return 0;
            }
        }
    }
}
