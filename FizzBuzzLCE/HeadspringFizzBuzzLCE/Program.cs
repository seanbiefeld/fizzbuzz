using System;
using System.Collections.Generic;
using FizzBuzzLib;

namespace HeadspringFizzBuzzLCE
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("type default for normal fizzbuzz or custom for custom combos");
			var fizzbuzzType = Console.ReadLine();

			if (fizzbuzzType != null)
			{
				if (fizzbuzzType.ToUpper() == "DEFAULT")
				{
					var output = new FizzBuzz().DoTheFizzBuzz(1, 100);

					foreach (string conversion in output)
					{
						Console.WriteLine(conversion);
					}
				}

				if (fizzbuzzType.ToUpper() == "CUSTOM")
				{
					var customFizzBuzzCombos = new Dictionary<int, string>
						{
							{ 3 , "fizz" },
							{ 5 , "buzz" },
							{ 7 , "pop" },
							{ 10, "pow" },
							{ 25, "bam" },
							{ 50, "wham" }
				
						};

					var output = new FizzBuzz().DoCustomFizzBuzz(customFizzBuzzCombos, 1, 100);

					foreach (string conversion in output)
					{
						Console.WriteLine(conversion);
					}
				}
			}

			Console.ReadLine();
		}
	}
}
