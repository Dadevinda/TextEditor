﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Blue;
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Stop();
                Form3 hii = new Form3();
                hii.Show();
                Hide();
            }
        }
    }
}
