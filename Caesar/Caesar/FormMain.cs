using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Caesar
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void encipher_Click(object sender, EventArgs e)
		{
			try
			{
				if(original.Text.Length != Caesar.Ceasar.LENGTH || key.Text.Length != Caesar.Ceasar.LENGTH)
				{
					throw new FormatException();
				}
				ciphered.Text = Ceasar.Encipher(original.Text, key.Text, checkBoxReverse.Checked);
			}
			catch(FormatException)
			{
				MessageBox.Show("Špatný formát vstupních dat!");
			}
		}

		private void decipher_Click(object sender, EventArgs e)
		{
			try
			{
				if(ciphered.Text.Length != Caesar.Ceasar.LENGTH || key.Text.Length != Caesar.Ceasar.LENGTH)
				{
					throw new FormatException();
				}
				original.Text = Ceasar.Decipher(ciphered.Text, key.Text, checkBoxReverse.Checked);
			}
			catch(FormatException)
			{
				MessageBox.Show("Špatný formát vstupních dat!");
			}
		}
	}
}