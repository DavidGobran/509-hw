using System;

interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof");
    }
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow");
    }
}

// Simple Factory for creating Animal objects
class AnimalFactory
{
    public static IAnimal CreateAnimal(string type)
    {
        switch (type.ToLower())
        {
            case "dog":
                return new Dog();
            case "cat":
                return new Cat();
            default:
                throw new ArgumentException("Invalid animal type");
        }
    }
}

// Example Usage
class Program
{
    static void Main()
    {
        IAnimal dog = AnimalFactory.CreateAnimal("dog");
        dog.Speak();

        IAnimal cat = AnimalFactory.CreateAnimal("cat");
        cat.Speak();
    }
}