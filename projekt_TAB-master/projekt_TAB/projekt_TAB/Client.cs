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
    public partial class Client : Form
    {
        Main parent;
        public Client(Main parentIn)
        {
            InitializeComponent();
            this.parent = parentIn;

        }

        private void CreateRequestButton_Click(object sender, EventArgs e)
        {
                parent.openChildForm(new Request(parent, "Client"));     
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var result =  MessageBox.Show("Are you sure you want to log out?", "Logout",MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out","Result");
                parent.openChildForm(new Main());
            }
            
        }

        private void Client_Load(object sender, EventArgs e)
        {
            requestTreeView.Nodes.Add("Issue 1");
            requestTreeView.Nodes[0].Nodes.Add("Task 1");
            requestTreeView.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Green;
            requestTreeView.Nodes[0].ForeColor = System.Drawing.Color.Green;

            requestTreeView.Nodes.Add("Issue 2");
            requestTreeView.Nodes[1].Nodes.Add("Task 1");
            requestTreeView.Nodes[1].Nodes.Add("Task 2");
            requestTreeView.Nodes[1].Nodes.Add("Task 3");
            requestTreeView.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Green;
            requestTreeView.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Red;
            requestTreeView.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Purple;
            requestTreeView.Nodes[1].ForeColor = System.Drawing.Color.Red;

            requestTreeView.Nodes.Add("Formatka");
            requestTreeView.Nodes[2].Nodes.Add("Task to assign");//darkorange
            requestTreeView.Nodes[2].Nodes.Add("Task open");//black
            requestTreeView.Nodes[2].Nodes.Add("Task in progress");//purple
            requestTreeView.Nodes[2].Nodes.Add("Task finished");//green
            requestTreeView.Nodes[2].Nodes.Add("Task canceled");//red
            requestTreeView.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.DarkOrange;
            requestTreeView.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            requestTreeView.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Purple;
            requestTreeView.Nodes[2].Nodes[3].ForeColor = System.Drawing.Color.Green;
            requestTreeView.Nodes[2].Nodes[4].ForeColor = System.Drawing.Color.Red;
            requestTreeView.Nodes[2].ForeColor = System.Drawing.Color.Blue;
        }

        private void DeactivateButton_Click(object sender, EventArgs e)
        {
            const string caption = "Deactivate";
            var result = MessageBox.Show("Are you sure you want to deactivate your account?", "Deactivate",MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                MessageBox.Show("You are deacivated", "Result");
                parent.openChildForm(new Main());
            }
           

        }

        private void requestTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

          
        }
    }
}
