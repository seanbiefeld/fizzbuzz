using System;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
	    public string DoTheFizzBuzz(int begin, int end)
	    {
		    string output = "";
		    for (int i = begin; i <= end; i++)
			{
				var fizz = i%3 == 0 ? "fizz" : "";
				var buzz = i%5 == 0 ? "buzz" : "";
				var fizzbuzz = i%3 == 0 && i%5 == 0 ? "fizzbuzz" : "";

				if (!String.IsNullOrEmpty(fizzbuzz))
				{
					output += fizzbuzz + "\n";
				}
				else if (!String.IsNullOrEmpty(fizz))
				{
					output += fizz + "\n";

				} else if (!String.IsNullOrEmpty(buzz))
				{
					output += buzz + "\n";

				} 
				else
				{
					output += i + "\n";
				}
			}

		    return output;
	    }
    }
}
