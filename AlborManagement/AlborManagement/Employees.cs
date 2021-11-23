using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlborManagement
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        AddEmployeeForm adEmplForm = new AddEmployeeForm();
        UpdateEmployeeForm upEmplForm = new UpdateEmployeeForm();
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (Form.ActiveForm == adEmplForm)
            { }
            upEmplForm.Hide();
            adEmplForm.Show();
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeeGridView.SelectedRows.Count > 0)
            {
                upEmplForm.txtidEmpl.Text = EmployeeGridView.CurrentRow.Cells[0].Value.ToString();
                upEmplForm.txtFirstNameEmpl.Text = EmployeeGridView.CurrentRow.Cells[1].Value.ToString();
                upEmplForm.txtLastNameEmpl.Text = EmployeeGridView.CurrentRow.Cells[2].Value.ToString();
                upEmplForm.txtageEmpl.Text = EmployeeGridView.CurrentRow.Cells[3].Value.ToString();
                upEmplForm.txtFunctionEmpl.Text = EmployeeGridView.CurrentRow.Cells[4].Value.ToString();
            }
            if (Form.ActiveForm == upEmplForm)
            { }
            adEmplForm.Hide();
            upEmplForm.Show();
            
        }

        private void EmployeeExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            EmployeeGridView.Rows.Add("1", "safouan", "benzeyan", "22", "developer");
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeeGridView.SelectedRows.Count > 0)
            {
                EmployeeGridView.Rows.Remove(EmployeeGridView.CurrentRow);
                EmployeeGridView.Update();
            }
        }
    }
}
