
namespace AlborManagement
{
    partial class Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeeGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Employee_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empl_function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ExmployeeSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmployeeSearchButton = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeGridView.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeGridView.ColumnHeadersHeight = 40;
            this.EmployeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_Id,
            this.Empl_First_Name,
            this.Empl_last_name,
            this.Empl_age,
            this.empl_function});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeGridView.EnableHeadersVisualStyles = false;
            this.EmployeeGridView.GridColor = System.Drawing.Color.White;
            this.EmployeeGridView.Location = new System.Drawing.Point(12, 99);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowHeadersVisible = false;
            this.EmployeeGridView.RowTemplate.Height = 30;
            this.EmployeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGridView.Size = new System.Drawing.Size(694, 298);
            this.EmployeeGridView.TabIndex = 18;
            this.EmployeeGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.EmployeeGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Goldenrod;
            this.EmployeeGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.EmployeeGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.EmployeeGridView.ThemeStyle.ReadOnly = false;
            this.EmployeeGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmployeeGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.EmployeeGridView.ThemeStyle.RowsStyle.Height = 30;
            this.EmployeeGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.EmployeeGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Employee_Id
            // 
            this.Employee_Id.HeaderText = "Id";
            this.Employee_Id.Name = "Employee_Id";
            // 
            // Empl_First_Name
            // 
            this.Empl_First_Name.HeaderText = "First Name";
            this.Empl_First_Name.Name = "Empl_First_Name";
            // 
            // Empl_last_name
            // 
            this.Empl_last_name.HeaderText = "Last Name";
            this.Empl_last_name.Name = "Empl_last_name";
            // 
            // Empl_age
            // 
            this.Empl_age.HeaderText = "Age";
            this.Empl_age.Name = "Empl_age";
            // 
            // empl_function
            // 
            this.empl_function.HeaderText = "Function";
            this.empl_function.Name = "empl_function";
            // 
            // EmployeeExitButton
            // 
            this.EmployeeExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeExitButton.CheckedState.Parent = this.EmployeeExitButton;
            this.EmployeeExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeExitButton.CustomImages.Parent = this.EmployeeExitButton;
            this.EmployeeExitButton.FillColor = System.Drawing.SystemColors.Control;
            this.EmployeeExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeeExitButton.ForeColor = System.Drawing.Color.DimGray;
            this.EmployeeExitButton.HoverState.Parent = this.EmployeeExitButton;
            this.EmployeeExitButton.Location = new System.Drawing.Point(770, 3);
            this.EmployeeExitButton.Name = "EmployeeExitButton";
            this.EmployeeExitButton.ShadowDecoration.Parent = this.EmployeeExitButton;
            this.EmployeeExitButton.Size = new System.Drawing.Size(31, 26);
            this.EmployeeExitButton.TabIndex = 17;
            this.EmployeeExitButton.Text = "X";
            this.EmployeeExitButton.Click += new System.EventHandler(this.EmployeeExitButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteEmployeeButton.BorderRadius = 15;
            this.deleteEmployeeButton.CheckedState.Parent = this.deleteEmployeeButton;
            this.deleteEmployeeButton.CustomImages.Parent = this.deleteEmployeeButton;
            this.deleteEmployeeButton.FillColor = System.Drawing.Color.DimGray;
            this.deleteEmployeeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.deleteEmployeeButton.HoverState.Parent = this.deleteEmployeeButton;
            this.deleteEmployeeButton.Location = new System.Drawing.Point(475, 413);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.ShadowDecoration.Parent = this.deleteEmployeeButton;
            this.deleteEmployeeButton.Size = new System.Drawing.Size(71, 35);
            this.deleteEmployeeButton.TabIndex = 23;
            this.deleteEmployeeButton.Text = "Delete";
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateEmployeeButton.BorderRadius = 15;
            this.UpdateEmployeeButton.CheckedState.Parent = this.UpdateEmployeeButton;
            this.UpdateEmployeeButton.CustomImages.Parent = this.UpdateEmployeeButton;
            this.UpdateEmployeeButton.FillColor = System.Drawing.Color.DimGray;
            this.UpdateEmployeeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.UpdateEmployeeButton.HoverState.Parent = this.UpdateEmployeeButton;
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(387, 413);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.ShadowDecoration.Parent = this.UpdateEmployeeButton;
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(71, 35);
            this.UpdateEmployeeButton.TabIndex = 22;
            this.UpdateEmployeeButton.Text = "Update";
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddEmployeeButton.BorderRadius = 15;
            this.AddEmployeeButton.CheckedState.Parent = this.AddEmployeeButton;
            this.AddEmployeeButton.CustomImages.Parent = this.AddEmployeeButton;
            this.AddEmployeeButton.FillColor = System.Drawing.Color.DimGray;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.HoverState.Parent = this.AddEmployeeButton;
            this.AddEmployeeButton.Location = new System.Drawing.Point(300, 413);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.ShadowDecoration.Parent = this.AddEmployeeButton;
            this.AddEmployeeButton.Size = new System.Drawing.Size(71, 35);
            this.AddEmployeeButton.TabIndex = 21;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::AlborManagement.Properties.Resources.employeeIconEdited2;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(101, 74);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ExmployeeSearchTextBox
            // 
            this.ExmployeeSearchTextBox.Animated = true;
            this.ExmployeeSearchTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExmployeeSearchTextBox.BorderColor = System.Drawing.Color.White;
            this.ExmployeeSearchTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ExmployeeSearchTextBox.BorderThickness = 0;
            this.ExmployeeSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExmployeeSearchTextBox.DefaultText = "";
            this.ExmployeeSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ExmployeeSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExmployeeSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExmployeeSearchTextBox.DisabledState.Parent = this.ExmployeeSearchTextBox;
            this.ExmployeeSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExmployeeSearchTextBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ExmployeeSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExmployeeSearchTextBox.FocusedState.Parent = this.ExmployeeSearchTextBox;
            this.ExmployeeSearchTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.ExmployeeSearchTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.ExmployeeSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExmployeeSearchTextBox.HoverState.Parent = this.ExmployeeSearchTextBox;
            this.ExmployeeSearchTextBox.IconLeft = global::AlborManagement.Properties.Resources.searchIconEdited1;
            this.ExmployeeSearchTextBox.Location = new System.Drawing.Point(108, 43);
            this.ExmployeeSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExmployeeSearchTextBox.Name = "ExmployeeSearchTextBox";
            this.ExmployeeSearchTextBox.PasswordChar = '\0';
            this.ExmployeeSearchTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ExmployeeSearchTextBox.PlaceholderText = "Search...";
            this.ExmployeeSearchTextBox.SelectedText = "";
            this.ExmployeeSearchTextBox.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.ExmployeeSearchTextBox.ShadowDecoration.Parent = this.ExmployeeSearchTextBox;
            this.ExmployeeSearchTextBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.ExmployeeSearchTextBox.Size = new System.Drawing.Size(412, 28);
            this.ExmployeeSearchTextBox.TabIndex = 20;
            // 
            // EmployeeSearchButton
            // 
            this.EmployeeSearchButton.Animated = true;
            this.EmployeeSearchButton.BorderColor = System.Drawing.Color.Goldenrod;
            this.EmployeeSearchButton.CheckedState.Parent = this.EmployeeSearchButton;
            this.EmployeeSearchButton.CustomImages.Parent = this.EmployeeSearchButton;
            this.EmployeeSearchButton.FillColor = System.Drawing.Color.Goldenrod;
            this.EmployeeSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeeSearchButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeSearchButton.HoverState.Parent = this.EmployeeSearchButton;
            this.EmployeeSearchButton.Image = global::AlborManagement.Properties.Resources.searchIconEdited3;
            this.EmployeeSearchButton.Location = new System.Drawing.Point(527, 42);
            this.EmployeeSearchButton.Name = "EmployeeSearchButton";
            this.EmployeeSearchButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EmployeeSearchButton.ShadowDecoration.Parent = this.EmployeeSearchButton;
            this.EmployeeSearchButton.Size = new System.Drawing.Size(35, 31);
            this.EmployeeSearchButton.TabIndex = 19;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeGridView);
            this.Controls.Add(this.EmployeeExitButton);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.UpdateEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.ExmployeeSearchTextBox);
            this.Controls.Add(this.EmployeeSearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView EmployeeGridView;
        private Guna.UI2.WinForms.Guna2Button EmployeeExitButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button deleteEmployeeButton;
        private Guna.UI2.WinForms.Guna2Button UpdateEmployeeButton;
        private Guna.UI2.WinForms.Guna2Button AddEmployeeButton;
        private Guna.UI2.WinForms.Guna2TextBox ExmployeeSearchTextBox;
        private Guna.UI2.WinForms.Guna2CircleButton EmployeeSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn empl_function;
    }
}