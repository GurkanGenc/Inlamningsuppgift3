using Assignment2.StateCommandMemento.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class Machine : IMachineState, IPrint
    {
        public IMachineState MachineState { get; set; }
        public List<PrintCommand> Text { get; set; }

        public Machine()
        {
            MachineState = new MachineOffState();
            Text = new List<PrintCommand>();
        }

        public void OnOff()
        {
            MachineState.OnOff();

            if (MachineState is MachineOffState)
                MachineState = new MachineOnState();
            else
                MachineState = new MachineOffState();            
        }

        public void PrintOut(string text)
        {
            Console.WriteLine();
            Console.WriteLine("Printing out...");
            Console.WriteLine(text);
        }

        public PrintMemento CreateMemento()
        {
            return new PrintMemento(this, Text);
        }
    }
}
