using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiTest2
{
	public partial class Form2 : Form
	{
		#region Fields

		private Form mdiParent;
		private SystemMenu systemMenu;

		#endregion // Fields

		public Form2()
		{
			InitializeComponent();
		}

		#region Methods

		protected override void WndProc(ref Message msg)
		{
			base.WndProc(ref msg);

			// Let it know all messages so it can handle WM_SYSCOMMAND
			// (This method is inlined)
			systemMenu?.HandleMessage(ref msg);
		}


		internal void Inparent(object sender, EventArgs e)
		{
			if (MdiParent == null)
			{
				MdiParent = mdiParent;
			}
		}

		internal void Unparent(object sender, EventArgs e)
		{
			if (MdiParent != null)
			{
				mdiParent = MdiParent;
				MdiParent = null;

				// Create instance and connect it with the Form
				systemMenu = new SystemMenu(this);

				// Define commands and handler methods
				// (Deferred until HandleCreated if it's too early)
				// IDs are counted internally, separator is optional
				systemMenu.AddCommand("&Parent", () => Inparent(this, EventArgs.Empty), true);
			}
		}

		#endregion // Methods
	}
}
