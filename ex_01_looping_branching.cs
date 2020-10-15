using System;
namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose the task which you want to perform....");
            Console.WriteLine("1.Reversing a String using For loop.");
            Console.WriteLine("2.Diviser program using While Loop.");
            Console.WriteLine(".....");
            Console.WriteLine(".....");
			Console.WriteLine("Enter your Option :");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option) 
            {
              case 1:
                   string str = string.Empty;
                   string revstr =string.Empty;  
                   Console.Write("Enter the string : ");  
                   str = Console.ReadLine();
                   int i;
                   for (i =str.Length - 1; i >= 0; i--)  
                    {  
                       revstr += str[i];  
                    }  
                    Console.WriteLine("The reverse string is : {0}", revstr);  
                    Console.ReadLine();  
                    break;
            case 2:
                    Console.Write("Enter the Diviser : ");  
                    int diviser = Convert.ToInt32(Console.ReadLine());
                    int j=1;
                    while (j<=100)
                    {
                      if(j % diviser == 0)
                        {
		                       Console.WriteLine(j);
                        }
						j++;
                    }
                    break;
            }
        }
    }
}