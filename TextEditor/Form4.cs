using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TextEditor
{
    public partial class Form4 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form4()
        {
            InitializeComponent();
           
        }
        
        public void updatecolor1()
        {
            richTextBox1.BackColor = Color.Yellow;
        }
        public void updatecolor2()
        {
            richTextBox1.BackColor = Color.Black;
        }
        public void updatecolor3()
        {
            richTextBox1.BackColor = Color.White;
        }
        public void updatecolor4()
        {
            richTextBox1.BackColor = Color.LightBlue;
        }
        public void update5()
        {
            richTextBox1.BackColor = Color.LimeGreen;
        }
        public void update6()
        {
            richTextBox1.BackColor = Color.Pink;
        }
        public void load1()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txtfiles(*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 0;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                string read = System.IO.File.ReadAllText(ofd.FileName);
                richTextBox1.Text = read;
            }
        }

        string[] paths, files;
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = String.Empty;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = Clipboard.GetText();
            richTextBox1.Text = richTextBox1.Text + s;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control==true && e.KeyCode == Keys.X)
            {
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.SelectedText=String.Empty;
            }
            else if(e.Control==true&&e.KeyCode == Keys.C)
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
            else if(e.Control==true&&e.KeyCode==Keys.V)
            {
                string x =Clipboard.GetText();
                Clipboard.Clear();
                richTextBox1.Text = richTextBox1.Text + x;
            }
            else if (e.Control == true && e.KeyCode == Keys.A)
            {
                richTextBox1.SelectAll();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = false;
            
            label7.BackColor=Color.White;
            label7.ForeColor = Color.SteelBlue;

            label1.BackColor = Color.SteelBlue;
            label1.ForeColor = Color.White;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
           
            
            label7.BackColor = Color.SteelBlue;
            label7.ForeColor = Color.White;

            label1.BackColor = Color.White;
            label1.ForeColor = Color.SteelBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           richTextBox1.Text= richTextBox1.SelectedText.ToUpper();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=richTextBox1.SelectedText.ToLower();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string d = comboBox1.SelectedText;
            float c = float.Parse(comboBox2.SelectedItem.ToString());
            richTextBox1.SelectionFont = new Font(d, c, FontStyle.Italic);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (FontFamily Font in FontFamily.Families)
            {
                comboBox1.Items.Add(Font.Name.ToString());
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size);
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily,float.Parse(comboBox2.SelectedItem.ToString()));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string d = comboBox1.SelectedText;
            float c = float.Parse(comboBox2.SelectedItem.ToString());
            richTextBox1.SelectionFont = new Font(d,c,FontStyle.Bold);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            string d = comboBox1.SelectedText;
            float c = float.Parse(comboBox2.SelectedItem.ToString());
            richTextBox1.SelectionFont = new Font(d, c, FontStyle.Underline);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[listBox1.SelectedIndex];
            player.controls.play(); 

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
            panel6.Visible= false;
            player.controls.stop();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = MessageBox.Show("Do you want to save the changes","Save", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                DialogResult er = MessageBox.Show("Confirm","Save",MessageBoxButtons.OK,MessageBoxIcon.Question);
                   if(er==DialogResult.OK && label13.Text=="Black")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.Black;
                    panel8.BackColor = Color.Black;
                }
                else if (er == DialogResult.OK && label13.Text == "Red")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.Red;
                    panel8.BackColor = Color.Red;
                }
                else if (er == DialogResult.OK && label13.Text == "Yellow")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.Yellow;
                    panel8.BackColor = Color.Yellow;
                }
                else if (er == DialogResult.OK && label13.Text == "Green")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.Green;
                    panel8.BackColor = Color.Green;
                }
                else if (er == DialogResult.OK && label13.Text == "Gray")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.Gray;
                    panel8.BackColor = Color.Gray;
                }
                else if (er == DialogResult.OK && label13.Text == "DarkBlue")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.DarkBlue;
                    panel8.BackColor = Color.DarkBlue;
                }
                else if (er == DialogResult.OK && label13.Text == "LightBlue")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.LightBlue;
                    panel8.BackColor = Color.LightBlue;
                }
                else if (er == DialogResult.OK && label13.Text == "SteelBlue")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.SteelBlue;
                    panel8.BackColor = Color.SteelBlue;
                }
                else if (er == DialogResult.OK && label13.Text == "Brown")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.Brown;
                    panel8.BackColor = Color.Brown;
                }
                else if (er == DialogResult.OK && label13.Text == "Purple")
                {
                    panel10.Visible = false;
                    panel6.BackColor = Color.Purple;
                    panel8.BackColor = Color.Purple;
                }


            }
            else if(dr==DialogResult.No)
            {
                panel10.Visible = true;
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label13.Text = "Black";
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label13.Text = "DarkBlue";
    
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label13.Text = "LightBlue";
          
        }

        private void button8_Click(object sender, EventArgs e)
        {

            label13.Text = "SteelBlue";
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label13.Text = "Gray";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label13.Text = "Yellow";
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label13.Text = "Green";
         
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label13.Text = "Brown";
         
        }

        private void button11_Click(object sender, EventArgs e)
        {

            label13.Text = "Purple";
        
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label13.Text = "Red";
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to saave?","Save",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txtfiles(*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                // files = save.FileNames;
                {
                    System.IO.File.WriteAllText(save.FileName, richTextBox1.Text);
                }

            }

            else if (dr == DialogResult.No)

            { this.Hide(); }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 HII = new Form3();
            HII.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

          richTextBox1.SelectionColor= Color.Red;
           

        }

        private void button13_Click(object sender, EventArgs e)
        {

            richTextBox1.SelectionColor = Color.Blue;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Silver;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Orange;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Yellow;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Purple;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Gray;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Maroon;

        }

        private void button25_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Olive;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Lime;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Teal;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.SteelBlue;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Cyan;

        }

        private void button29_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.DarkOrchid;

        }

        private void button27_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.DarkRed;

        }

        private void button30_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.DarkKhaki;

        }

        private void button26_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.DarkSlateGray;

        }

        private void button28_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.SeaGreen;

        }

        private void button31_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Indigo;

        }

        private void button32_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Violet;

        }


        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 hii = new Form4();
            hii.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txtfiles(*.txt)|*.txt|All files (*.*)|*.*";
            if(save.ShowDialog()==DialogResult.OK)
               // files = save.FileNames;
            {
                System.IO.File.WriteAllText(save.FileName, richTextBox1.Text);
            }

        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox1.Text, 8);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont=new Font(comboBox2.Text, 22);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox2.Text, 18);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox2.Text, 14);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            string d = comboBox1.SelectedText;
            float c = float.Parse(comboBox2.SelectedItem.ToString());
            richTextBox1.SelectionFont = new Font(d, c, FontStyle.Regular);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect= true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                paths= ofd.FileNames;
                files=ofd.FileNames;
            }
            for(int x = 0;x< files.Length;x++)
            {
                listBox1.Items.Add(files[x]);
            }
        }
    }
}
