using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkham_Asylum
{
    sealed class LoginSingleton //Is a singleton class for startup form
    {
        private static Login login;

        public static Login Login
        {
            get
            {
                if(login == null)
                {
                    login = new Login();
                }
                return login;
            }
        }
    }
}
