using NUnit.Framework;
using WA.Game1A2B;

namespace WA.Game1A2BTests
{
	public class GameTests
	{
		public void ShouldBeEqual(string answer, string input, string expected)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual(expected, actual);
		}

		[TestCase("1234", "5678")]
		[TestCase("1234", "9056")]
		public void Play_0A0B(string answer, string input)
		{
			ShouldBeEqual(answer, input, "0A0B");
		}

		[TestCase("1234", "0156")]
		public void Play_0A1B(string answer, string input)
		{
			ShouldBeEqual(answer, input, "0A1B");
		}

		[TestCase("1234", "0152")]
		public void Play_0A2B(string answer, string input)
		{
			ShouldBeEqual(answer, input, "0A2B");
		}

		[TestCase("1234", "0123")]
		public void Play_0A3B(string answer, string input)
		{
			ShouldBeEqual(answer, input, "0A3B");
		}

		[TestCase("1234", "1567")]
		public void Play_1A0B(string answer, string input)
		{
			ShouldBeEqual(answer, input, "1A0B");
		}

		[TestCase("1234", "1267")]
		public void Play_2A0B(string answer, string input)
		{
			ShouldBeEqual(answer, input, "2A0B");
		}

		[TestCase("1234", "1237")]
		public void Play_3A0B(string answer, string input)
		{
			ShouldBeEqual(answer, input, "3A0B");
		}

		[TestCase("1234", "1234")]
		public void Play_4A0B(string answer, string input)
		{
			ShouldBeEqual(answer, input, "4A0B");
		}

		[TestCase("1234", "1523")]
		public void Play_1A2B(string answer, string input)
		{
			ShouldBeEqual(answer, input, "1A2B");
		}
	}
}