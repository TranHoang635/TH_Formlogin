using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH_Formlogin.Data;

namespace TH_Formlogin
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        private UserDao _user;
        private object ckbRemember;

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            _user = new UserDao();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //dong toan bo 
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (!string.IsNullOrEmpty(txtPassWord.Text))
                {
                    
                   if( KiemTraDangNhap(txtUserName.Text, txtPassWord.Text))
                    {
                        //kiemtrabiennho
                        _user.user.Remember = ckbRemember.Checked;
                        Cls_Main._staticUser = _user.user;
                        this.Close();
                    }
                   else
                    {
                        lblErr.Text = "UserName or PassWord incorrect";
                    }
                }
            }
        }

        private bool KiemTraDangNhap(string userName, string passWord)
        {
            if(_user.user.UserName.Equals(userName)&&
                _user.user.PassWord.Equals(passWord))
            {
                return true;
            }
            return false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(_user.user.Remember)
            {
                ckbRemember.Checked = true;

                txtPassWord.Text = _user.user.PassWord;
                btnLogin.Focus();
            }
        }
    }
}
