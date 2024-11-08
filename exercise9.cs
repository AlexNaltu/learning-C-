using System;
using System.Linq;

public class Program
{
	public class Shape
	{
	  public virtual double CalculateArea()
	  {
		  return 0;
	  } 
    }
	
	public class Circle : Shape 
	{
		public double Radius { get; set; }
		public Circle(double radius)
			{
			   Radius = radius;
			}
			public override double CalculateArea()
			{
				return Math.PI * Radius * Radius;
			}
	}
	
	public class Rectangle : Shape
	{
	  	public double Length { get; set; }
		public double Width { get; set; }
		
		public Rectangle( double length, double width)
		{
			Length = length;
			Width = width;
		}
		public override double CalculateArea()
		{
			return Length * Width;
		}
	}
	
	public class Triangle : Shape
	{
	  	public double Basee { get; set; }
		public double Height { get; set; }
		
		public Triangle( double basee, double height)
		{
			Basee = basee;
			Height = height;
		}
		public override double CalculateArea()
		{
			return 0.5 * Basee * Height;
		}
	}
   
	
	public static void Main()
	{
		Circle myCircle = new Circle(5);
		Rectangle myRectangle = new Rectangle(4,6);
		Triangle myTriangle = new Triangle(4,6);
		
		Console.WriteLine(myTriangle.CalculateArea());
		Console.WriteLine(myRectangle.CalculateArea());
		Console.WriteLine(myCircle.CalculateArea());
		
		
	}
}