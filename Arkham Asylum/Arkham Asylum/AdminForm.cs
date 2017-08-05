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
    public partial class AdminForm : Form
    {
        int option;
        List<String> crimes_db = new List<String>();
        List<Villain> villian_db = new List<Villain>();

        public AdminForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LoginSingleton.Login.Show();
        }

        private void addVibt_MouseClick(object sender, MouseEventArgs e)
        {
            option = 1;
            this.Dispose();
            AddForm form = new AddForm(option);
            form.Show();
        }

        private void addDobt_MouseClick(object sender, MouseEventArgs e)
        {
            option = 2;
            this.Dispose();
            AddForm form = new AddForm(option);
            form.Show();
        }
    }
}
