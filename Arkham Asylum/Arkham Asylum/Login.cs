using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkham_Asylum
{
    public partial class Login : Form
    {
        public List<User> users_db = new List<User>();

        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            users_db.Add(new Admin("root",""));
        }

        private bool auth(String name, String password) {
            foreach (User user in users_db) {
                if (user.GetType() == typeof(Admin) && (user.Name.Equals(name) && user.Password.Equals(password))){
                    this.Hide();
                    AdminForm adminview = new AdminForm();
                    adminview.Show();
                    return true;
                }
            }
            return false;
        }

        private void Signbt_MouseClick(object sender, MouseEventArgs e) {
            if (!this.auth(LoginUtb.Text, LoginPtb.Text)) MessageBox.Show("Invalid User/Password");
        }
    }
}
