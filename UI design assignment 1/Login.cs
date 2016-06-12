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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtPass.Text == "28111993" && txtLogin.Text == "Alex")
                this.Close();
            else
                MessageBox.Show("User name or password invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
