using System;
using System.Linq;



public class Animal
{
  public virtual void MakeSound()
{
  Console.WriteLine("Makes sound:");
}
}
	class Dog : Animal
	{
	  public override void MakeSound()
	{
	  Console.WriteLine("Woof!");
	}
	} 
	
	class Cat : Animal
	{
	  public override void MakeSound()
	{
	  Console.WriteLine("Meow!");
	}
	}
	
	class Cow : Animal
	{
   	  public override void MakeSound()
	{
	  Console.WriteLine("Moo!");
	}
	}


public class Program
{
	public static void Main()
	{
		Animal myAnimal = new Animal();
		Animal myDog = new Dog();
		Animal myCat = new Cat();
		Animal myCow = new Cow();
		
		myAnimal.MakeSound();
		myDog.MakeSound();
		myCat.MakeSound();
		myCow.MakeSound();
		
		Animal[] animals = new Animal[] 
		{
			new Dog(),
			new Cat(),
			new Cow()
		};
		
		foreach (Animal animal in animals)
		{
			animal.MakeSound();
		}
		
	}
}