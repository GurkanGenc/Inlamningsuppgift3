using System;

namespace Assignment2.AbstractFactory
{
    public class AnimalFactory // aka Abstract Factory
    {
        public IFactory GetFactory(string typeOfFactory)
        {
            if (typeOfFactory == "dog")
            {
                Console.WriteLine($"I knew you were a {typeOfFactory} person!");
                return new DogFactory();
            }
            else if (typeOfFactory == "cat")
            {
                Console.WriteLine($"I knew you were a {typeOfFactory} person!");
                return new CatFactory();
            }
            else
            {
                Console.WriteLine("No such factory exist.");
                return null;
            }
        }
    }
}
