using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadspringFizzBuzzLCE
{
	class Program
	{
		static void Main(string[] args)
		{

			for (int i = 1; i <= 100; i++)
			{
				var fizz = i%3 == 0 ? "fizz" : "";
				var buzz = i%5 == 0 ? "buzz" : "";
				var fizzbuzz = i%3 == 0 && i%5 == 0 ? "fizzbuzz" : "";

				if (!String.IsNullOrEmpty(fizzbuzz))
				{
					Console.WriteLine(fizzbuzz);
				}
				else if (!String.IsNullOrEmpty(fizz))
				{
					Console.WriteLine(fizz);

				} else if (!String.IsNullOrEmpty(buzz))
				{
					Console.WriteLine(buzz);

				} 
				else
				{
					Console.WriteLine(i);
				}
			}
			Console.ReadLine();
		}
	}
}
