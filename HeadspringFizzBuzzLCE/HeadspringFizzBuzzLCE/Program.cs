using System;
using FizzBuzzLib;

namespace HeadspringFizzBuzzLCE
{
	class Program
	{
		static void Main(string[] args)
		{
			var output = new FizzBuzz().DoTheFizzBuzz(100, 200);

			foreach (string conversion in output)
			{
				Console.WriteLine(conversion);
			}

			Console.ReadLine();
		}
	}
}
