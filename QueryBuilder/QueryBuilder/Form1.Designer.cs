namespace QueryBuilder
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
			if(disposing && (components != null))
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
			this.InputTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SelectTxt = new System.Windows.Forms.TextBox();
			this.InsertTxt = new System.Windows.Forms.TextBox();
			this.UpdateTxt = new System.Windows.Forms.TextBox();
			this.ParmsTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.TableName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// InputTxt
			// 
			this.InputTxt.Location = new System.Drawing.Point(85, 13);
			this.InputTxt.Name = "InputTxt";
			this.InputTxt.Size = new System.Drawing.Size(471, 20);
			this.InputTxt.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "SELECT";
			// 
			// SelectTxt
			// 
			this.SelectTxt.Location = new System.Drawing.Point(85, 65);
			this.SelectTxt.Multiline = true;
			this.SelectTxt.Name = "SelectTxt";
			this.SelectTxt.Size = new System.Drawing.Size(388, 71);
			this.SelectTxt.TabIndex = 2;
			// 
			// InsertTxt
			// 
			this.InsertTxt.Location = new System.Drawing.Point(85, 142);
			this.InsertTxt.Multiline = true;
			this.InsertTxt.Name = "InsertTxt";
			this.InsertTxt.Size = new System.Drawing.Size(388, 71);
			this.InsertTxt.TabIndex = 3;
			// 
			// UpdateTxt
			// 
			this.UpdateTxt.Location = new System.Drawing.Point(85, 219);
			this.UpdateTxt.Multiline = true;
			this.UpdateTxt.Name = "UpdateTxt";
			this.UpdateTxt.Size = new System.Drawing.Size(388, 71);
			this.UpdateTxt.TabIndex = 4;
			// 
			// ParmsTxt
			// 
			this.ParmsTxt.Location = new System.Drawing.Point(85, 296);
			this.ParmsTxt.Multiline = true;
			this.ParmsTxt.Name = "ParmsTxt";
			this.ParmsTxt.Size = new System.Drawing.Size(388, 71);
			this.ParmsTxt.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "INSERT";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "UPDATE";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 299);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "PARMS";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 373);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(541, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Run";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Input";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(480, 65);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(76, 71);
			this.button2.TabIndex = 11;
			this.button2.Text = "To clipboard";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(480, 142);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(76, 71);
			this.button3.TabIndex = 12;
			this.button3.Text = "To clipboard";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(480, 219);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(76, 71);
			this.button4.TabIndex = 13;
			this.button4.Text = "To clipboard";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(480, 299);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(76, 68);
			this.button5.TabIndex = 14;
			this.button5.Text = "To clipboard";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Table name";
			// 
			// TableName
			// 
			this.TableName.Location = new System.Drawing.Point(85, 39);
			this.TableName.Name = "TableName";
			this.TableName.Size = new System.Drawing.Size(471, 20);
			this.TableName.TabIndex = 16;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 410);
			this.Controls.Add(this.TableName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ParmsTxt);
			this.Controls.Add(this.UpdateTxt);
			this.Controls.Add(this.InsertTxt);
			this.Controls.Add(this.SelectTxt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputTxt);
			this.Name = "Form1";
			this.Text = "QueryBuilder";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox InputTxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SelectTxt;
		private System.Windows.Forms.TextBox InsertTxt;
		private System.Windows.Forms.TextBox UpdateTxt;
		private System.Windows.Forms.TextBox ParmsTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TableName;
	}
}

