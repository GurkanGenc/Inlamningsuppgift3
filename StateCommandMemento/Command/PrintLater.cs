using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public class PrintLater
    {
        public Machine Machine { get; set; }

        public PrintLater(Machine machine)
        {
            Machine = machine;
        }

        public void ExecuteOrder66(string stringToSave)
        {
            var textToSave = new PrintCommand(Machine, stringToSave);

            if (Machine.MachineState is MachineOffState)
            {
                Machine.Text.Add(textToSave);
                Console.WriteLine("Open the machine to print out...");
            }
            else
                textToSave.ExecuteOrder66();
        }
    }
}
