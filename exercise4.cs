using System;
using System.Linq;

public class Program
{
	
	static  int CalculateArea(int x , int y)
	{
		return x * y / 2;
	}
	
	static double CalculateArea(double x)
	{
	  return Math.PI * Math.Pow(x, 2);
	}
		
	public static void Main()
	{
	 double triangleArea = CalculateArea(4, 8);		     
	 double rectangleArea = CalculateArea(4, 6);
	 double circleArea = CalculateArea(5);
	 Console.WriteLine(triangleArea);
	 Console.WriteLine(circleArea);
     Console.WriteLine(rectangleArea);
	}
}