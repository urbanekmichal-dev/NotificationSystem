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
    public partial class AccMan : Form
    {
        Main parent;
        public AccMan(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Test");
            treeView1.Nodes[0].ForeColor = System.Drawing.Color.Red;
            treeView1.Nodes[0].Nodes.Add("Issue to assign");
            treeView1.Nodes[0].Nodes.Add("Issue open");
            treeView1.Nodes[0].Nodes.Add("Issue in progress");
            treeView1.Nodes[0].Nodes.Add("Issue finish");
            treeView1.Nodes[0].Nodes.Add("Issue closed");
            treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.DarkOrange;
            treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Purple;
            treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Green;
            treeView1.Nodes[0].Nodes[4].ForeColor = System.Drawing.Color.Red;
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Task 1");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Task 2");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Task 3");
            treeView1.Nodes[0].Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Red;
            treeView1.Nodes[0].Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Yellow;
            treeView1.Nodes[0].Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Green;



            treeView1.Nodes.Add("Test2");
            treeView1.Nodes[1].ForeColor = System.Drawing.Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Request(parent, "AccMan"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Sys(parent));
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Sys(parent));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Issue(parent, "AccMan"));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
