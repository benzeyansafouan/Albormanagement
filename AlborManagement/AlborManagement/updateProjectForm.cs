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
    public partial class updateProjectForm : Form
    {
        public updateProjectForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateProjectForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AddButtonSaving_Click(object sender, EventArgs e)
        {
            Projects pr = new Projects();
            pr.guna2DataGridView1.Update();
        }

        private void UpdateCancelButton_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtcost.Clear();
            txtexecuter.Clear();
            txtsituation.Clear();
            expdate.ResetText();
            this.Hide();
        }
    }
}
