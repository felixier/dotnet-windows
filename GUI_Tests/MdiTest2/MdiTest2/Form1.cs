using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace MdiTest2
{
	public partial class Form1 : Form
	{
		private int counter = 1;
		private TabbedMDIManager man;

		public Form1()
		{
			InitializeComponent();

			man = new TabbedMDIManager();
			man.AttachedTo = this;
			man.ContextMenuItem.Items.Add(new BarItem("Unparent", Unparent));
		}

		private void Unparent(object sender, EventArgs e)
		{
			(this.ActiveMdiChild as Form2).Unparent(sender, e);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new Form2();
			f.Text = "Test " + (counter++).ToString();
			f.MdiParent = this;
			f.Show();
		}
	}
}
