using System;
class MyException : Exception
{
    public MyException(string message) : base(message)
    {

    }
}			
public class Program
{
    public static void Main()
   {   
        try
        {  
	string[] capcha = { "He7Vz2", "JI31qw", "D7vQW1", "A2c5zp","BZ37gQ", "Q84F3s"};  
	Random rand = new Random();  
	int index = rand.Next(capcha.Length);  
	Console.WriteLine(capcha[index]); 
                 Console.WriteLine("Enter the characters you are seeing in the Screen..... ");
                 var data = Console.ReadLine();
	if(capcha[index] == data) 
	{
	       Console.WriteLine("Welcome User...!");
	}
	else
	{
	       throw (new MyException("Invalid User...!"));
	}
        }
        catch(MyException e)
        {
                Console.Write("Error occurred while Entering Capcha....."+e.Message);
        }          
  }
}