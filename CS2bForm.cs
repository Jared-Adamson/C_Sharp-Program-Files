//Jared Adamson

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void crbtn_Click(object sender, EventArgs e)
        {
            departmentlbl.Text = "Customer Relations";
            contactlbl.Text = "Tricia Smith";
            phonelbl.Text = "500-1111";
        }

        private void opbtn_Click(object sender, EventArgs e)
        {
            departmentlbl.Text = "Order Processing";
            contactlbl.Text = "Kenna Ross";
            phonelbl.Text = "500-3333";
        }

        private void mbtn_Click(object sender, EventArgs e)
        {
            departmentlbl.Text = "Marketing";
            contactlbl.Text = "Michelle Tyler";
            phonelbl.Text = "500-2222";
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            departmentlbl.Text = "Shipping";
            contactlbl.Text = "Eric Johnson";
            phonelbl.Text = "500-4444";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
