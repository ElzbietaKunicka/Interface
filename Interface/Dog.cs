using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Dog : ICanRun
    {
        public void Run()
        {
            Console.WriteLine("Dog is running");
        }
    }
}
