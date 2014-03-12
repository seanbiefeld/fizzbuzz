using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLib;

namespace HeadspringFizzBuzzLCE
{
	class Program
	{
		static void Main(string[] args)
		{

			var output = new FizzBuzz().DoTheFizzBuzz(100, 200);
			Console.WriteLine(output);
			Console.ReadLine();
		}
	}
}
