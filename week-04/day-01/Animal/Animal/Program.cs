using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var wildAnimal = new Animal();
            wildAnimal.Drink();
            wildAnimal.Eat();
            wildAnimal.Play();
            wildAnimal.Play();
            wildAnimal.Play();
            wildAnimal.Eat();
            wildAnimal.Drink();
            Console.WriteLine(wildAnimal.hunger);
            Console.WriteLine(wildAnimal.thirst);
            Console.ReadLine();
        }
    }
}
