namespace EnglishPuzzleWorldGui
{
	partial class MainMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.play = new System.Windows.Forms.PictureBox();
			this.getGem = new System.Windows.Forms.PictureBox();
			this.option = new System.Windows.Forms.PictureBox();
			this.howToPlay = new System.Windows.Forms.PictureBox();
			this.invite = new System.Windows.Forms.PictureBox();
			this.leaderboard = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.getGem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.option)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.howToPlay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invite)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaderboard)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.SuspendLayout();
			// 
			// play
			// 
			this.play.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.mm_button_play;
			this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.play.Location = new System.Drawing.Point(181, 156);
			this.play.Name = "play";
			this.play.Size = new System.Drawing.Size(122, 51);
			this.play.TabIndex = 0;
			this.play.TabStop = false;
			this.play.Tag = "mm_button_play";
			// 
			// getGem
			// 
			this.getGem.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.mm_button_x10;
			this.getGem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.getGem.Location = new System.Drawing.Point(11, 11);
			this.getGem.Name = "getGem";
			this.getGem.Size = new System.Drawing.Size(69, 55);
			this.getGem.TabIndex = 1;
			this.getGem.TabStop = false;
			this.getGem.Tag = "mm_button_x10";
			// 
			// option
			// 
			this.option.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.mm_button_setting;
			this.option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.option.Location = new System.Drawing.Point(403, 7);
			this.option.Name = "option";
			this.option.Size = new System.Drawing.Size(49, 43);
			this.option.TabIndex = 2;
			this.option.TabStop = false;
			this.option.Tag = "mm_button_setting";
			// 
			// howToPlay
			// 
			this.howToPlay.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.mm_button_how_to_play;
			this.howToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.howToPlay.Location = new System.Drawing.Point(12, 266);
			this.howToPlay.Name = "howToPlay";
			this.howToPlay.Size = new System.Drawing.Size(114, 42);
			this.howToPlay.TabIndex = 3;
			this.howToPlay.TabStop = false;
			this.howToPlay.Tag = "mm_button_how_to_play";
			// 
			// invite
			// 
			this.invite.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.mm_button_invite;
			this.invite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.invite.Location = new System.Drawing.Point(181, 268);
			this.invite.Name = "invite";
			this.invite.Size = new System.Drawing.Size(128, 40);
			this.invite.TabIndex = 4;
			this.invite.TabStop = false;
			this.invite.Tag = "mm_button_invite";
			// 
			// leaderboard
			// 
			this.leaderboard.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.mm_button_leaderboard;
			this.leaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.leaderboard.Location = new System.Drawing.Point(354, 268);
			this.leaderboard.Name = "leaderboard";
			this.leaderboard.Size = new System.Drawing.Size(114, 40);
			this.leaderboard.TabIndex = 3;
			this.leaderboard.TabStop = false;
			this.leaderboard.Tag = "mm_button_leaderboard";
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.mm_background;
			this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox7.Enabled = false;
			this.pictureBox7.Location = new System.Drawing.Point(0, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(480, 320);
			this.pictureBox7.TabIndex = 5;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Tag = "mm_background";
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(480, 320);
			this.Controls.Add(this.invite);
			this.Controls.Add(this.leaderboard);
			this.Controls.Add(this.howToPlay);
			this.Controls.Add(this.option);
			this.Controls.Add(this.getGem);
			this.Controls.Add(this.play);
			this.Controls.Add(this.pictureBox7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainMenu";
			this.Tag = "mm_background";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.getGem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.option)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.howToPlay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invite)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaderboard)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox play;
		private System.Windows.Forms.PictureBox getGem;
		private System.Windows.Forms.PictureBox option;
		private System.Windows.Forms.PictureBox howToPlay;
		private System.Windows.Forms.PictureBox invite;
		private System.Windows.Forms.PictureBox leaderboard;
		private System.Windows.Forms.PictureBox pictureBox7;
	}
}

