using System;

public class ArraySorting 
{
    public static void Main()
    {
     int[] numbers = {2,7,9,4,15};  
     
     Console.WriteLine(numbers.Sum());
     Console.WriteLine(numbers.Max());
      
     foreach(int number in numbers){
          if (number % 2 == 0) {
              Console.WriteLine(number);
          }
      }
      
     Array.Sort(numbers);
     foreach(int n in numbers){
        Console.WriteLine(n);
     }
     
     for(int i = 0; i < 5; i++)
     {
     if(numbers[i] % 2 == 0){
       Console.WriteLine($"Numarul {numbers[i]} pe pozitia {i}");
     }
    }
  }
}