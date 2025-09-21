using System;
using System.Collections.Generic;

namespace RefactoringExample
{
    public enum AnimalType { Dog, Cat, Bird, Lion, Unknown }

    public class Animal
    {
        public AnimalType Type { get; }
        public string Name { get; }

        public Animal(AnimalType type, string name)
        {
            Type = type;
            Name = name;
        }
    }

    public static class AnimalHelper
    {
        public static void Display(Animal animal)
        {
            Console.WriteLine($"This is a {animal.Type} named {animal.Name}");
        }

        private static readonly Dictionary<AnimalType, string> Sounds = new()
        {
            { AnimalType.Dog, "Woof!" },
            { AnimalType.Cat, "Meow!" },
            { AnimalType.Bird, "Tweet!" },
            { AnimalType.Lion, "Roar!" }
        };

        public static void MakeNoise(Animal animal)
        {
            if (Sounds.TryGetValue(animal.Type, out string sound))
            {
                Console.WriteLine(sound);
                Console.WriteLine($"Playing sound: ./sounds/{animal.Type.ToString().ToLower()}.mp3");
            }
            else
            {
                Console.WriteLine("Unknown animal sound");
            }
        }

        public static void Feed(Animal animal)
        {
            string food = animal.Type switch
            {
                AnimalType.Dog => "dog food",
                AnimalType.Cat => "cat food",
                AnimalType.Bird => "bird food",
                AnimalType.Lion => "meat",
                _ => "generic food"
            };

            Console.WriteLine($"Feeding {food} to {animal.Name}");
            Console.WriteLine($"{animal.Name} is eating {food}");
        }

        public static void CleanEnclosure(Animal animal)
        {
            Console.WriteLine($"Cleaning {animal.Type} enclosure for {animal.Name}");
        }
    }

    public class Zoo
    {
        private readonly List<Animal> animals = new()
        {
            new Animal(AnimalType.Dog, "Rex"),
            new Animal(AnimalType.Cat, "Whiskers"),
            new Animal(AnimalType.Bird, "Tweety")
        };

        public void SimulateZooTour()
        {
            Console.WriteLine("=== Welcome to the Zoo! ===");
            ShowAnimals();
            MakeAllAnimalsNoise();
            FeedAnimals();
            CleanEnclosures();
            Console.WriteLine("\n=== Zoo Tour Completed ===");
        }

        private void ShowAnimals()
        {
            Console.WriteLine("\n--- Showing Animals ---");
            animals.ForEach(AnimalHelper.Display);
        }

        private void MakeAllAnimalsNoise()
        {
            Console.WriteLine("\n--- Animal Sounds ---");
            animals.ForEach(AnimalHelper.MakeNoise);
        }

        private void FeedAnimals()
        {
            Console.WriteLine("\n--- Feeding Animals ---");
            animals.ForEach(AnimalHelper.Feed);
        }

        private void CleanEnclosures()
        {
            Console.WriteLine("\n--- Cleaning Enclosures ---");
            animals.ForEach(AnimalHelper.CleanEnclosure);
        }


        public void PerformZooOperation(string operation)
        {
            Console.WriteLine($"Performing operation: {operation} with animals");
        }

        public void ProcessAnimalData(int value)
        {
            Console.WriteLine($"Processing animal data with value: {value}");
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            Console.WriteLine($"Added new animal: {animal.Type} named {animal.Name}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Zoo Application...\n");

            var zoo = new Zoo();

            zoo.SimulateZooTour();

            Console.WriteLine("\n--- Testing Other Methods ---");
            zoo.PerformZooOperation("feeding");
            zoo.ProcessAnimalData(42);

            Console.WriteLine("\n--- Adding New Animal ---");
            var newAnimal = new Animal(AnimalType.Lion, "Simba");
            zoo.AddAnimal(newAnimal);
            AnimalHelper.Display(newAnimal);
            AnimalHelper.MakeNoise(newAnimal);

            Console.WriteLine("\nZoo Application Completed.");
        }
    }
}
