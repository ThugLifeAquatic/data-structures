using System;
using System.Collections.Generic;

namespace AnimalShelterQueue
{
    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public Animal() { }

        public Animal(string species, string name)
        {
            Species = species;
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Humans Rejects Animal Shelter!");
            Console.WriteLine("You get an animal. cat, dog, or either.");
            Queue<Animal> shelter = new Queue<Animal>();
            shelter.Enqueue(new Animal("dog", "rufus"));
            shelter.Enqueue(new Animal("cat", "hoop"));
            shelter.Enqueue(new Animal("dog", "lizard"));
            shelter.Enqueue(new Animal("cat", "dog"));
            shelter.Enqueue(new Animal("cat", "wheels"));
            shelter.Enqueue(new Animal("dog", "garbage-face"));
            Console.WriteLine(GetAnimal(shelter).Name);
            Console.WriteLine(GetAnimal(shelter, "dog").Name);
            Console.Read();
        }

        public static Animal GetAnimal(Queue<Animal> shelter)
        {
            return shelter.Dequeue();
        }

        public static Animal GetAnimal(Queue<Animal> shelter, string species)
        {
            if (species == shelter.Peek().Species)
            {
                return shelter.Dequeue();
            }
            else
            {
                Animal returnPet = new Animal();
                Animal temp = shelter.Dequeue();
                string name = temp.Name;
                shelter.Enqueue(temp);
                while (shelter.Peek().Name != name)
                {
                    temp = shelter.Dequeue();
                    if (temp.Species == species && returnPet.Name == null)
                    {
                        returnPet = temp;
                    }
                    else
                    {
                        shelter.Enqueue(temp);
                    }
                }
                return returnPet;
            }
        }
    }
}
