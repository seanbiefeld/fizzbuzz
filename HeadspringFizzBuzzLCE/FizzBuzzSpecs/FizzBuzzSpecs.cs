using System.Linq;
using FizzBuzzLib;
using SpecUnit;

namespace FizzBuzzSpecs
{
    public class FizzBuzzContext : ContextSpecification
    {
		protected FizzBuzz fizzBuzz = new FizzBuzz();
    }

	[Concern("When finding fizz")]
	public class when_finding_fizz_as_multiple_of_3 : FizzBuzzContext
	{
		private string output = "";

		[Observation]
		public void it_should_print_fizz_for_3()
		{
			output = fizzBuzz.DoTheFizzBuzz(3, 3).First();

			output.ShouldEqual("fizz");
		}
	}

	
}
