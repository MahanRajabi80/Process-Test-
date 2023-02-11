using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Example_4_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------
        Process p = new Process();
        //--------------------------------------------------------------
        private void btnCalc_Click(object sender, EventArgs e)
        {
            p.Close();
            p.StartInfo.FileName = "calc.exe";
            p.Start();
        }
        //--------------------------------------------------------------
        private void btnD_Click(object sender, EventArgs e)
        {
            p.Close();
            p.StartInfo.FileName = "D:";
            p.Start();
        }
        //--------------------------------------------------------------
        private void btnPaint_Click(object sender, EventArgs e)
        {
            p.Close();
            p.StartInfo.FileName = "mspaint.exe";
            p.Start();
        }
        //--------------------------------------------------------------
        private void btnFile_Click(object sender, EventArgs e)
        {
            string s = txtFile.Text;
            p.Close();
            p.StartInfo.FileName = s;
            p.Start();
        }
    }
}
