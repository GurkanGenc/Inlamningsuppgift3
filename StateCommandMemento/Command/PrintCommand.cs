using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public class PrintCommand : ICommand
    {
        public IPrint Print { get; set; }
        public string Text { get; set; }

        public PrintCommand(IPrint print, string text)
        {
            Print = print;
            Text = text;
        }

        public void ExecuteOrder66()
        {
            Print.PrintOut(Text);
        }
    }
}
