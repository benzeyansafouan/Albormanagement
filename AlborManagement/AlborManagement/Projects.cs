using System;
using System.Windows.Forms;

namespace AlborManagement
{
    public partial class Projects : Form
    {
        updateProjectForm upProfrm = new updateProjectForm();
        addProjectForm adProfrm = new addProjectForm();
        public Projects()
        {
            InitializeComponent();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            //guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor.Equals(Colo)
            guna2DataGridView1.Rows.Add("1", "name1", "cost1", "exec1", DateTime.Today, "situation1");
        }

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                guna2DataGridView1.Rows.Remove(guna2DataGridView1.CurrentRow);
                guna2DataGridView1.Update();
            }
        }

        private void UpdateProjectButton_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                upProfrm.txtid.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                upProfrm.txtname.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                upProfrm.txtcost.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                upProfrm.txtexecuter.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                upProfrm.expdate.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                upProfrm.txtsituation.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            if (Form.ActiveForm == upProfrm)
            { }
            adProfrm.Hide();
            upProfrm.Show();
            /*  if (adfrm.Visible == true)
              {
                  adfrm.Hide();
                  upfrm.Show();
              }
              else if (upfrm.Visible == true)
              {
                  upfrm.Hide();
                  upfrm.Show();
              }
              else
                  upfrm.Show();*/
        }

        private void AddProjetButton_Click(object sender, EventArgs e)
        {
            if (Form.ActiveForm == adProfrm)
            { }
            upProfrm.Hide();
            adProfrm.Show();
            /*    if (upfrm.Visible == true)
                {
                    upfrm.Hide();
                    adfrm.Show();
                }
                else if (adfrm.Visible == true)
                {
                    adfrm.Hide();
                    adfrm.Show();
                }
                else if(adfrm.FormClosed)
                    adfrm.Show();*/

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Update();
            guna2DataGridView1.Refresh();
        }
    }
}
