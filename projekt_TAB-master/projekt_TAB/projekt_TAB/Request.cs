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
    public partial class Request : Form
    {
        Main parent;
        String origin;
        public Request(Main parentIn, String _origin)
        {
            InitializeComponent();
            parent = parentIn;
            origin = _origin;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Request_Load(object sender, EventArgs e)
        {

        }

        private void confirmRequestButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to apply changes?", "Caution", buttons);
            if (result == DialogResult.Yes)
            {
                if (origin == "AccMan")
                    parent.openChildForm(new AccMan(parent));
                if (origin == "Client")
                    parent.openChildForm(new Client(parent));

                //plus pobranie zmian
            }
            else
            {

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (origin == "AccMan")
                parent.openChildForm(new AccMan(parent));
            if (origin == "Client")
                parent.openChildForm(new Client(parent));
        }
    }
}
