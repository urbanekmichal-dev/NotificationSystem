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
    public partial class Issue : Form
    {
        Main parent;
        String origin;
        public Issue(Main parentIn,String _origin)
        {
            InitializeComponent();
            parent = parentIn;
            origin = _origin;


        }

        private void Issue_Load(object sender, EventArgs e)
        {

        }

        private void confirmIssueButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to apply changes?", "Caution", buttons);
            if (result == DialogResult.Yes)
            {
                if(origin=="AccMan")
                    parent.openChildForm(new AccMan(parent));
                if (origin == "ProdMan")
                    parent.openChildForm(new ProdMan(parent));

                //plus pobranie zmian
            }
            else
            {
                 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (origin == "AccMan")
                parent.openChildForm(new AccMan(parent));
            if (origin == "ProdMan")
                parent.openChildForm(new ProdMan(parent));
        }
    }
}
