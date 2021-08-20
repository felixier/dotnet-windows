using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoGlobalPerformanceTest
{
	public partial class PerformanceTestForm : Form
	{
		public PerformanceTestForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TestPerformance();
		}

		private void TestPerformance()
		{
			string directory = GetDirectory();
			if (directory != null)
			{
				string testFilename = GetTestFilename(directory);
				byte[] testData = GetTestData(40000000);
				for (int i = 0; i < 2; i++)
				{
					Console.WriteLine("Writing");
					var t1 = DateTime.UtcNow;
					File.WriteAllBytes(testFilename, testData);
					var t2 = DateTime.UtcNow;
					Console.WriteLine(string.Format("Reading (writing time: {0})", (t2 - t1).ToString()));
					t1 = DateTime.UtcNow;
					testData = File.ReadAllBytes(testFilename);
					t2 = DateTime.UtcNow;
					Console.WriteLine(string.Format("Finished (reading time: {0})", (t2-t1).ToString()));
					ModifyTestData(testData);
				}
			} 
		}

		private string GetDirectory()
		{
			using (FolderBrowserDialog dialog = new FolderBrowserDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					return dialog.SelectedPath;
				}
				else
				{
					return null;
				}
			}
		}

		private string GetTestFilename(string directory)
		{
			int i = 1;
			string file = null;
			do
			{
				file = Path.Combine(directory, string.Format("test{0}.tmp", i++));
			} while (File.Exists(file));
			return file;
		}

		private byte[] GetTestData(int length)
		{
			Random random = new Random();
			byte[] testData = new byte[length];
			random.NextBytes(testData);
			return testData;
		}

		private void ModifyTestData(byte[] testData)
		{
			int length = testData.Length;
			for (int i = 0; i < length; i++)
			{
				testData[i] = (byte)((testData[i] + 1) % 0xFF);
			}
		}
	}
}
