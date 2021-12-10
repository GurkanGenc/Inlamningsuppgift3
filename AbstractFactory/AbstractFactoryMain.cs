using System;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            Console.WriteLine("Dog person or Cat person?");
            var input = Console.ReadLine();
            AnimalFactory animalFactory = new();
            animalFactory.GetFactory(input);
        }
    }
}
