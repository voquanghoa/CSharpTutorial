namespace WindowForm
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txta = new System.Windows.Forms.TextBox();
			this.txtb = new System.Windows.Forms.TextBox();
			this.txtc = new System.Windows.Forms.TextBox();
			this.btSolve = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hệ số a";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 80);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hệ số b";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Hệ số c";
			// 
			// txta
			// 
			this.txta.Location = new System.Drawing.Point(105, 36);
			this.txta.Name = "txta";
			this.txta.Size = new System.Drawing.Size(108, 24);
			this.txta.TabIndex = 0;
			this.txta.Enter += new System.EventHandler(this.Input_Enter);
			// 
			// txtb
			// 
			this.txtb.Location = new System.Drawing.Point(105, 77);
			this.txtb.Name = "txtb";
			this.txtb.Size = new System.Drawing.Size(108, 24);
			this.txtb.TabIndex = 1;
			this.txtb.Enter += new System.EventHandler(this.Input_Enter);
			// 
			// txtc
			// 
			this.txtc.Location = new System.Drawing.Point(105, 120);
			this.txtc.Name = "txtc";
			this.txtc.Size = new System.Drawing.Size(108, 24);
			this.txtc.TabIndex = 2;
			this.txtc.Enter += new System.EventHandler(this.Input_Enter);
			// 
			// btSolve
			// 
			this.btSolve.Location = new System.Drawing.Point(46, 165);
			this.btSolve.Name = "btSolve";
			this.btSolve.Size = new System.Drawing.Size(133, 32);
			this.btSolve.TabIndex = 3;
			this.btSolve.Text = "Giải";
			this.btSolve.UseVisualStyleBackColor = true;
			this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
			// 
			// lblResult
			// 
			this.lblResult.Location = new System.Drawing.Point(18, 214);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(195, 80);
			this.lblResult.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btSolve;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(228, 303);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btSolve);
			this.Controls.Add(this.txtc);
			this.Controls.Add(this.txtb);
			this.Controls.Add(this.txta);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giải phương trình bậc 2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txta;
		private System.Windows.Forms.TextBox txtb;
		private System.Windows.Forms.TextBox txtc;
		private System.Windows.Forms.Button btSolve;
		private System.Windows.Forms.Label lblResult;
	}
}

