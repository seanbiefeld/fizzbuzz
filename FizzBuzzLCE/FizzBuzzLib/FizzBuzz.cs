using System;
using System.Collections.Generic;

namespace FizzBuzzLib
{
	public class FizzBuzz
	{
		/// <summary>
		/// Default fizzbuzz example, with begin/end params
		/// </summary>
		/// <param name="begin">starts at this number</param>
		/// <param name="end">ends at this number</param>
		/// <returns></returns>
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

		/// <summary>
		/// Using dictionary to capture custom combinations of intergers and text values
		/// </summary>
		/// <param name="combos">integer - text combinations to return</param>
		/// <param name="begin">start at this number</param>
		/// <param name="end">end at this number</param>
		/// <returns></returns>
		public IEnumerable<string> DoCustomFizzBuzz(IDictionary<int, string> combos, int begin, int end)
		{
			for (int i = begin; i <= end; i++)
			{
				string value = null;

				//check for numbers specified in combos dictionary
				foreach (int number in combos.Keys)
				{
					if (i % number == 0)
					{
						//append so that number that have many multiples specified will show all applicable text values, i.e. fizzbuzz
						value += combos[number];
					}
				}

				yield return String.IsNullOrEmpty(value) ? i.ToString() : value;
			}
		}
	}
}
