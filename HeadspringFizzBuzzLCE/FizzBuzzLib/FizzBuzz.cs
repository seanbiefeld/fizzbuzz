using System;
using System.Collections.Generic;

namespace FizzBuzzLib
{
	public class FizzBuzz
	{
		public IEnumerable<string> DoTheFizzBuzz(int begin, int end)
		{
			for (int i = begin; i <= end; i++)
			{
				var fizz = i % 3 == 0 ? "fizz" : "";
				var buzz = i % 5 == 0 ? "buzz" : "";
				var fizzbuzz = i % 3 == 0 && i % 5 == 0 ? "fizzbuzz" : "";

				string output;

				if (!String.IsNullOrEmpty(fizzbuzz))
				{
					output = fizzbuzz;
				}
				else if (!String.IsNullOrEmpty(fizz))
				{
					output = fizz;

				}
				else if (!String.IsNullOrEmpty(buzz))
				{
					output = buzz;

				}
				else
				{
					output = i.ToString();
				}

				yield return output;
			}
		}
	}
}
