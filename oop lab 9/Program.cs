// See https://aka.ms/new-console-template for more information
// Коляда Олександра
using System;
// Базовий клас
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}
class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        // Виклики методів з використанням поліморфізму
        myAnimal.MakeSound();
        myDog.MakeSound();
        myCat.MakeSound();
    }
}
