using Assignment2.StateCommandMemento.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class PrintMemento
    {
        public Machine Machine { get; set; }
        public List<PrintCommand> Text { get; set; }

        public PrintMemento(Machine machine, List<PrintCommand> text)
        {
            Machine = machine;
            Text = text;
        }

        public void Restore()
        {
            Machine.Text.Clear();
            Machine.MachineState = new MachineOffState();
        }
    }
}
