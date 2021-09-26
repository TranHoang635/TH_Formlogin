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
    public partial class Frm_ChangedPassword : Form
    {
        public Frm_ChangedPassword()
        {
            InitializeComponent();
        }

        public Frm_ChangedPassword(UserDao userDao)
        {
            this.userDao = userDao;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int IdUserType = 0;
        UserDao userDao;
        List<User> _listUser;
        bool statusLoad = false;
        int idUser = 0;
        private void Frm_ChangedPassword_Load(object sender, EventArgs e)
        {
            IdUserType = Cls_Main._staticUser.IdUserType;
            idUser = Cls_Main._staticUser.ID;
            lblUserName.Text = string.Format("{0}-{1}", idUser.ToString() +
                Cls_Main._staticUser.UserName.ToUpper());
            switch (IdUserType)
            {
                case 1://admin
                    grbAdmin.Enabled = true;
                    break;
                case 2://user
                    grbAdmin.Enabled = false;
                    break;
                default:
                    grbAdmin.Enabled = false;
                    break;
            }
            //if(IdUserType==2)//quyen khong Admin
            //{
            //    grbAdmin.Enabled = false;
            //}
            //else
            //{
            //    grbAdmin.Enabled = true;
            //}
            _listUser = Cls_Main._listUser;
            LoadCombouser();
        }

        private void LoadCombouser()
        {
            cboUser.DataSource = _listUser;
            cboUser.DisplayMember = "UserName";
            cboUser.ValueMember = "ID";

            cboUser.SelectedIndex = -1;
            cboUser.Text = "--- Select user ---";
            statusLoad = true;
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUser.SelectedIndex >= -1 && statusLoad)
            {
                //idUser = (int)cboUser.SelectedValue;
                //idUser = int.Parse(cboUser.SelectedValue.ToString());
                idUser = Convert.ToInt32(cboUser.SelectedValue);
                //MessageBox.Show(cboUser.SelectedValue.ToString());
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            foreach (User item in Cls_Main._listUser)
            {
                if(item.ID==idUser)
                {
                    item.PassWord = item.UserName;
                }
            }
        }

        private void btnChangedPassword_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPasswordNewOne.Text))
            {
                if(!string.IsNullOrEmpty(txtPasswordTwo.Text))
                {
                    if(txtPasswordNewOne.Text.Equals(txtPasswordTwo.Text))
                    {
                       if( ChangedPassword(txtPasswordNewOne.Text))
                        {
                            MessageBox.Show("Changed pass successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                       else
                        {
                            MessageBox.Show("Changed password Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Not input Password 2", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Not input Password 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ChangedPassword(string passNew)
        {
            foreach (User item in Cls_Main._listUser)
            {
                if (item.ID == idUser)
                {
                    item.PassWord = passNew;
                    return true;
                }
            }
            return false;
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
