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
    public partial class Worker : Form
    {
        Main parent;
        public Worker(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out", "Result");
                parent.openChildForm(new Main());
            }
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Task(parent, "Worker"));
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            
            taskTreeView.Nodes.Add("Issue 1");
            taskTreeView.Nodes[0].Nodes.Add("Task 1");
            taskTreeView.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Green;
            taskTreeView.Nodes[0].ForeColor = System.Drawing.Color.Green;

            taskTreeView.Nodes.Add("Issue 2");
            taskTreeView.Nodes[1].Nodes.Add("Task 1");
            taskTreeView.Nodes[1].Nodes.Add("Task 2");
            taskTreeView.Nodes[1].Nodes.Add("Task 3");
            taskTreeView.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Green;
            taskTreeView.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Red;
            taskTreeView.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Purple;
            taskTreeView.Nodes[1].ForeColor = System.Drawing.Color.Red;

            taskTreeView.Nodes.Add("Formatka");
            taskTreeView.Nodes[2].Nodes.Add("Task to assign");//darkorange
            taskTreeView.Nodes[2].Nodes.Add("Task open");//black
            taskTreeView.Nodes[2].Nodes.Add("Task in progress");//purple
            taskTreeView.Nodes[2].Nodes.Add("Task finished");//green
            taskTreeView.Nodes[2].Nodes.Add("Task canceled");//red
            taskTreeView.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.DarkOrange;
            taskTreeView.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            taskTreeView.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Purple;
            taskTreeView.Nodes[2].Nodes[3].ForeColor = System.Drawing.Color.Green;
            taskTreeView.Nodes[2].Nodes[4].ForeColor = System.Drawing.Color.Red;
            taskTreeView.Nodes[2].ForeColor = System.Drawing.Color.Blue;
        }
    }
}
