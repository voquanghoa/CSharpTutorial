namespace SQLConnect
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbConnectType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtConnectionString = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDatabase = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(354, 314);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Test connection";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Server:";
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(103, 25);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(367, 20);
			this.txtServer.TabIndex = 2;
			this.txtServer.TextChanged += new System.EventHandler(this.Input_Changed);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Authentication:";
			// 
			// cbConnectType
			// 
			this.cbConnectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbConnectType.FormattingEnabled = true;
			this.cbConnectType.Items.AddRange(new object[] {
            "Window authentication",
            "SQL Server authentication"});
			this.cbConnectType.Location = new System.Drawing.Point(103, 60);
			this.cbConnectType.Name = "cbConnectType";
			this.cbConnectType.Size = new System.Drawing.Size(367, 21);
			this.cbConnectType.TabIndex = 4;
			this.cbConnectType.TextChanged += new System.EventHandler(this.Input_Changed);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(59, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Username";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(150, 142);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(320, 20);
			this.txtUserName.TabIndex = 6;
			this.txtUserName.TextChanged += new System.EventHandler(this.Input_Changed);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(150, 179);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(320, 20);
			this.txtPassword.TabIndex = 8;
			this.txtPassword.TextChanged += new System.EventHandler(this.Input_Changed);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Password";
			// 
			// txtConnectionString
			// 
			this.txtConnectionString.Location = new System.Drawing.Point(21, 225);
			this.txtConnectionString.Multiline = true;
			this.txtConnectionString.Name = "txtConnectionString";
			this.txtConnectionString.ReadOnly = true;
			this.txtConnectionString.Size = new System.Drawing.Size(449, 73);
			this.txtConnectionString.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Database";
			// 
			// txtDatabase
			// 
			this.txtDatabase.Location = new System.Drawing.Point(104, 98);
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Size = new System.Drawing.Size(366, 20);
			this.txtDatabase.TabIndex = 11;
			this.txtDatabase.TextChanged += new System.EventHandler(this.Input_Changed);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 369);
			this.Controls.Add(this.txtDatabase);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtConnectionString);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbConnectType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtServer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbConnectType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtConnectionString;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDatabase;
	}
}

