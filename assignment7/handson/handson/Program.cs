using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FactoryDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            AnimalFactory animalfactory = null;
            //string speakSound = null;
            animalfactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine($"The Animal Factory Type : {animalfactory.GetType().Name}");
            Console.WriteLine();



            //get animal object
            animal = animalfactory.GetAnimal("Octopus");
            Console.WriteLine($"Animal Type : {animal.GetType().Name}");
            Console.WriteLine("-------------");
            Console.WriteLine(animal.speak());



            animal = animalfactory.GetAnimal("Shark");
            Console.WriteLine($"Animal Type : {animal.GetType().Name}");
            Console.WriteLine("-------------");
            Console.WriteLine(animal.speak());



            animalfactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine($"The Animal Factory Type : {animalfactory.GetType().Name}");
            Console.WriteLine();



            animal = animalfactory.GetAnimal("Dog");
            Console.WriteLine($"Animal Type : {animal.GetType().Name}");
            Console.WriteLine("-------------");
            Console.WriteLine(animal.speak());



            animal = animalfactory.GetAnimal("Cat");
            Console.WriteLine($"Animal Type : {animal.GetType().Name}");
            Console.WriteLine("-------------");
            Console.WriteLine(animal.speak());
            Console.Read();
        }
    }
}