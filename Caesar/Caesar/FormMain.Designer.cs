namespace Caesar
{
	partial class FormMain
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
			this.original = new System.Windows.Forms.TextBox();
			this.ciphered = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.encipher = new System.Windows.Forms.Button();
			this.decipher = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.key = new System.Windows.Forms.TextBox();
			this.checkBoxReverse = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// original
			// 
			this.original.Location = new System.Drawing.Point(74, 12);
			this.original.Name = "original";
			this.original.Size = new System.Drawing.Size(100, 20);
			this.original.TabIndex = 0;
			// 
			// ciphered
			// 
			this.ciphered.Location = new System.Drawing.Point(74, 39);
			this.ciphered.Name = "ciphered";
			this.ciphered.Size = new System.Drawing.Size(100, 20);
			this.ciphered.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "originál:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "šifrované:";
			// 
			// encipher
			// 
			this.encipher.Location = new System.Drawing.Point(16, 115);
			this.encipher.Name = "encipher";
			this.encipher.Size = new System.Drawing.Size(75, 23);
			this.encipher.TabIndex = 3;
			this.encipher.Text = "zašifrovat";
			this.encipher.UseVisualStyleBackColor = true;
			this.encipher.Click += new System.EventHandler(this.encipher_Click);
			// 
			// decipher
			// 
			this.decipher.Location = new System.Drawing.Point(99, 115);
			this.decipher.Name = "decipher";
			this.decipher.Size = new System.Drawing.Size(75, 23);
			this.decipher.TabIndex = 4;
			this.decipher.Text = "odšifrovat";
			this.decipher.UseVisualStyleBackColor = true;
			this.decipher.Click += new System.EventHandler(this.decipher_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "klíè:";
			// 
			// key
			// 
			this.key.Location = new System.Drawing.Point(74, 66);
			this.key.Name = "key";
			this.key.Size = new System.Drawing.Size(100, 20);
			this.key.TabIndex = 2;
			// 
			// checkBoxReverse
			// 
			this.checkBoxReverse.AutoSize = true;
			this.checkBoxReverse.Location = new System.Drawing.Point(74, 92);
			this.checkBoxReverse.Name = "checkBoxReverse";
			this.checkBoxReverse.Size = new System.Drawing.Size(15, 14);
			this.checkBoxReverse.TabIndex = 8;
			this.checkBoxReverse.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "obrátit:";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(188, 154);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkBoxReverse);
			this.Controls.Add(this.key);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.decipher);
			this.Controls.Add(this.encipher);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ciphered);
			this.Controls.Add(this.original);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormMain";
			this.Text = "Caesar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox original;
		private System.Windows.Forms.TextBox ciphered;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button encipher;
		private System.Windows.Forms.Button decipher;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox key;
		private System.Windows.Forms.CheckBox checkBoxReverse;
		private System.Windows.Forms.Label label4;
	}
}

