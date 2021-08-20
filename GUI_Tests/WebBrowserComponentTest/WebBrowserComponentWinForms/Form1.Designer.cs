namespace WebBrowserComponentWinForms
{
	partial class FormWebBrowser
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
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			this.panelUrl = new System.Windows.Forms.Panel();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.panelUrl.SuspendLayout();
			this.SuspendLayout();
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 40);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(983, 586);
			this.webBrowser.TabIndex = 0;
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxUrl.Location = new System.Drawing.Point(0, 0);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(983, 20);
			this.textBoxUrl.TabIndex = 1;
			// 
			// panelUrl
			// 
			this.panelUrl.AutoSize = true;
			this.panelUrl.Controls.Add(this.textBoxUrl);
			this.panelUrl.Controls.Add(this.buttonBrowse);
			this.panelUrl.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUrl.Location = new System.Drawing.Point(0, 0);
			this.panelUrl.Name = "panelUrl";
			this.panelUrl.Size = new System.Drawing.Size(983, 40);
			this.panelUrl.TabIndex = 2;
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonBrowse.Location = new System.Drawing.Point(0, 20);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(983, 20);
			this.buttonBrowse.TabIndex = 2;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// FormWebBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 626);
			this.Controls.Add(this.webBrowser);
			this.Controls.Add(this.panelUrl);
			this.Name = "FormWebBrowser";
			this.Text = "Web Browser";
			this.panelUrl.ResumeLayout(false);
			this.panelUrl.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.TextBox textBoxUrl;
		private System.Windows.Forms.Panel panelUrl;
		private System.Windows.Forms.Button buttonBrowse;
	}
}

