using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class BmwCar : Car
    {

        public bool IsXDrive { get; set; }

        public BmwCar(bool isXDrive, string model, int fuel) : base(model , fuel)
        {
            this.IsXDrive = isXDrive;
        }
    }
}
