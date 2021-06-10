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
    public partial class ProdMan : Form
    {
        Main parent;

        public ProdMan(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
        }

        private void CreateTask_Click(object sender, EventArgs e)
        {
                parent.openChildForm(new Task(parent, "ProdMan"));
                //parent.openChildForm(new Task(parent));
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (issueTaskTreeView.Nodes.Count != 3)
            {

                issueTaskTreeView.Nodes.Add("Issue 1");
                issueTaskTreeView.Nodes[0].Nodes.Add("Task 1");
                issueTaskTreeView.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Green;
                issueTaskTreeView.Nodes[0].ForeColor = System.Drawing.Color.Green;

                issueTaskTreeView.Nodes.Add("Issue 2");
                issueTaskTreeView.Nodes[1].Nodes.Add("Task 1");
                issueTaskTreeView.Nodes[1].Nodes.Add("Task 2");
                issueTaskTreeView.Nodes[1].Nodes.Add("Task 3");
                issueTaskTreeView.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Green;
                issueTaskTreeView.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Red;
                issueTaskTreeView.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Purple;
                issueTaskTreeView.Nodes[1].ForeColor = System.Drawing.Color.Red;

                issueTaskTreeView.Nodes.Add("Formatka");
                issueTaskTreeView.Nodes[2].Nodes.Add("Task to assign");//darkorange
                issueTaskTreeView.Nodes[2].Nodes.Add("Task open");//black
                issueTaskTreeView.Nodes[2].Nodes.Add("Task in progress");//purple
                issueTaskTreeView.Nodes[2].Nodes.Add("Task finished");//green
                issueTaskTreeView.Nodes[2].Nodes.Add("Task canceled");//red
                issueTaskTreeView.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.DarkOrange;
                issueTaskTreeView.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
                issueTaskTreeView.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Purple;
                issueTaskTreeView.Nodes[2].Nodes[3].ForeColor = System.Drawing.Color.Green;
                issueTaskTreeView.Nodes[2].Nodes[4].ForeColor = System.Drawing.Color.Red;
                issueTaskTreeView.Nodes[2].ForeColor = System.Drawing.Color.Blue;

            }
        }
    }
}
