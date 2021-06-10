
namespace projekt_TAB
{
    partial class Client
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
            this.deactivateButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.createRequestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.requestTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // deactivateButton
            // 
            this.deactivateButton.Location = new System.Drawing.Point(439, 5);
            this.deactivateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deactivateButton.Name = "deactivateButton";
            this.deactivateButton.Size = new System.Drawing.Size(72, 28);
            this.deactivateButton.TabIndex = 0;
            this.deactivateButton.Text = "Deactivate";
            this.deactivateButton.UseVisualStyleBackColor = true;
            this.deactivateButton.Click += new System.EventHandler(this.DeactivateButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(515, 5);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(64, 28);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // createRequestButton
            // 
            this.createRequestButton.Location = new System.Drawing.Point(261, 330);
            this.createRequestButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createRequestButton.Name = "createRequestButton";
            this.createRequestButton.Size = new System.Drawing.Size(101, 28);
            this.createRequestButton.TabIndex = 2;
            this.createRequestButton.Text = "Create request";
            this.createRequestButton.UseVisualStyleBackColor = true;
            this.createRequestButton.Click += new System.EventHandler(this.CreateRequestButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request list";
            // 
            // requestTreeView
            // 
            this.requestTreeView.Location = new System.Drawing.Point(13, 36);
            this.requestTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.requestTreeView.Name = "requestTreeView";
            this.requestTreeView.Size = new System.Drawing.Size(566, 290);
            this.requestTreeView.TabIndex = 4;
            this.requestTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.requestTreeView_AfterSelect);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.requestTreeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createRequestButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.deactivateButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deactivateButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button createRequestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView requestTreeView;
    }
}