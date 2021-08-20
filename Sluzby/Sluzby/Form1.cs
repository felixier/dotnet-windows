using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sluzby
{
    public partial class Sluzby : Form
    {
        Process p = new Process();

        public Sluzby()
        {
            InitializeComponent();
            p.StartInfo.FileName = "net";
        }

        void StartSluzba(string jmenoSluzby)
        {
            p.StartInfo.Arguments = "start " + jmenoSluzby;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p.Start();
        }

        void StopSluzba(string jmenoSluzby)
        {
            p.StartInfo.Arguments = "stop " + jmenoSluzby;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartSluzba("W3SVC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopSluzba("W3SVC");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartSluzba("MSSQL$SQLEXPRESS");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StopSluzba("MSSQL$SQLEXPRESS");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartSluzba("MSFtpsvc");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StopSluzba("MSFtpsvc");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StartSluzba("SMTPSVC");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StopSluzba("SMTPSVC");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StartSluzba("AvSynMgr");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StopSluzba("AvSynMgr");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StartSluzba("MSDTC");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StopSluzba("MSDTC");
        }
    }
}