namespace UseListView
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.imageSmall = new System.Windows.Forms.ImageList(this.components);
			this.imageLarge = new System.Windows.Forms.ImageList(this.components);
			this.listView1 = new System.Windows.Forms.ListView();
			this.rbViewList = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// imageSmall
			// 
			this.imageSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSmall.ImageStream")));
			this.imageSmall.TransparentColor = System.Drawing.Color.Transparent;
			this.imageSmall.Images.SetKeyName(0, "chrome");
			this.imageSmall.Images.SetKeyName(1, "firefox");
			this.imageSmall.Images.SetKeyName(2, "safari");
			this.imageSmall.Images.SetKeyName(3, "ie");
			this.imageSmall.Images.SetKeyName(4, "opera");
			// 
			// imageLarge
			// 
			this.imageLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLarge.ImageStream")));
			this.imageLarge.TransparentColor = System.Drawing.Color.Transparent;
			this.imageLarge.Images.SetKeyName(0, "safari");
			this.imageLarge.Images.SetKeyName(1, "ie");
			this.imageLarge.Images.SetKeyName(2, "chrome");
			this.imageLarge.Images.SetKeyName(3, "firefox");
			this.imageLarge.Images.SetKeyName(4, "opera");
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.LargeImageList = this.imageLarge;
			this.listView1.Location = new System.Drawing.Point(12, 11);
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new System.Drawing.Size(281, 241);
			this.listView1.SmallImageList = this.imageSmall;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			// 
			// rbViewList
			// 
			this.rbViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbViewList.AutoSize = true;
			this.rbViewList.Checked = true;
			this.rbViewList.Location = new System.Drawing.Point(299, 60);
			this.rbViewList.Name = "rbViewList";
			this.rbViewList.Size = new System.Drawing.Size(41, 17);
			this.rbViewList.TabIndex = 1;
			this.rbViewList.TabStop = true;
			this.rbViewList.Text = "List";
			this.rbViewList.UseVisualStyleBackColor = true;
			this.rbViewList.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(299, 83);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(71, 17);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.Text = "SmallIcon";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(299, 106);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(73, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "LargeIcon";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(299, 129);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(42, 17);
			this.radioButton3.TabIndex = 1;
			this.radioButton3.Text = "Tile";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 264);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.rbViewList);
			this.Controls.Add(this.listView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ImageList imageSmall;
		private System.Windows.Forms.ImageList imageLarge;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.RadioButton rbViewList;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
	}
}

