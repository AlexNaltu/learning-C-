using System;

public class Program
{
	
	static string CalculateGrade(int score)
	{
		if (score >= 90){
			return "A";
		}
		else if (score >= 80)
		{
			return "B";
		}
		else if (score >= 70)
		{
			return "C";
		}
		else if (score >= 60)
		{
			return "D";
		}
		else
		{
			return "F";
		}
		
		
	}
	static string[] CalculateGrades(int[] scores)
	{
		string[] grades = new string[scores.Length];
		
		for(int i = 0 ; i < scores.Length ; i++)
		{
		grades[i] = CalculateGrade(scores[i]);
		}
		
		return grades;
	
	
	}
	
	
	public static void Main()
	{
		
		int[] scores = {95, 85, 75, 65, 50};
		string[] grades = CalculateGrades(scores);
		
		for(int i = 0; i<scores.Length; i++)
		{
		Console.WriteLine(scores[i] + grades[i]);
		}

		Console.WriteLine(CalculateGrade(95));
		Console.WriteLine(CalculateGrade(85));
		Console.WriteLine(CalculateGrade(75));
		Console.WriteLine(CalculateGrade(65));
		Console.WriteLine(CalculateGrade(50));
	
		
	}
}