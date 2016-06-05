namespace EnglishPuzzleWorldGui
{
	partial class Help
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
			this.keyboard_n = new System.Windows.Forms.PictureBox();
			this.keyboard_b = new System.Windows.Forms.PictureBox();
			this.helpPage2 = new System.Windows.Forms.PictureBox();
			this.back = new System.Windows.Forms.PictureBox();
			this.helpPage1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.keyboard_n)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.keyboard_b)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.helpPage2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.helpPage1)).BeginInit();
			this.SuspendLayout();
			// 
			// keyboard_n
			// 
			this.keyboard_n.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.keyboard_n;
			this.keyboard_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.keyboard_n.Location = new System.Drawing.Point(244, 280);
			this.keyboard_n.Name = "keyboard_n";
			this.keyboard_n.Size = new System.Drawing.Size(41, 32);
			this.keyboard_n.TabIndex = 3;
			this.keyboard_n.TabStop = false;
			this.keyboard_n.Tag = "keyboard_n";
			// 
			// keyboard_b
			// 
			this.keyboard_b.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.keyboard_b;
			this.keyboard_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.keyboard_b.Location = new System.Drawing.Point(197, 280);
			this.keyboard_b.Name = "keyboard_b";
			this.keyboard_b.Size = new System.Drawing.Size(41, 32);
			this.keyboard_b.TabIndex = 3;
			this.keyboard_b.TabStop = false;
			this.keyboard_b.Tag = "keyboard_b";
			// 
			// helpPage2
			// 
			this.helpPage2.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.help_page_2;
			this.helpPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.helpPage2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.helpPage2.Enabled = false;
			this.helpPage2.Location = new System.Drawing.Point(0, 0);
			this.helpPage2.Name = "helpPage2";
			this.helpPage2.Size = new System.Drawing.Size(484, 324);
			this.helpPage2.TabIndex = 2;
			this.helpPage2.TabStop = false;
			this.helpPage2.Tag = "help_page_2";
			this.helpPage2.Visible = false;
			// 
			// back
			// 
			this.back.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.game_button_back;
			this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.back.Location = new System.Drawing.Point(12, 12);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(36, 36);
			this.back.TabIndex = 1;
			this.back.TabStop = false;
			this.back.Tag = "game_button_back";
			// 
			// helpPage1
			// 
			this.helpPage1.BackgroundImage = global::EnglishPuzzleWorldGui.Properties.Resources.help_page_1;
			this.helpPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.helpPage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.helpPage1.Enabled = false;
			this.helpPage1.Location = new System.Drawing.Point(0, 0);
			this.helpPage1.Name = "helpPage1";
			this.helpPage1.Size = new System.Drawing.Size(484, 324);
			this.helpPage1.TabIndex = 0;
			this.helpPage1.TabStop = false;
			this.helpPage1.Tag = "help_page_1";
			this.helpPage1.Visible = false;
			// 
			// Help
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 324);
			this.Controls.Add(this.keyboard_n);
			this.Controls.Add(this.keyboard_b);
			this.Controls.Add(this.helpPage2);
			this.Controls.Add(this.back);
			this.Controls.Add(this.helpPage1);
			this.Name = "Help";
			this.Text = "Help";
			this.Load += new System.EventHandler(this.Help_Load);
			((System.ComponentModel.ISupportInitialize)(this.keyboard_n)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.keyboard_b)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.helpPage2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.helpPage1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox helpPage1;
		private System.Windows.Forms.PictureBox back;
		private System.Windows.Forms.PictureBox helpPage2;
		private System.Windows.Forms.PictureBox keyboard_b;
		private System.Windows.Forms.PictureBox keyboard_n;
	}
}