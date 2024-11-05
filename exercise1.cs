using System;

public class Temp 
{
    public static void Main()
    {
      double celsiusValue = 20.01;
      
      Console.Write("Enter the temperature in Celsius: ");
      double celsius = Convert.ToDouble(Console.ReadLine());
       double fahrenheit = (celsiusValue * 9 / 5) + 32;
       Console.WriteLine(fahrenheit);
       
       if(fahrenheit < 32)
       {
           Console.WriteLine("Below freezing");
       }
       else if(fahrenheit == 32)
       {
           Console.WriteLine("At freezing");
       }
       else
       {
           Console.WriteLine("Above freezing");
       }
       string accordingTemp =(fahrenheit > 68) ? "Accordingly" : "Lol";
       Console.WriteLine(accordingTemp); 
    }
}