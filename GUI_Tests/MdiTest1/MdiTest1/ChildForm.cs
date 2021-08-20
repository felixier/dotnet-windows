using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MdiTest1
{
	public partial class ChildForm : Form
	{
		#region Fields

		private static int windowNumber = 1;
		private Form parentBackup;
		private SystemMenu systemMenu;

		#endregion    // Fields

		public ChildForm()
		{
			InitializeComponent();

			this.Text += " " + windowNumber.ToString("00");
			windowNumber++;

			this.buttonParent.Click += (s,e) => Inparent();
			this.buttonUnparent.Click += (s,e) => Unparent();
		}

		#region Methods

		protected override void WndProc(ref Message msg)
		{
			base.WndProc(ref msg);

			// Let it know all messages so it can handle WM_SYSCOMMAND
			// (This method is inlined)
			systemMenu?.HandleMessage(ref msg);
		}

		private void Unparent()
		{
			if (MdiParent != null)
			{
				parentBackup = MdiParent;
				this.MdiParent = null;

				// Create instance and connect it with the Form
				systemMenu = new SystemMenu(this);

				// Define commands and handler methods
				// (Deferred until HandleCreated if it's too early)
				// IDs are counted internally, separator is optional
				systemMenu.AddCommand("&Parent", () => Inparent(), true);
			}
		}

		private void Inparent()
		{
			if (MdiParent == null)
			{
				this.MdiParent = parentBackup;
			}
		} 

		#endregion // Methods
	}
}
