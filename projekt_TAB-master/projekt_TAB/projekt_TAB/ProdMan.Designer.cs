
namespace projekt_TAB
{
    partial class ProdMan
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
            this.issueTaskTreeView = new System.Windows.Forms.TreeView();
            this.ListOfIssue = new System.Windows.Forms.Label();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.Worker = new System.Windows.Forms.Label();
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // issueTaskTreeView
            // 
            this.issueTaskTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueTaskTreeView.Location = new System.Drawing.Point(22, 40);
            this.issueTaskTreeView.Name = "issueTaskTreeView";
            this.issueTaskTreeView.Size = new System.Drawing.Size(308, 275);
            this.issueTaskTreeView.TabIndex = 0;
            // 
            // ListOfIssue
            // 
            this.ListOfIssue.AutoSize = true;
            this.ListOfIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListOfIssue.Location = new System.Drawing.Point(18, 7);
            this.ListOfIssue.Name = "ListOfIssue";
            this.ListOfIssue.Size = new System.Drawing.Size(115, 24);
            this.ListOfIssue.TabIndex = 1;
            this.ListOfIssue.Text = "List of Issues";
            // 
            // createTaskButton
            // 
            this.createTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTaskButton.Location = new System.Drawing.Point(120, 329);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(102, 28);
            this.createTaskButton.TabIndex = 2;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.CreateTask_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateButton.Location = new System.Drawing.Point(440, 286);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 28);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutButton.Location = new System.Drawing.Point(496, 6);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(77, 28);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ID.Location = new System.Drawing.Point(405, 47);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 17);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Type.Location = new System.Drawing.Point(390, 72);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 17);
            this.Type.TabIndex = 6;
            this.Type.Text = "Type";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.Location = new System.Drawing.Point(437, 47);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 17);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "id";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeLabel.Location = new System.Drawing.Point(437, 72);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(35, 17);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "type";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Status.Location = new System.Drawing.Point(382, 98);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(48, 17);
            this.Status.TabIndex = 9;
            this.Status.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(440, 95);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(116, 24);
            this.statusComboBox.TabIndex = 10;
            // 
            // Worker
            // 
            this.Worker.AutoSize = true;
            this.Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Worker.Location = new System.Drawing.Point(377, 127);
            this.Worker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(54, 17);
            this.Worker.TabIndex = 11;
            this.Worker.Text = "Worker";
            // 
            // workerComboBox
            // 
            this.workerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(440, 124);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(116, 24);
            this.workerComboBox.TabIndex = 12;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Description.Location = new System.Drawing.Point(353, 156);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(79, 17);
            this.Description.TabIndex = 13;
            this.Description.Text = "Description";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Result.Location = new System.Drawing.Point(382, 221);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 14;
            this.Result.Text = "Result";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionTextBox.Location = new System.Drawing.Point(440, 154);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(116, 59);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultTextBox.Location = new System.Drawing.Point(440, 219);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(116, 59);
            this.resultTextBox.TabIndex = 16;
            // 
            // ProdMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(this.Worker);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.ListOfIssue);
            this.Controls.Add(this.issueTaskTreeView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ProdMan";
            this.Text = "ProdMan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView issueTaskTreeView;
        private System.Windows.Forms.Label ListOfIssue;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label Worker;
        private System.Windows.Forms.ComboBox workerComboBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}