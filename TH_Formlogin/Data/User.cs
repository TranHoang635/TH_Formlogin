using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_Formlogin.Data
{
    public class User
    {
        private int iD;
        private string userName;
        private bool remember;
        private string idUserType;
        private string passWord;

        //Properties
        public User() { }
        public User(int iD, string userName, string passWord, bool remember)
        {
            this.iD = iD;
            this.userName = userName;
            this.PassWord = passWord;
            this.remember = remember;
        }
        public int ID { get { return iD; } set { iD = value; } }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool Remember { get => remember; set => remember = value; }
        public string IdUserType { get => idUserType; set => idUserType = value; }

        public string Getstring()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, UserName, PassWord, Remember.ToString(), IdUserType);
        }
    }
}
