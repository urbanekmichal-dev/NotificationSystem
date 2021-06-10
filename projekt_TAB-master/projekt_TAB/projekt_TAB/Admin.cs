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
    public partial class Admin : Form
    {
        Main parent;
        public Admin(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }

        private void backgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
