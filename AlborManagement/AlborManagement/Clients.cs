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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
        UpdateClientForm upCLform = new UpdateClientForm();
        AddClientForm adCLform = new AddClientForm();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (Form.ActiveForm == adCLform) { }
            
            upCLform.Hide();
            adCLform.Show();
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (ClientGridView.SelectedRows.Count > 0)
            {
                upCLform.txtidCL.Text = ClientGridView.CurrentRow.Cells[0].Value.ToString();
                upCLform.txtCompNameCL.Text = ClientGridView.CurrentRow.Cells[1].Value.ToString();
                upCLform.txtOwnerNameCL.Text = ClientGridView.CurrentRow.Cells[2].Value.ToString();
                upCLform.txtCityCL.Text = ClientGridView.CurrentRow.Cells[3].Value.ToString();
                upCLform.txtAdressCL.Text = ClientGridView.CurrentRow.Cells[4].Value.ToString();
            }
           


            if(Form.ActiveForm == upCLform) { }
            adCLform.Hide();
            upCLform.Show();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            ClientGridView.Rows.Add("100", "albor", "safouan", "hcma", "bario");
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (ClientGridView.SelectedRows.Count > 0)
            {
                ClientGridView.Rows.Remove(ClientGridView.CurrentRow);
                ClientGridView.Update();
            }
        }

        private void EmployeeExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeSearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
