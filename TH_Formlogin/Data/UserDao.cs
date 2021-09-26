using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_Formlogin.Data
{
    public class UserDao
    {
        public User user;
        public List<User> listUser;
        public UserDao()
        {
            //user = new User();
            //user.ID = 1;
            //user.UserName = "admin";
            //user.PassWord = "admin";
            //user.Remember = true;


            listUser = new List<User>()
            {
                new User() { ID =
                1, UserName = "admin", PassWord = "admin", Remember = true,IdUserType=1},//la admin
                new User() { ID =
                2, UserName = "user", PassWord = "user", Remember = false,IdUserType=2},
                new User() { ID =
                3, UserName = "hoang", PassWord = "123456789", Remember = true,IdUserType=2},//la user thuong
            };
        }
        public void GetUsers(string path);
        {
            using (FileStream fs=new FileStream(path,FileMode.Open))
        }
    }
}
