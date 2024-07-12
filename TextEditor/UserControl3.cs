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
    
    public partial class UserControl3 : UserControl
    {
       Form4 f4 = new Form4();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
                f4.load1();
                f4.Show();
                Parent.Hide();

            
        }
    }
}
