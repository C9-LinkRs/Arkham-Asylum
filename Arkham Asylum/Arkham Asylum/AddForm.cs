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
    public partial class AddForm : Form
    {
        private int option;
        private Button cancelbt = new Button();

        public AddForm(int op)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.option = op;
            this.setForm();
        }

        private void setForm()
        {
            if (this.option == 1) this.villainForm(); //With this form you can add a new villain
            else if (this.option == 2) this.treatmentForm(); //With this form you can see the medical history of a specific villain
            else if (this.option == 3) this.doctorForm(); //With this form you can add a new doctor and do a villain medical monitoring
        }

        private void villainForm()
        {
            this.Text = "Add a villain";
            Panel container = new Panel();
            Label title = new Label();
            Label name = new Label();
            Label alias = new Label();
            Label id = new Label();
            Label borndate = new Label();
            Label crimes = new Label();
            TextBox tb1 = new TextBox();
            TextBox tb2 = new TextBox();
            TextBox tb3 = new TextBox();
            TextBox tb4 = new TextBox();
            Button addbt = new Button();
            Button plusbt = new Button();
            ComboBox crimecb = new ComboBox();
            String imgpath = getImagePath("plus");
            crimes.Text = "Crimes";
            borndate.Text = "Born date";
            id.Text = "ID";
            alias.Text = "Alias";
            name.Text = "Name";
            title.Text = "New villain form";
            addbt.Text = "Add";
            cancelbt.Text = "Cancel";
            title.Location = new Point(100, 10);
            name.Location = new Point(20, 40);
            alias.Location = new Point(20,70);
            id.Location = new Point(20,99);
            borndate.Location = new Point(20,130);
            crimes.Location = new Point(20, 160);
            tb1.Location = new Point(120, 40);
            tb2.Location = new Point(120, 70);
            tb3.Location = new Point(120, 99);
            tb4.Location = new Point(120, 130);
            crimecb.Location = new Point(120,160);
            addbt.Location = new Point(60, 210);
            cancelbt.Location = new Point(147, 210);
            plusbt.Location = new Point(224, 162);
            container.Location = new Point(16, 6);
            container.Controls.Add(name);
            container.Controls.Add(alias);
            container.Controls.Add(id);
            container.Controls.Add(borndate);
            container.Controls.Add(crimes);
            container.Controls.Add(tb1);
            container.Controls.Add(tb2);
            container.Controls.Add(tb3);
            container.Controls.Add(tb4);
            container.Controls.Add(crimecb);
            container.Controls.Add(addbt);
            container.Controls.Add(cancelbt);
            container.Controls.Add(plusbt);
            container.Size = new Size(260,261);
            plusbt.BackgroundImage = Image.FromFile(imgpath);
            plusbt.Size = new Size(16, 16);
            crimecb.Size = new Size(100, 16);
            crimecb.DropDownStyle = ComboBoxStyle.DropDownList;
            plusbt.FlatStyle = FlatStyle.Flat;
            plusbt.FlatAppearance.BorderSize = 0;
            this.Controls.Add(title);
            this.Controls.Add(container);
        }

        private void treatmentForm()
        {
            this.Text = "   villain Medical History";
            Panel container = new Panel();
            Label title = new Label();
            Label name = new Label();
            ComboBox villaincb = new ComboBox();
            ComboBox medconditioncb = new ComboBox();
            Label medcondition = new Label();
            Label session = new Label();
            ComboBox sessioncb = new ComboBox();
            Label date = new Label();
            Label doctor = new Label();
            Label actmedicine = new Label();
            Label rubricresult = new Label();
            Button notification = new Button();
            String imgpath = getImagePath("notification");
            sessioncb.DropDownStyle = ComboBoxStyle.DropDownList;
            medconditioncb.DropDownStyle = ComboBoxStyle.DropDownList;
            villaincb.DropDownStyle = ComboBoxStyle.DropDownList;
            notification.BackgroundImage = Image.FromFile(imgpath);
            notification.FlatStyle = FlatStyle.Flat;
            notification.FlatAppearance.BorderSize = 0;
            rubricresult.Text = "Rubric result:";
            actmedicine.Text = "Actual Medicine:";
            date.Text = "Date:";
            doctor.Text = "Doctor:";
            title.Text = "Treatment Form";
            session.Text = "Session:";
            medcondition.Text = "Medical condition: ";
            name.Text = "villain Name: ";
            title.Location = new Point(100, 10);
            name.Location = new Point(50,39);
            villaincb.Location = new Point(130, 37);
            medcondition.Location = new Point(11,72);
            medconditioncb.Location = new Point(104, 70);
            session.Location = new Point(190,72);
            sessioncb.Location = new Point(240,70);
            actmedicine.Location = new Point(30,110);
            rubricresult.Location = new Point(30,140);
            doctor.Location = new Point(30, 170);
            date.Location = new Point(30, 200);
            notification.Location = new Point(200,108);
            villaincb.Size = new Size(100, 16);
            medconditioncb.Size = new Size(80, 10);
            container.Size = new Size(285, 261);
            sessioncb.Size = new Size(30,10);
            session.Size = new Size(47, 15);
            notification.Size = new Size(15,17);
            container.Controls.Add(medconditioncb);
            container.Controls.Add(medcondition);
            container.Controls.Add(villaincb);
            container.Controls.Add(name);
            container.Controls.Add(session);
            container.Controls.Add(sessioncb);
            container.Controls.Add(actmedicine);
            container.Controls.Add(rubricresult);
            container.Controls.Add(doctor);
            container.Controls.Add(date);
            container.Controls.Add(notification);
            this.Controls.Add(title);
            this.Controls.Add(container);
        }

        private void doctorForm()
        {
            this.Text = "        Add a Doctor";
            Panel container = new Panel();
            TabControl tabpanel = new TabControl();
            TabPage addtp = new TabPage();
            TabPage viewtp = new TabPage();
            Label title = new Label();
            Label name = new Label();
            Label username = new Label();
            Label password = new Label();
            Button addbt = new Button();
            TextBox nametb = new TextBox();
            TextBox usernametb = new TextBox();
            TextBox passwordtb = new TextBox();
            passwordtb.PasswordChar = '*'; //It is for hide the password
            addbt.Text = "Add";
            cancelbt.Text = "Cancel";
            addtp.Text = "Add";
            viewtp.Text = "View";
            title.Text = "Add a new Doctor";
            name.Text = "Name:";
            username.Text = "Username:";
            password.Text = "Password:";
            tabpanel.Controls.Add(addtp);
            tabpanel.Controls.Add(viewtp);
            this.Controls.Add(container);
            container.Controls.Add(tabpanel);
            tabpanel.Size = new Size(250, 230);
            container.Size = new Size(285, 261);
            tabpanel.Location = new Point(18, 14);
            //Add TabPage Form
            addtp.Controls.Add(title);
            addtp.Controls.Add(name);
            addtp.Controls.Add(username);
            addtp.Controls.Add(password);
            addtp.Controls.Add(addbt);
            addtp.Controls.Add(cancelbt);
            addtp.Controls.Add(nametb);
            addtp.Controls.Add(usernametb);
            addtp.Controls.Add(passwordtb);
            title.Location = new Point(70,25);
            name.Location = new Point(30,60);
            username.Location = new Point(30, 89);
            password.Location = new Point(30, 120);
            addbt.Location = new Point(40, 165);
            cancelbt.Location = new Point(126, 165);
            nametb.Location = new Point(100,57);
            usernametb.Location = new Point(100, 87);
            passwordtb.Location = new Point(100, 117);
            name.Size = new Size(50, 20);
            username.Size = new Size(58, 20);
            password.Size = new Size(58, 20);
            //View TablePage Form
            Label doctor = new Label();
            ComboBox doctorcb = new ComboBox();
            Label villain = new Label();
            ComboBox villaincb = new ComboBox();
            Label problem = new Label();
            ComboBox problemcb = new ComboBox();
            Label actualmedicine = new Label();
            Label previousmedicine = new Label();
            Label rubricprombef = new Label();
            Label rubricpromaf = new Label();
            Button removecare = new Button();
            Label title2 = new Label();
            title2.Text = "Villain Medical Monitoring";
            doctor.Text = "Doctor:";
            villain.Text = "Villain:";
            problem.Text = "Problem:";
            actualmedicine.Text = "Actual Medicine:";
            previousmedicine.Text = "Previous Medicine:";
            rubricpromaf.Text = "New Rubric Prom:";
            rubricprombef.Text = "Previous Rubric Prom:";
            removecare.Text = "Remove Care";
            viewtp.Controls.Add(title2);
            viewtp.Controls.Add(doctor);
            viewtp.Controls.Add(doctorcb);
            viewtp.Controls.Add(villain);
            viewtp.Controls.Add(villaincb);
            viewtp.Controls.Add(problem);
            viewtp.Controls.Add(problemcb);
            viewtp.Controls.Add(actualmedicine);
            viewtp.Controls.Add(previousmedicine);
            viewtp.Controls.Add(rubricprombef);
            viewtp.Controls.Add(rubricpromaf);
            viewtp.Controls.Add(removecare);
            title2.Location = new Point(53,5);
            doctor.Location = new Point(5, 35);
            doctorcb.Location = new Point(48, 33);
            villain.Location = new Point(122, 35);
            villaincb.Location = new Point(160, 33);
            problem.Location = new Point(50, 73);
            problemcb.Location = new Point(100, 70);
            actualmedicine.Location = new Point(23, 100);
            previousmedicine.Location = new Point(23, 120);
            rubricpromaf.Location = new Point(23, 140);
            rubricprombef.Location = new Point(23, 160);
            removecare.Location = new Point(132, 180);
            title2.Size = new Size(126, 13);
            doctor.Size = new Size(42, 13);
            villain.Size = new Size(37, 13);
            problem.Size = new Size(49, 13);
            actualmedicine.Size = new Size(87, 13);
            previousmedicine.Size = new Size(97, 13);
            rubricprombef.Size = new Size(112, 13);
            removecare.Size = new Size(100, 22);
            doctorcb.Size = villaincb.Size = problemcb.Size = new Size(70, 42);
            doctorcb.DropDownStyle = villaincb.DropDownStyle = problemcb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        String getImagePath(String name)
        {
            String slnpath = System.IO.Directory.GetCurrentDirectory();
            return slnpath.Substring(0, slnpath.Length - 23) + (@"icons\") + name + ".png";
        }
    }
}