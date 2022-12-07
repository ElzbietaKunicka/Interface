using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class AudiCar : Car
    {
        public bool IsQuattro { get; set; }

        public AudiCar(bool isQuattro, string model, int fuel) : base(model, fuel)
        {
            this.IsQuattro = isQuattro;
        }
    }
}
