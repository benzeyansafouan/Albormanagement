
namespace AlborManagement
{
    partial class Clients
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
            this.ClientGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cl_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp_cl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_comp_name_cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ExmployeeSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmployeeSearchButton = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ClientGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClientGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientGridView.ColumnHeadersHeight = 40;
            this.ClientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_Id,
            this.comp_cl_name,
            this.owner_comp_name_cl,
            this.cl_city,
            this.cl_adress});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientGridView.EnableHeadersVisualStyles = false;
            this.ClientGridView.GridColor = System.Drawing.Color.White;
            this.ClientGridView.Location = new System.Drawing.Point(12, 100);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.RowHeadersVisible = false;
            this.ClientGridView.RowTemplate.Height = 30;
            this.ClientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientGridView.Size = new System.Drawing.Size(694, 298);
            this.ClientGridView.TabIndex = 27;
            this.ClientGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClientGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.ClientGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.ClientGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClientGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.ClientGridView.ThemeStyle.ReadOnly = false;
            this.ClientGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 11F);
            this.ClientGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ClientGridView.ThemeStyle.RowsStyle.Height = 30;
            this.ClientGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.ClientGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cl_Id
            // 
            this.cl_Id.HeaderText = "Id";
            this.cl_Id.Name = "cl_Id";
            // 
            // comp_cl_name
            // 
            this.comp_cl_name.HeaderText = "Company Name";
            this.comp_cl_name.Name = "comp_cl_name";
            // 
            // owner_comp_name_cl
            // 
            this.owner_comp_name_cl.HeaderText = "Owner Name";
            this.owner_comp_name_cl.Name = "owner_comp_name_cl";
            // 
            // cl_city
            // 
            this.cl_city.HeaderText = "City";
            this.cl_city.Name = "cl_city";
            // 
            // cl_adress
            // 
            this.cl_adress.HeaderText = "Adress";
            this.cl_adress.Name = "cl_adress";
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
            this.EmployeeExitButton.TabIndex = 26;
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
            this.deleteEmployeeButton.Location = new System.Drawing.Point(388, 410);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.ShadowDecoration.Parent = this.deleteEmployeeButton;
            this.deleteEmployeeButton.Size = new System.Drawing.Size(71, 35);
            this.deleteEmployeeButton.TabIndex = 32;
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
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(311, 410);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.ShadowDecoration.Parent = this.UpdateEmployeeButton;
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(71, 35);
            this.UpdateEmployeeButton.TabIndex = 31;
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
            this.AddEmployeeButton.Location = new System.Drawing.Point(234, 410);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.ShadowDecoration.Parent = this.AddEmployeeButton;
            this.AddEmployeeButton.Size = new System.Drawing.Size(71, 35);
            this.AddEmployeeButton.TabIndex = 30;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::AlborManagement.Properties.Resources.ClientIconEdited22;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(101, 74);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 33;
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
            this.ExmployeeSearchTextBox.Size = new System.Drawing.Size(417, 28);
            this.ExmployeeSearchTextBox.TabIndex = 29;
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
            this.EmployeeSearchButton.Location = new System.Drawing.Point(528, 42);
            this.EmployeeSearchButton.Name = "EmployeeSearchButton";
            this.EmployeeSearchButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EmployeeSearchButton.ShadowDecoration.Parent = this.EmployeeSearchButton;
            this.EmployeeSearchButton.Size = new System.Drawing.Size(35, 31);
            this.EmployeeSearchButton.TabIndex = 28;
            this.EmployeeSearchButton.Click += new System.EventHandler(this.EmployeeSearchButton_Click);
            // 
            // Clients
            // 
            this.AccessibleDescription = "s";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientGridView);
            this.Controls.Add(this.EmployeeExitButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.UpdateEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ExmployeeSearchTextBox);
            this.Controls.Add(this.EmployeeSearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2DataGridView ClientGridView;
        private Guna.UI2.WinForms.Guna2Button EmployeeExitButton;
        private Guna.UI2.WinForms.Guna2Button deleteEmployeeButton;
        private Guna.UI2.WinForms.Guna2Button UpdateEmployeeButton;
        private Guna.UI2.WinForms.Guna2Button AddEmployeeButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox ExmployeeSearchTextBox;
        private Guna.UI2.WinForms.Guna2CircleButton EmployeeSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp_cl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_comp_name_cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_adress;
    }
}