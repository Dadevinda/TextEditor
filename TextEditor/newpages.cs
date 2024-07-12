using System;
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
    public partial class newpages : UserControl
    {
        Form4 F2=new Form4();
        public newpages()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            F2.updatecolor3();
            F2.Show();
            Parent.Hide();
        }

        private void blank_Click(object sender, EventArgs e)
        {
           
        }

        private void blank_DoubleClick_1(object sender, EventArgs e)
        {
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;
            c4.Visible = true;
            c5.Visible = true;
            c6.Visible = true;
        }

        private void blank_Click_1(object sender, EventArgs e)
        {
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
        }

        private void c4_Click(object sender, EventArgs e)
        {
            F2.updatecolor1();
            F2.Show();
            Parent.Hide();
        }

        private void c2_Click(object sender, EventArgs e)
        {
            F2.updatecolor2();
            F2.Show();
            Parent.Hide();
        }

        private void c3_Click(object sender, EventArgs e)
        {
            F2.updatecolor4();
            F2.Show();
            Parent.Hide();

        }

        private void c5_Click(object sender, EventArgs e)
        {
            F2.update5();
            F2.Show();
            Parent.Hide();
            
        }

        private void c6_Click(object sender, EventArgs e)
        {
            F2.update6();
            F2.Show();
            Parent.Hide();
        }
    }
}
