using System;
using System.Collections.Generic;
using System.Linq;

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

				if (!String.IsNullOrEmpty(fizzbuzz))
				{
					yield return fizzbuzz;
				}
				else if (!String.IsNullOrEmpty(fizz))
				{
					yield return fizz;

				}
				else if (!String.IsNullOrEmpty(buzz))
				{
					yield return buzz;

				}
				else
				{
					yield return i.ToString();
				}
			}
		}

		public IEnumerable<string> DoCustomFizzBuzz(IDictionary<int, string> combos, int begin, int end)
		{
			for (int i = begin; i <= end; i++)
			{
				string value = null;

				foreach (int number in combos.Keys)
				{
					if (i % number == 0)
					{
						value += combos[number];
					}
				}

				yield return String.IsNullOrEmpty(value) ? i.ToString() : value;
			}
		}
	}
}
