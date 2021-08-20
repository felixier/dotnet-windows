using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QueryBuilder
{
	public partial class Form1 : Form
	{
		string[] items;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FillItems();
			SelectTxt.Text = SelectText();
			InsertTxt.Text = InsertText();
			UpdateTxt.Text = UpdateText();
			ParmsTxt.Text = ParmsText();
		}

		void FillItems()
		{
			items = InputTxt.Text.Split(new string[] { ", " }, System.StringSplitOptions.None);
		}

		string MakeParm(string item)
		{
			string x = string.Format("@{0}{1}", char.ToUpper(item[0]), item.Substring(1));
			return x;
		}

		string SelectText()
		{
			StringBuilder sb = new StringBuilder(string.Format("private const string SQL_SELECT_{0} = \"SELECT ", TableName.Text.ToUpper()));
			for(int i = 0; i < items.Length - 1; i++)
			{
				sb.Append(string.Format("{0}, ", items[i]));
			}
			sb.Append(items[items.Length - 1]);
			sb.Append(string.Format(" FROM {0} WHERE \";", TableName.Text));
			return sb.ToString();
		}

		string InsertText()
		{
			StringBuilder sb = new StringBuilder(string.Format("private const string SQL_INSERT_{0} = \"INSERT INTO {1}(", TableName.Text.ToUpper(), TableName.Text));
			for(int i = 0; i < items.Length - 1; i++)
			{
				sb.Append(string.Format("{0}, ", items[i]));
			}
			sb.Append(items[items.Length - 1]);
			sb.Append(") VALUES(");
			for(int i = 0; i < items.Length - 1; i++)
			{
				sb.Append(string.Format("{0}, ", MakeParm(items[i])));
			}
			sb.Append(MakeParm(items[items.Length - 1]));
			sb.Append(")\";");
			return sb.ToString();
		}

		string UpdateText()
		{
			StringBuilder sb = new StringBuilder(string.Format("private const string SQL_UPDATE_{0} = \"UPDATE {1} SET ", TableName.Text.ToUpper(), TableName.Text));
			for(int i = 0; i < items.Length - 1; i++)
			{
				sb.Append(string.Format("{0} = {1}, ", items[i], MakeParm(items[i])));
			}
			sb.Append(string.Format("{0} = {1} ", items[items.Length - 1], MakeParm(items[items.Length - 1])));
			sb.Append("WHERE \";");
			return sb.ToString();
		}

		string ParmsText()
		{
			StringBuilder sb = new StringBuilder();
			foreach(string item in items)
			{
				sb.Append(string.Format("private const string PARM_{0} = \"{1}\";\r\n", item.ToUpper(), MakeParm(item)));

			}
			return sb.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(SelectTxt.Text);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(InsertTxt.Text);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(UpdateTxt.Text);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(ParmsTxt.Text);
		}
	}
}