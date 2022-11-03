using System;

namespace WA.Game1A2B
{
	public class Game
	{
		/// <summary>
		/// 本次遊戲的答案
		/// </summary>
		public string Answer { get; }

		/// <summary>
		/// 建立一個新遊戲, 傳回Game物件
		/// </summary>
		/// <returns></returns>
		public static Game NewGame()
		{
			// 用亂數取得四個不重覆數字0~9
			string answer = GenerateRandomNumber();

			// 建立 game
			return new Game(answer);
		}

		/// <summary>
		/// 用亂數取得四個不重覆數字0~9
		/// </summary>
		/// <returns></returns>
		private static string GenerateRandomNumber()
		{
			string answer = string.Empty;
			var random = new Random(Guid.NewGuid().GetHashCode());

			while (answer.Length < 4)
			{
				string digit = random.Next(0, 10).ToString(); // "0" ~ "9"
				if (!answer.Contains(digit)) answer += digit;
			}

			return answer;
		}

		public Game(string answer)
		{
			Answer = answer;
		}

		/// <summary>
		/// 判斷單次猜測結果
		/// </summary>
		/// <param name="input">玩家輸入值,長度4, 不重覆的數字,例如 5678</param>
		/// <returns>傳回1A2B的結果</returns>
		public string Play(string input)
		{
			int countA=0, countB=0; // 本次猜測,答對的A,B數量,總和不會超過4

			for (int index = 0; index < input.Length; index++) // 一個個字比對正確性
			{
				// 若位置及值都對,countA加1
				if (input[index] == Answer[index])
				{
					countA++;
				}
				else
				{
					// 若值正確但位置錯, countB加1
					if (Answer.Contains(input[index].ToString()))
					{
						countB++;
					}
				}
			}

			if ((countA + countB) > 4) throw new Exception("countA,countB總和不可能大於4,程式有誤");

			return $"{countA}A{countB}B";
		}
	}
}