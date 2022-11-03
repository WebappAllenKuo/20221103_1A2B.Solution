using NUnit.Framework;
using WA.Game1A2B;

namespace WA.Game1A2BTests
{
	public class GameTests
	{
		[TestCase("1234", "5678")]
		[TestCase("1234", "9056")]
		public void Play_0A0B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual("0A0B", actual);
		}

		[TestCase("1234", "0156")]
		public void Play_0A1B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual("0A1B", actual);
		}

		[TestCase("1234", "0152")]
		public void Play_0A2B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual("0A2B", actual);
		}

		[TestCase("1234", "0123")]
		public void Play_0A3B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual("0A3B", actual);
		}

		[TestCase("1234", "1567")]
		public void Play_1A0B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual("1A0B", actual);
		}

		[TestCase("1234", "1267")]
		public void Play_2A0B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual("2A0B", actual);
		}

		[TestCase("1234", "1237")]
		public void Play_3A0B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual("3A0B", actual);
		}

		[TestCase("1234", "1234")]
		public void Play_4A0B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual("4A0B", actual);
		}

		[TestCase("1234", "1523")]
		public void Play_1A2B(string answer, string input)
		{
			Game game = new Game(answer);
			string actual = game.Play(input);

			Assert.AreEqual("1A2B", actual);
		}
	}
}