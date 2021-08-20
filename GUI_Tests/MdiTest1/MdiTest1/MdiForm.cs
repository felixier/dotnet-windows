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
	public partial class MdiForm : Form
	{
		public MdiForm()
		{
			InitializeComponent();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new ChildForm();
			f.MdiParent = this;
			f.Show();
		}
	}
}
