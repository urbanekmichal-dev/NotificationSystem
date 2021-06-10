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

    public partial class User : Form
    {
        Main parent;
        public User(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void confirmUserButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to apply changes?", "Caution", buttons);
            if (result == DialogResult.Yes)
            {
                parent.openChildForm(new Admin(parent));

                //plus pobranie zmian
            }
            else
            {

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Admin(parent));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void activeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void firstnameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
