using System;
using System.Collections.Generic;
namespace Interface1;
class Program
{
    static List<Dog> dogs=new List<Dog>();
    static List<Duck> ducks = new List<Duck>();
    public static void Main(string[] args)
    {
        Dog dog1 = new Dog("Jony","home","Dog food");
        Dog dog2 = new Dog("mani","street","rice");

        dogs.Add(dog1);
        dogs.Add(dog2);
        DogMethod();

        Duck duck1=new Duck("abc","pond","fish");
        Duck duck2 =new Duck("bcd","river","fish2");

        ducks.Add(duck1);
        ducks.Add(duck2);
        DuckMethod();
    }
    public static void DogMethod()
    {
        foreach(Dog dog in dogs)
        {
            System.Console.WriteLine("\nDog Name : "+dog.DisplayName());
            System.Console.WriteLine("Dog Habitat : "+dog.Habitat);
            System.Console.WriteLine("Dog Eating Habit : "+dog.EatingHabit);
        }
    }
    public static void DuckMethod()
    {
        foreach(Duck duck in ducks)
        {
            System.Console.WriteLine("\nDuck Name : "+duck.DisplayName());
            System.Console.WriteLine("Duck Habitat : "+duck.Habitat);
            System.Console.WriteLine("Duck Eating Habit : "+duck.EatingHabit);
        }
    }
}