using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkham_Asylum
{
    public class User
    {
        protected String name;
        protected String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        public User(String name, String password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
