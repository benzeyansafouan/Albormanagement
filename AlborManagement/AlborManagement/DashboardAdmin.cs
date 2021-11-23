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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd,int wmsg,int wparam,int lparam);


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void OpenFormInPanel (object childForm)
        {
            if (this.guna2Panel3.Controls.Count > 0)
                    this.guna2Panel3.Controls.RemoveAt(0);

            Form fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.guna2Panel3.Controls.Add(fh);
            this.guna2Panel3.Tag = fh;
            fh.Show();


        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Projects());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Employees());
        }



        private void guna2Button4_Click(object sender, EventArgs e)
        {

            OpenFormInPanel(new Clients());
        }




        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Maximized;

        }

 

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (guna2Panel1.Width == 194)
            {
                guna2Panel1.Width = 59;
            }
            else
                guna2Panel1.Width = 194;
        }

        private void guna2PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DashExiteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit?","Alert!!!",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();
            }
            else { }
        }
        int lx, ly;
        private void DashMaxButton_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            DashMaxButton.Visible = false;
            DashMinButton.Visible = true;

          /*  Projects pr = new Projects();
            pr.Size = Screen.PrimaryScreen.WorkingArea.Size;
            pr.Location = Screen.PrimaryScreen.WorkingArea.Location;
            pr.guna2DataGridView1.Size = new Size(579, 600);*/
        }

        private void DashMinButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1182, 608);
            this.Location = new Point(lx, ly);
                DashMaxButton.Visible = true;
                DashMinButton.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
