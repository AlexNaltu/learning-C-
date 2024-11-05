using System;

public class WeekDays
{
    public static void Main()
    {
      int day = 7;
      string userDay = "Tuesday";
      
      switch(day){
          case 1: 
              Console.WriteLine("Monday");
              break;
        
          case 2: 
              Console.WriteLine("Tuesday");
              break;
     
          case 3: 
              Console.WriteLine("Wednesday");
              break;
  
          case 4: 
              Console.WriteLine("Thursday");
              break;
     
          case 5: 
              Console.WriteLine("Friday");
              break;
     
          case 6: 
              Console.WriteLine("Saturday");
              break;
    
          case 7: 
              Console.WriteLine("Sunday");
              break;
        
          default:
             Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
             break;
          
                   
      }
      
      switch(userDay) {
          case "Monday": 
              Console.WriteLine("Monday");
              break;
        
          case "Tuesday": 
              Console.WriteLine("Tuesday");
              break;
     
          case "Wednesday": 
              Console.WriteLine("Wednesday");
              break;
  
          case "Thursday": 
              Console.WriteLine("Thursday");
              break;
     
          case "Friday": 
              Console.WriteLine("Friday");
              break;
     
          case "Saturday": 
              Console.WriteLine("Saturday");
              break;
    
          case "Sunday": 
              Console.WriteLine("Sunday");
              break;
        
          default:
             Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
             break;
          
                   
      }
      
    }
}