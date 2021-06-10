using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_TAB
{
    public partial class Logowanie : Form
    {
        Main parent;
        public Logowanie(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "AccMan")
            {
                parent.openChildForm(new AccMan(parent));
            }
            else if (loginTextBox.Text == "ProdMan")
            {
                parent.openChildForm(new ProdMan(parent));
            }
            else if (loginTextBox.Text == "Worker")
            {
                parent.openChildForm(new Worker(parent));
            }
            else if (loginTextBox.Text == "Client")
            {
                parent.openChildForm(new Client(parent));
            }
            else if (loginTextBox.Text == "Admin")
            {
                parent.openChildForm(new Admin(parent));
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)

        {

        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {

        }

        private void noAccountButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Rejestracja(parent));
        }
    }
}
