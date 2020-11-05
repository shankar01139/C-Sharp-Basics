using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
		class OTPException : Exception
	{
		public OTPException(string message) : base(message)
		{
		}
	}
	public class Program
	{
		public static void Main()
		{
			var otp = 3476;
			Console.WriteLine("Enter Your Mobile Number To verify : ");
			var mob_num = Convert.ToInt64(Console.ReadLine());
			Console.WriteLine("Enter the Four Digit OTP you received on your mobile.... ");
			var data = Convert.ToInt64(Console.ReadLine());
			try
			{
				if(otp == data)
				{
					Console.WriteLine("Mobile Number Verified Successfully ...!");
					Console.ReadLine();
				}
				else
				{
					throw (new OTPException("Enter valid OTP...!"));
					Console.ReadLine();
				}
			}
			catch (OTPException e)
			{
				Console.Write("Error occurred while Reading OTP....." + e.Message);
				Console.ReadLine();
			}
		}
	}
}
