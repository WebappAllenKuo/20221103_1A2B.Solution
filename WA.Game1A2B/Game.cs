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
			// todo 在此暫時手動指定
			string answer = "1234";

			// 建立 game
			return new Game(answer);
		}

		public Game(string answer)
		{
			Answer = answer;
		}
	}
}