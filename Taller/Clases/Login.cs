using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    public class Login
    {
        public Login() { }
        public Login(string nickName, string password)
        {
            NickName = nickName;
            Password = password;
        }

        public string NickName { get; set; }
        public string Password { get; set; }

        public static List<Login> listaUser = new List<Login>() 
        {
            new Login() { NickName = "admin", Password = "admin123" },
            new Login() { NickName = "nolberto", Password = "nolberto123" },
            new Login() { NickName = "user", Password = "user123" },
        };
    }
}
