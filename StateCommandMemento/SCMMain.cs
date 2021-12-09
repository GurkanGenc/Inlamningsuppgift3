using Assignment2.StateCommandMemento.Command;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            Machine machine = new();
            var printLater = new PrintLater(machine);
            PrintMemento printMemento = machine.CreateMemento();

            Console.WriteLine();
            Console.WriteLine("Welcome to the Machine, adventurer.");
            Console.WriteLine("How may I help you?");
            Console.WriteLine();
            Console.WriteLine("O: On/Off");
            Console.WriteLine("P: Print");
            Console.WriteLine("R: Reset Printer Memory");
            Console.WriteLine("Esc: Exit");

            while (true)
            {
                var userInput = Console.ReadKey().Key;
                switch (userInput)
                {
                    case ConsoleKey.O:
                        Console.WriteLine();
                        machine.OnOff();
                        foreach (var text in machine.Text)
                        {
                            printLater.ExecuteOrder66(text.Text);
                        }
                        break;

                    case ConsoleKey.P:
                        Console.WriteLine();
                        Console.WriteLine("Enter the text:");
                        var textInput = Console.ReadLine();
                        printLater.ExecuteOrder66(textInput);
                        break;

                    case ConsoleKey.R:
                        Console.WriteLine();
                        if (machine.MachineState is MachineOffState)
                        {
                            printMemento.Restore();
                            Console.WriteLine("Memory has reset.");
                        }
                        else
                        {
                            printMemento.Restore();
                            Console.WriteLine("Memory has reset and the machine has turned off.");
                        }
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine();
                        Console.WriteLine("fFarewell adventurer.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                } 
            }
        }
    }
}