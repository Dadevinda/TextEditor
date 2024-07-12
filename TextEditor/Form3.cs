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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1.Start();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           label2.Text=DateTime.Now.ToShortTimeString();
            label3.Text=DateTime.Now.ToShortDateString();


            DateTime ha = DateTime.Now;
            if (ha.Hour <= 12) 
            {
                label4.Text="Good Morning";
            }
            else if(ha.Hour<=16)
            {
                label4.Text = "Good Afternoon";
            }
            else if(ha.Hour<=20)
            {
                label4.Text = "Good Evening";
            }
            else if (ha.Hour <= 24)
            {
                label4.Text = "Good Night";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           userControl11.Hide();
            userControl21.Hide();
            newpages1.Show();
            newpages1.BringToFront();
            userControl31.Hide();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            button2.BackColor= Color.LightBlue;
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            button3.BackColor= Color.LightBlue;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor= Color.White;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            newpages1.Hide();
            userControl31.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            newpages1.Hide();
            userControl31.Hide();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            button1.BackColor=Color.White;
            button2.BackColor=Color.White;
            button3.BackColor = Color.White;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;


            userControl21.Show();
            userControl21.BringToFront();
            userControl11.Hide();
            newpages1.Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.BringToFront();
            userControl21.Hide();
            newpages1.Hide();
            userControl31.Show();
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
