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
    public partial class Task : Form
    {
        Main parent;
        String origin;
        public Task(Main parentIn, String _origin)
        {
            InitializeComponent();
            parent = parentIn;
            origin = _origin;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Task_Load(object sender, EventArgs e)
        {

        }

        private void confirmTaskButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to apply changes?", "Caution", buttons);
            if (result == DialogResult.Yes)
            {
                if (origin == "Worker")
                    parent.openChildForm(new Worker(parent));
                if (origin == "ProdMan")
                    parent.openChildForm(new ProdMan(parent));

                //plus pobranie zmian
            }
            else
            {

            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (origin == "Worker")
                parent.openChildForm(new Worker(parent));
            if (origin == "ProdMan")
                parent.openChildForm(new ProdMan(parent));
        }
    }
}
