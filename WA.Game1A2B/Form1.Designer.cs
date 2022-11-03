namespace WA.Game1A2B
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.newgameButton = new System.Windows.Forms.Button();
			this.answerLabel = new System.Windows.Forms.Label();
			this.historyTextBox = new System.Windows.Forms.TextBox();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.playButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// newgameButton
			// 
			this.newgameButton.Location = new System.Drawing.Point(52, 26);
			this.newgameButton.Name = "newgameButton";
			this.newgameButton.Size = new System.Drawing.Size(100, 23);
			this.newgameButton.TabIndex = 0;
			this.newgameButton.Text = "New Game";
			this.newgameButton.UseVisualStyleBackColor = true;
			this.newgameButton.Click += new System.EventHandler(this.newgameButton_Click);
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Location = new System.Drawing.Point(203, 30);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(78, 15);
			this.answerLabel.TabIndex = 1;
			this.answerLabel.Text = "answerLabel";
			// 
			// historyTextBox
			// 
			this.historyTextBox.Location = new System.Drawing.Point(52, 130);
			this.historyTextBox.Multiline = true;
			this.historyTextBox.Name = "historyTextBox";
			this.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.historyTextBox.Size = new System.Drawing.Size(240, 262);
			this.historyTextBox.TabIndex = 2;
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(52, 79);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(148, 25);
			this.inputTextBox.TabIndex = 3;
			// 
			// playButton
			// 
			this.playButton.Location = new System.Drawing.Point(206, 78);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(75, 23);
			this.playButton.TabIndex = 4;
			this.playButton.Text = "Play";
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 450);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.historyTextBox);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.newgameButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button newgameButton;
		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.TextBox historyTextBox;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Button playButton;
	}
}

