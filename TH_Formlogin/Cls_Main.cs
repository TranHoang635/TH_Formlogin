using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_Formlogin.Data;

namespace TH_Formlogin
{
    public class Cls_Main
    {
        public static User _staticUser = new User();
        public static List<User> _listUser = new UserDao().listUser;
    }
}
