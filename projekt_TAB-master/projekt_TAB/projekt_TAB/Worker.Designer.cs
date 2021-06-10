
namespace projekt_TAB
{
    partial class Worker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Description: Error on the page www.polsl.pl");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Result: Server error");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Error 404", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Description: Error while moving to the home page");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Result: Certificate error");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Error 402", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.taskTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskTreeView
            // 
            this.taskTreeView.Location = new System.Drawing.Point(13, 36);
            this.taskTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taskTreeView.Name = "taskTreeView";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Description: Error on the page www.polsl.pl";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Result: Server error";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Error 404";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Description: Error while moving to the home page";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Result: Certificate error";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Error 402";
            this.taskTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.taskTreeView.Size = new System.Drawing.Size(566, 290);
            this.taskTreeView.TabIndex = 0;
            this.taskTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tasks list";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(515, 5);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(64, 28);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(267, 330);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(56, 28);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskTreeView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Worker";
            this.Text = "Worker";
            this.Load += new System.EventHandler(this.Worker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView taskTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button updateButton;
    }
}