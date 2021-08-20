namespace MdiTest1
{
	partial class ChildForm
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
			this.buttonUnparent = new System.Windows.Forms.Button();
			this.buttonParent = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonUnparent
			// 
			this.buttonUnparent.Location = new System.Drawing.Point(12, 41);
			this.buttonUnparent.Name = "buttonUnparent";
			this.buttonUnparent.Size = new System.Drawing.Size(75, 23);
			this.buttonUnparent.TabIndex = 0;
			this.buttonUnparent.Text = "Unparent";
			this.buttonUnparent.UseVisualStyleBackColor = true;
			// 
			// buttonParent
			// 
			this.buttonParent.Location = new System.Drawing.Point(12, 12);
			this.buttonParent.Name = "buttonParent";
			this.buttonParent.Size = new System.Drawing.Size(75, 23);
			this.buttonParent.TabIndex = 1;
			this.buttonParent.Text = "Parent";
			this.buttonParent.UseVisualStyleBackColor = true;
			// 
			// ChildForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.buttonParent);
			this.Controls.Add(this.buttonUnparent);
			this.Name = "ChildForm";
			this.Text = "Child Form";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonUnparent;
		private System.Windows.Forms.Button buttonParent;
	}
}