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
    public partial class Rejestracja : Form
    {
        Main parent;
        public Rejestracja(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }

        private void notARobotCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }
    }
}
