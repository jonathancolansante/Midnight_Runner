﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RST
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
            form1.Closed += (s, args) => this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Global.btn1 = false;
            Global.btn2 = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Show();
            form4.Closed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form5 = new Form5();
            form5.Show();
            form5.Closed += (s, args) => this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
