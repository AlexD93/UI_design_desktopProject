using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_design_assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start();

            var pos = this.PointToScreen(label2.Location);
            pos = pictureBox3.PointToClient(pos);
            label2.Parent = pictureBox3;
            label2.Location = pos;
            label2.BackColor = Color.Transparent;

            Login login = new Login();
            login.ShowDialog();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Cmd.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel.exe");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Powerpnt.exe");
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            DialogResult result1 = MessageBox.Show("Feed your plant and take a rest!", "Important!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("Good job!"); 
            }
            else
            {
                MessageBox.Show("Your plan in trouble!", "Trouble");
            }
     
            //Application.Exit().
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Call you mom, she is waiting!", "Important!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("Good son!");
            }
            else
            {
                MessageBox.Show("Bad son!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to drink somw coffee sir?", "Coffee brack", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("You coffee is ready and waiting for you at kitchen!");
            }
            else
            {
                MessageBox.Show("As you wish =)");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lab.msdn.microsoft.com/mailform/contactus.aspx");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Move back to previous page?", "Important!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("Previous page appears");
            }
            else
            {
                MessageBox.Show("Ok, lets stay here");
            }
        }
    }
}