
namespace projekt_TAB
{
    partial class Admin
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
            this.employeeList = new System.Windows.Forms.ListView();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.employeesLabel = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.lastNameLabel = new System.Windows.Forms.Panel();
            this.loginValueLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.Panel();
            this.upperButtonsPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.activeComboBox = new System.Windows.Forms.ComboBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundPanel.SuspendLayout();
            this.lastNameLabel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.upperButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeList
            // 
            this.employeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.employeeList.HideSelection = false;
            this.employeeList.Location = new System.Drawing.Point(11, 26);
            this.employeeList.Margin = new System.Windows.Forms.Padding(2);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(475, 310);
            this.employeeList.TabIndex = 0;
            this.employeeList.UseCompatibleStateImageBehavior = false;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.addEmployeeButton.Location = new System.Drawing.Point(0, 0);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(400, 48);
            this.addEmployeeButton.TabIndex = 1;
            this.addEmployeeButton.Text = "Add employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.updateEmployeeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.updateEmployeeButton.Location = new System.Drawing.Point(0, 413);
            this.updateEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(784, 48);
            this.updateEmployeeButton.TabIndex = 2;
            this.updateEmployeeButton.Text = "Apply";
            this.updateEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(400, 0);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(400, 48);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // employeesLabel
            // 
            this.employeesLabel.AutoSize = true;
            this.employeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.employeesLabel.ForeColor = System.Drawing.Color.White;
            this.employeesLabel.Location = new System.Drawing.Point(8, 0);
            this.employeesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeesLabel.Name = "employeesLabel";
            this.employeesLabel.Size = new System.Drawing.Size(105, 24);
            this.employeesLabel.TabIndex = 4;
            this.employeesLabel.Text = "Employees";
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.backgroundPanel.Controls.Add(this.lastNameLabel);
            this.backgroundPanel.Controls.Add(this.listPanel);
            this.backgroundPanel.Controls.Add(this.upperButtonsPanel);
            this.backgroundPanel.Controls.Add(this.updateEmployeeButton);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(784, 461);
            this.backgroundPanel.TabIndex = 5;
            this.backgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundPanel_Paint);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Controls.Add(this.roleComboBox);
            this.lastNameLabel.Controls.Add(this.activeComboBox);
            this.lastNameLabel.Controls.Add(this.surnameTextBox);
            this.lastNameLabel.Controls.Add(this.nameTextBox);
            this.lastNameLabel.Controls.Add(this.passwordTextBox);
            this.lastNameLabel.Controls.Add(this.loginValueLabel);
            this.lastNameLabel.Controls.Add(this.roleLabel);
            this.lastNameLabel.Controls.Add(this.surnameLabel);
            this.lastNameLabel.Controls.Add(this.nameLabel);
            this.lastNameLabel.Controls.Add(this.activeLabel);
            this.lastNameLabel.Controls.Add(this.passwordLabel);
            this.lastNameLabel.Controls.Add(this.loginLabel);
            this.lastNameLabel.Location = new System.Drawing.Point(500, 60);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(300, 353);
            this.lastNameLabel.TabIndex = 7;
            // 
            // loginValueLabel
            // 
            this.loginValueLabel.AutoSize = true;
            this.loginValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginValueLabel.ForeColor = System.Drawing.Color.White;
            this.loginValueLabel.Location = new System.Drawing.Point(85, 43);
            this.loginValueLabel.Name = "loginValueLabel";
            this.loginValueLabel.Size = new System.Drawing.Size(105, 17);
            this.loginValueLabel.TabIndex = 6;
            this.loginValueLabel.Text = "Tu będzie login";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roleLabel.ForeColor = System.Drawing.Color.White;
            this.roleLabel.Location = new System.Drawing.Point(15, 258);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(37, 17);
            this.roleLabel.TabIndex = 5;
            this.roleLabel.Text = "Role";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.surnameLabel.ForeColor = System.Drawing.Color.White;
            this.surnameLabel.Location = new System.Drawing.Point(15, 215);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(65, 17);
            this.surnameLabel.TabIndex = 4;
            this.surnameLabel.Text = "Surname";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(15, 172);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.activeLabel.ForeColor = System.Drawing.Color.White;
            this.activeLabel.Location = new System.Drawing.Point(15, 129);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(46, 17);
            this.activeLabel.TabIndex = 2;
            this.activeLabel.Text = "Active";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(15, 86);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(15, 43);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(43, 17);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.employeesLabel);
            this.listPanel.Controls.Add(this.employeeList);
            this.listPanel.Location = new System.Drawing.Point(0, 60);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(500, 353);
            this.listPanel.TabIndex = 6;
            // 
            // upperButtonsPanel
            // 
            this.upperButtonsPanel.Controls.Add(this.addEmployeeButton);
            this.upperButtonsPanel.Controls.Add(this.logOutButton);
            this.upperButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.upperButtonsPanel.Name = "upperButtonsPanel";
            this.upperButtonsPanel.Size = new System.Drawing.Size(784, 60);
            this.upperButtonsPanel.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.Location = new System.Drawing.Point(85, 88);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 15);
            this.passwordTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(85, 174);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 15);
            this.nameTextBox.TabIndex = 8;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameTextBox.Location = new System.Drawing.Point(85, 217);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 15);
            this.surnameTextBox.TabIndex = 9;
            // 
            // activeComboBox
            // 
            this.activeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.activeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.activeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.activeComboBox.FormattingEnabled = true;
            this.activeComboBox.Location = new System.Drawing.Point(85, 129);
            this.activeComboBox.Name = "activeComboBox";
            this.activeComboBox.Size = new System.Drawing.Size(200, 24);
            this.activeComboBox.TabIndex = 10;
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(85, 251);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(200, 24);
            this.roleComboBox.TabIndex = 11;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.backgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Admin";
            this.Text = "Admin";
            this.backgroundPanel.ResumeLayout(false);
            this.lastNameLabel.ResumeLayout(false);
            this.lastNameLabel.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.upperButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView employeeList;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button updateEmployeeButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label employeesLabel;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel upperButtonsPanel;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Panel lastNameLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label loginValueLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox activeComboBox;
        private System.Windows.Forms.ComboBox roleComboBox;
    }
}