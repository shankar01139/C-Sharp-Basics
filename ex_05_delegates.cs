using System;
namespace DelegateProg
{
    delegate void ArithDelegate(int x, int y);
    public class Arithmetic
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Sum of {0} and {1} = {2}", x, y, x + y);
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("Difference between {0} and {1} = {2}", x, y, x - y);
        }
		public static void multy(int x, int y)
        {
            Console.WriteLine("Product of {0} and {1} = {2}", x, y, x * y);
        }
        public static void divi(int x, int y)
        {
            Console.WriteLine("Division of {0} and {1} = {2}", x, y, x / y);
        }
    }
   public class Program
    {
       public static void Main()
        {
            var s = new ArithDelegate(Arithmetic.Add);
		    var d = new ArithDelegate(Arithmetic.Sub);
		   	var m = new ArithDelegate(Arithmetic.multy);
			var mo = new ArithDelegate(Arithmetic.divi);
		    Console.WriteLine("C# Delegates.....");
		    Console.WriteLine("Enter Number 1 :");
		   int num1=Convert.ToInt32(Console.ReadLine());
		    Console.WriteLine("Énter NUmber 2 : ");
            
			int num2=Convert.ToInt32(Console.ReadLine());
			s(num1,num2);
			d(num1,num2);
			m(num1,num2);
			mo(num1,num2);
        }
    }
}