namespace BasicComponents
{
	partial class BasicComponents
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbPython = new System.Windows.Forms.CheckBox();
			this.cbPascal = new System.Windows.Forms.CheckBox();
			this.cbJava = new System.Windows.Forms.CheckBox();
			this.cbCSharp = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbGenderOther = new System.Windows.Forms.RadioButton();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.button2 = new System.Windows.Forms.Button();
			this.checkListBox = new System.Windows.Forms.CheckedListBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.lblCheckbox = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lblCheckedListBox = new System.Windows.Forms.Label();
			this.lblComboBox = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbPython);
			this.groupBox1.Controls.Add(this.cbPascal);
			this.groupBox1.Controls.Add(this.cbJava);
			this.groupBox1.Controls.Add(this.cbCSharp);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(124, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Languages";
			// 
			// cbPython
			// 
			this.cbPython.AutoSize = true;
			this.cbPython.Checked = true;
			this.cbPython.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbPython.Location = new System.Drawing.Point(9, 115);
			this.cbPython.Name = "cbPython";
			this.cbPython.Size = new System.Drawing.Size(59, 17);
			this.cbPython.TabIndex = 3;
			this.cbPython.Text = "Python";
			this.cbPython.UseVisualStyleBackColor = true;
			this.cbPython.CheckedChanged += new System.EventHandler(this.cbCSharp_CheckedChanged);
			// 
			// cbPascal
			// 
			this.cbPascal.AutoSize = true;
			this.cbPascal.Location = new System.Drawing.Point(9, 82);
			this.cbPascal.Name = "cbPascal";
			this.cbPascal.Size = new System.Drawing.Size(58, 17);
			this.cbPascal.TabIndex = 2;
			this.cbPascal.Text = "Pascal";
			this.cbPascal.UseVisualStyleBackColor = true;
			this.cbPascal.CheckedChanged += new System.EventHandler(this.cbCSharp_CheckedChanged);
			// 
			// cbJava
			// 
			this.cbJava.AutoSize = true;
			this.cbJava.Location = new System.Drawing.Point(9, 49);
			this.cbJava.Name = "cbJava";
			this.cbJava.Size = new System.Drawing.Size(49, 17);
			this.cbJava.TabIndex = 1;
			this.cbJava.Text = "Java";
			this.cbJava.UseVisualStyleBackColor = true;
			this.cbJava.CheckedChanged += new System.EventHandler(this.cbCSharp_CheckedChanged);
			// 
			// cbCSharp
			// 
			this.cbCSharp.AutoSize = true;
			this.cbCSharp.Location = new System.Drawing.Point(9, 19);
			this.cbCSharp.Name = "cbCSharp";
			this.cbCSharp.Size = new System.Drawing.Size(40, 17);
			this.cbCSharp.TabIndex = 0;
			this.cbCSharp.Text = "C#";
			this.cbCSharp.UseVisualStyleBackColor = true;
			this.cbCSharp.CheckedChanged += new System.EventHandler(this.cbCSharp_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(31, 164);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Check";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbGenderOther);
			this.groupBox2.Controls.Add(this.rbFemale);
			this.groupBox2.Controls.Add(this.rbMale);
			this.groupBox2.Location = new System.Drawing.Point(181, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(123, 144);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gender";
			// 
			// rbGenderOther
			// 
			this.rbGenderOther.AutoSize = true;
			this.rbGenderOther.Location = new System.Drawing.Point(13, 94);
			this.rbGenderOther.Name = "rbGenderOther";
			this.rbGenderOther.Size = new System.Drawing.Size(56, 17);
			this.rbGenderOther.TabIndex = 1;
			this.rbGenderOther.Text = "Others";
			this.rbGenderOther.UseVisualStyleBackColor = true;
			this.rbGenderOther.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(13, 58);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(59, 17);
			this.rbFemale.TabIndex = 1;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			this.rbFemale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Checked = true;
			this.rbMale.Location = new System.Drawing.Point(13, 23);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(48, 17);
			this.rbMale.TabIndex = 0;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(194, 164);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Check";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkListBox
			// 
			this.checkListBox.CheckOnClick = true;
			this.checkListBox.FormattingEnabled = true;
			this.checkListBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday ",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
			this.checkListBox.Location = new System.Drawing.Point(373, 17);
			this.checkListBox.Name = "checkListBox";
			this.checkListBox.Size = new System.Drawing.Size(109, 139);
			this.checkListBox.TabIndex = 4;
			this.checkListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkListBox_ItemCheck);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(352, 162);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(68, 24);
			this.button3.TabIndex = 5;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(426, 162);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(68, 24);
			this.button4.TabIndex = 5;
			this.button4.Text = "Check";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// lblCheckbox
			// 
			this.lblCheckbox.AutoSize = true;
			this.lblCheckbox.Location = new System.Drawing.Point(13, 199);
			this.lblCheckbox.Name = "lblCheckbox";
			this.lblCheckbox.Size = new System.Drawing.Size(35, 13);
			this.lblCheckbox.TabIndex = 6;
			this.lblCheckbox.Text = "label1";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(191, 199);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(35, 13);
			this.lblGender.TabIndex = 7;
			this.lblGender.Text = "label1";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
			this.comboBox1.Location = new System.Drawing.Point(522, 18);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(119, 21);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// lblCheckedListBox
			// 
			this.lblCheckedListBox.AutoSize = true;
			this.lblCheckedListBox.Location = new System.Drawing.Point(376, 202);
			this.lblCheckedListBox.Name = "lblCheckedListBox";
			this.lblCheckedListBox.Size = new System.Drawing.Size(35, 13);
			this.lblCheckedListBox.TabIndex = 9;
			this.lblCheckedListBox.Text = "label1";
			// 
			// lblComboBox
			// 
			this.lblComboBox.AutoSize = true;
			this.lblComboBox.Location = new System.Drawing.Point(528, 54);
			this.lblComboBox.Name = "lblComboBox";
			this.lblComboBox.Size = new System.Drawing.Size(35, 13);
			this.lblComboBox.TabIndex = 10;
			this.lblComboBox.Text = "label1";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.listBox1.Location = new System.Drawing.Point(522, 81);
			this.listBox1.Name = "listBox1";
			this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBox1.Size = new System.Drawing.Size(119, 160);
			this.listBox1.TabIndex = 11;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(542, 247);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 12;
			this.button5.Text = "Check";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// BasicComponents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 278);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.lblComboBox);
			this.Controls.Add(this.lblCheckedListBox);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.lblCheckbox);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.checkListBox);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Name = "BasicComponents";
			this.Text = "Basic Components";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbCSharp;
		private System.Windows.Forms.CheckBox cbPascal;
		private System.Windows.Forms.CheckBox cbJava;
		private System.Windows.Forms.CheckBox cbPython;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbGenderOther;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckedListBox checkListBox;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label lblCheckbox;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lblCheckedListBox;
		private System.Windows.Forms.Label lblComboBox;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button5;
	}
}

