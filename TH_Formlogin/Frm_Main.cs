using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_Formlogin
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            lblUserInfor.Text = string.Format("Login by Admin", Cls_Main._staticUser.ID, Cls_Main._staticUser.UserName);


        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Cls_Main._staticUser = null;
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuChangedPassword_Click(object sender, EventArgs e)
        {
            Frm_ChangedPassword frm_ChangedPassword = new Frm_ChangedPassword();
            frm_ChangedPassword.MdiParent = this;
            frm_ChangedPassword.StartPosition = FormStartPosition.CenterScreen;
            frm_ChangedPassword.Show();
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
