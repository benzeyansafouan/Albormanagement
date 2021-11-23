using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AlborManagement
{
    public partial class EmployeeDashboardForm : Form
    {
        public EmployeeDashboardForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);


        private void DashExiteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Alert!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();
            }
            else { }
        }
        int lx, ly;
        int x, y;
        private void DashMinButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(x, y);
            this.Location = new Point(lx, ly);
            DashMaxButton.Visible = true;
            DashMinButton.Visible = false;
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EmployeeDashboardForm_Load(object sender, EventArgs e)
        {
            string nl = Environment.NewLine;
            guna2DataGridView1.Rows.Add("Project Name", "benzeyan");
            guna2DataGridView1.Rows.Add("Description", "benzeyan1 test test "+nl+"test test test "+nl+"test test test");
            guna2DataGridView1.Rows.Add("Task1", "create x project");
            guna2DataGridView1.Rows.Add("Task2", "create y project");
            guna2DataGridView1.Rows.Add("Taskn", "create z project");
            for (int i = 0; i < 5; i++)
            {
                guna2DataGridView1.Rows[i].Cells[0].Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }
            guna2DataGridView1.Rows[1].Height = 50;
            guna2DataGridView1.Rows[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.Rows[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            guna2DataGridView1.Rows[0].ReadOnly=true;
            guna2DataGridView1.Rows[1].ReadOnly=true;
            guna2DataGridView1.Rows[2].Cells[0].ReadOnly = true;
            guna2DataGridView1.Rows[3].Cells[0].ReadOnly = true;
            guna2DataGridView1.Rows[3].Cells[0].ReadOnly = true;
        }

        private void DashMaxButton_Click(object sender, EventArgs e)
        {
            x = this.Width;
            y = this.Height;
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            DashMaxButton.Visible = false;
            DashMinButton.Visible = true;
        }
    }
}
