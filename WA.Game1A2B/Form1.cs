using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA.Game1A2B
{
	public partial class Form1 : Form
	{
		private Game game;

		public Form1()
		{
			InitializeComponent();

			answerLabel.Text = string.Empty;
			inputTextBox.MaxLength = 4;
		}

		private void newgameButton_Click(object sender, EventArgs e)
		{
			game =Game.NewGame(); // new Game("1234");
			answerLabel.Text = game.Answer; // 用label顯示答案,方便確認程式運作正確性
		}

		private void playButton_Click(object sender, EventArgs e)
		{
			string input = inputTextBox.Text;

			// todo 檢查必需輸入四個不同的數字

			string result = game.Play(input);

			if (result == "4A0B")
			{
				MessageBox.Show("您答對了");
				return;
			}
			
			//若答錯,將結果加到最下方
			historyTextBox.Text += result + "\r\n";
		}
	}
}
