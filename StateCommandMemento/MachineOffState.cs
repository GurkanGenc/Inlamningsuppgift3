using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class MachineOffState : IMachineState
    {
        public void OnOff()
        {
            Console.WriteLine("Machine has started...");
        }
    }
}
