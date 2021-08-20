namespace DateTimePickerTest
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
			this.dateTimePickerAdv1 = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1.Calendar)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePickerAdv1
			// 
			this.dateTimePickerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerAdv1.BorderColor = System.Drawing.Color.Empty;
			// 
			// 
			// 
			this.dateTimePickerAdv1.Calendar.AllowMultipleSelection = false;
			this.dateTimePickerAdv1.Calendar.Culture = new System.Globalization.CultureInfo("en-GB");
			this.dateTimePickerAdv1.Calendar.DaysFont = new System.Drawing.Font("Verdana", 8F);
			this.dateTimePickerAdv1.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimePickerAdv1.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dateTimePickerAdv1.Calendar.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerAdv1.Calendar.Location = new System.Drawing.Point(0, 0);
			this.dateTimePickerAdv1.Calendar.Name = "monthCalendar";
			this.dateTimePickerAdv1.Calendar.SelectedDates = new System.DateTime[0];
			this.dateTimePickerAdv1.Calendar.Size = new System.Drawing.Size(206, 174);
			this.dateTimePickerAdv1.Calendar.SizeToFit = true;
			this.dateTimePickerAdv1.Calendar.TabIndex = 0;
			this.dateTimePickerAdv1.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
			this.dateTimePickerAdv1.Calendar.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
			// 
			// 
			// 
			this.dateTimePickerAdv1.Calendar.NoneButton.Location = new System.Drawing.Point(134, 0);
			this.dateTimePickerAdv1.Calendar.NoneButton.Size = new System.Drawing.Size(72, 20);
			this.dateTimePickerAdv1.Calendar.NoneButton.Text = "None";
			// 
			// 
			// 
			this.dateTimePickerAdv1.Calendar.TodayButton.Location = new System.Drawing.Point(0, 0);
			this.dateTimePickerAdv1.Calendar.TodayButton.Size = new System.Drawing.Size(134, 20);
			this.dateTimePickerAdv1.Calendar.TodayButton.Text = "Today";
			this.dateTimePickerAdv1.DropDownImage = null;
			this.dateTimePickerAdv1.Location = new System.Drawing.Point(12, 12);
			this.dateTimePickerAdv1.MinValue = new System.DateTime(((long)(0)));
			this.dateTimePickerAdv1.Name = "dateTimePickerAdv1";
			this.dateTimePickerAdv1.Size = new System.Drawing.Size(224, 20);
			this.dateTimePickerAdv1.TabIndex = 0;
			this.dateTimePickerAdv1.Value = new System.DateTime(2015, 5, 29, 9, 54, 36, 730);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(12, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(224, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Get Current CLR Version";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(248, 91);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePickerAdv1);
			this.Name = "Form1";
			this.Text = "DateTimePickerTest";
			((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1.Calendar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dateTimePickerAdv1;
		private System.Windows.Forms.Button button1;


	}
}