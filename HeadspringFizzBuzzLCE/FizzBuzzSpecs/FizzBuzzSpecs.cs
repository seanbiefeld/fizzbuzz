using System.Collections;
using System.Collections.Generic;
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
		protected override void Because()
		{
			output = fizzBuzz.DoTheFizzBuzz(3, 3).First();
		}

		[Observation]
		public void it_should_return_fizz_for_3()
		{
			output.ShouldEqual("fizz");
		}
	}

	[Concern("When finding buzz")]
	public class when_finding_buzz_as_multiple_of_5 : FizzBuzzContext
	{
		protected override void Because()
		{
			output = fizzBuzz.DoTheFizzBuzz(5, 5).First();
		}

		[Observation]
		public void it_should_return_buzz_for_multiples_of_5()
		{
			output.ShouldEqual("buzz");
		}
	}

	[Concern("When finding fizzbuzz")]
	public class when_finding_fizzbuzz_as_multiple_of_3_and_5 : FizzBuzzContext
	{
		protected override void Because()
		{
			output = fizzBuzz.DoTheFizzBuzz(15, 15).First();
		}

		[Observation]
		public void it_should_return_buzz_for_multiples_of_5()
		{
			output.ShouldEqual("fizzbuzz");
		}
	}

	[Concern("When number is not a multiple of 3 or 5")]
	public class when_number_is_not_a_multiple_of_3_or_5 : FizzBuzzContext
	{
		protected override void Because()
		{
			output = fizzBuzz.DoTheFizzBuzz(2,2).First();
		}

		[Observation]
		public void it_should_return_the_number()
		{
			output.ShouldEqual("2");
		}
	}

	[Concern("when providing custom combinations")]
	public class when_providing_custom_number_phrase_combinations : FizzBuzzContext
	{
		protected IDictionary<int, string> customFizzBuzzCombos;
		protected string[] outputCollection;

		protected override void Context()
		{
			customFizzBuzzCombos = new Dictionary<int, string>
			{
				{ 3 , "fizz" },
				{ 5 , "buzz" },
				{ 7 , "pop" },
				{ 10, "pow" },
				{ 25, "bam" },
				{ 50, "wham" }
				
			};
		}

		protected override void Because()
		{
			outputCollection = fizzBuzz.DoCustomFizzBuzz(customFizzBuzzCombos, 1, 100).ToArray();
		}

		[Observation]
		public void it_should_return_fizz_for_multiples_of_3()
		{
			int counter = 0;

			for (int i = 2; i < outputCollection.Length; i+=3)
			{
				outputCollection[i].ShouldContain("fizz");
				counter++;
			}

			counter.ShouldEqual(33);
		}

		[Observation]
		public void it_should_return_buzz_for_multiples_of_5()
		{
			int counter = 0;

			for (int i = 4; i < outputCollection.Length; i+=5)
			{
				outputCollection[i].ShouldContain("buzz");
				counter++;
			}

			counter.ShouldEqual(20);
		}

		[Observation]
		public void it_should_return_pop_for_multiples_of_7()
		{
			int counter = 0;

			for (int i = 6; i < outputCollection.Length; i+=7)
			{
				outputCollection[i].ShouldContain("pop");
				counter++;
			}

			counter.ShouldEqual(14);
		}

		[Observation]
		public void it_should_return_pow_for_multiples_of_10()
		{
			int counter = 0;

			for (int i = 9; i < outputCollection.Length; i+=10)
			{
				outputCollection[i].ShouldContain("pow");
				counter++;
			}

			counter.ShouldEqual(10);
		}

		[Observation]
		public void it_should_return_bam_for_multiples_of_25()
		{
			int counter = 0;

			for (int i = 24; i < outputCollection.Length; i+=25)
			{
				outputCollection[i].ShouldContain("bam");
				counter++;
			}

			counter.ShouldEqual(4);
		}

		[Observation]
		public void it_should_return_wham_for_multiples_of_50()
		{
			int counter = 0;

			for (int i = 49; i < outputCollection.Length; i+=50)
			{
				outputCollection[i].ShouldContain("wham");
				counter++;
			}

			counter.ShouldEqual(2);
		}
	}
}
