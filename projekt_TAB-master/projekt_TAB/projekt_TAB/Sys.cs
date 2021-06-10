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
    public partial class Sys : Form
    {
        Main parent;

        public Sys(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;

        }

        private void Sys_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to apply changes?", "Caution", buttons);
            if (result == DialogResult.Yes)
            {
                parent.openChildForm(new AccMan(parent));

                //plus pobranie zmian
            }
            else
            {

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new AccMan(parent));
        }
    }
}
