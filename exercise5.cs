using System;
using System.Linq;

public class Program
{
	
	static int Calculate(int x, int y)
	{
		return x + y;
	}
	
	static double Calculate(double x, double y)
	{
		return x - y;
	}
	
	static float Calculate(float x, float y, float z)
	{
		return x * y * z;
	}
	
	
	public static void Main()
	{
	   int calculateAdd = Calculate(12, 8);
	   double calculateSub = Calculate(10.5, 3.2);
	   float calculateMultiply = Calculate(1.5f ,2.5f ,3.0f);
		
		Console.WriteLine(calculateAdd);
		Console.WriteLine(calculateSub);
		Console.WriteLine(calculateMultiply);
		
	
		
	}
}