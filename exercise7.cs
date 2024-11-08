using System;
using System.Linq;

public class Program
{
	static double CalculateVolume( double side )
	{
		return (side < 0) ?  666 : Math.Pow(side, 3);
	}
	
	static double CalculateVolume( double radius, double height)
	{
		return (  radius < 0 ) ?  666 : Math.PI * Math.Pow(radius, 2) * height;
	}
	
	static double CalculateVolume( double length, double width, double height)
	{
		return ( length < 0 ) ?  666 : length * width * height;
	}
	
	public static void Main()
	{
		
		Console.WriteLine(CalculateVolume(-100));
		Console.WriteLine(CalculateVolume( -3,  -7));
		Console.WriteLine(CalculateVolume( -5,  -10,  -4));
	}
}