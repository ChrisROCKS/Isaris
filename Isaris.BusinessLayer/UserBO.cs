using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isaris.Entities;
using Isaris.DataAccess;

namespace Isaris.BusinessLayer
{
    public class UserBO
    {
        public static string nombreUsuario = null;
        public static string permisos = null;

        int valorHash(string cadena)
        {
            return cadena.GetHashCode();
        }

        public static void Create(UserEntity user)
        {
            UserDAL.Create(user);

        }
        public static UserEntity Login(string user, string pw)
        {
            return UserDAL.ValidarUsuario(user, pw);
        }
        
    }
}
