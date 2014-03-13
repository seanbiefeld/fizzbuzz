using System.Linq;
using FizzBuzzLib;
using SpecUnit;

namespace FizzBuzzSpecs
{
    public class FizzBuzzContext : ContextSpecification
    {
		protected FizzBuzz fizzBuzz = new FizzBuzz();
		protected string output = "";
    }

	[Concern("When finding fizz")]
	public class when_finding_fizz_as_multiple_of_3 : FizzBuzzContext
	{
		[Observation]
		public void it_should_return_fizz_for_3()
		{
			output = fizzBuzz.DoTheFizzBuzz(3, 3).First();

			output.ShouldEqual("fizz");
		}
	}

	[Concern("When finding buzz")]
	public class when_finding_buzz_as_multiple_of_5 : FizzBuzzContext
	{
		[Observation]
		public void it_should_return_buzz_for_multiples_of_5()
		{
			output = fizzBuzz.DoTheFizzBuzz(5, 5).First();

			output.ShouldEqual("buzz");
		}
	}

	[Concern("When finding fizzbuzz")]
	public class when_finding_fizzbuzz_as_multiple_of_3_and_5 : FizzBuzzContext
	{
		[Observation]
		public void it_should_return_buzz_for_multiples_of_5()
		{
			output = fizzBuzz.DoTheFizzBuzz(15, 15).First();

			output.ShouldEqual("fizzbuzz");
		}
	}

	[Concern("When number is not a multiple of 3 or 5")]
	public class when_number_is_not_a_multiple_of_3_or_5 : FizzBuzzContext
	{
		[Observation]
		public void it_should_return_the_number()
		{
			output = fizzBuzz.DoTheFizzBuzz(2,2).First();

			output.ShouldEqual("2");
		}
	}
}
