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
    public partial class DoctorForm : Form
    {

        public DoctorForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.rubricForm();
        }

        private void normalForm() //This is the main menu form for a doctor
        {
            this.Text = "       Doctor menu";
            Panel container = new Panel();
            Label mainmenu = new Label();
            Label user = new Label();
            Label villain = new Label();
            Label medicalcon = new Label();
            Label rubric = new Label();
            Button changemed = new Button();
            Button startsession = new Button();
            ComboBox medicalcb = new ComboBox();
            ComboBox villaincb = new ComboBox();
            mainmenu.Text = "Doctor main menu";
            user.Text = "User:";
            villain.Text = "Villain:";
            medicalcon.Text = "Medical condition:";
            changemed.Text = "Change Medicine";
            startsession.Text = "New Session";
            rubric.Text = "Rubric Prom:";
            medicalcb.DropDownStyle = ComboBoxStyle.DropDownList;
            villaincb.DropDownStyle = ComboBoxStyle.DropDownList;
            container.Controls.Add(mainmenu);
            container.Controls.Add(user);
            container.Controls.Add(villain);
            container.Controls.Add(changemed);
            container.Controls.Add(startsession);
            container.Controls.Add(medicalcb);
            container.Controls.Add(villaincb);
            container.Controls.Add(medicalcon);
            container.Controls.Add(rubric);
            mainmenu.Location = new Point(95, 30);
            user.Location = new Point(90, 60);
            villain.Location = new Point(70, 100);
            villaincb.Location = new Point(110, 98);
            medicalcon.Location = new Point(50, 140);
            medicalcb.Location = new Point(145, 138);
            rubric.Location = new Point(50, 170);
            changemed.Location = new Point(14, 200);
            startsession.Location = new Point(150, 200);
            container.Size = new Size(285, 261);
            villain.Size = new Size(37, 13);
            villaincb.Size = medicalcb.Size = new Size(90,14);
            changemed.Size = startsession.Size = new Size(120, 30);
            this.Controls.Add(container);
        }

        private void rubricForm() //This is the rubric form, this form is used for villain's sessions
        {
            this.Text = "Routine session";
            Label title = new Label();
            Label villainname = new Label();
            Label doctorname = new Label();
            Label one = new Label();
            Label two = new Label();
            Label three = new Label();
            Label four = new Label();
            Label five = new Label();
            Label rubricscore = new Label();
            TextBox ansone = new TextBox();
            TextBox anstwo = new TextBox();
            TextBox ansthree = new TextBox();
            TextBox ansfour = new TextBox();
            TextBox ansfive = new TextBox();
            TextBox ansrs = new TextBox();
            Button finishbt = new Button();
            title.Text = "Routine session";
            villainname.Text = "Villain name:";
            doctorname.Text = "Doctor name:";
            one.Text = "1) ";
            two.Text = "2) ";
            three.Text = "3) ";
            four.Text = "4) ";
            five.Text = "5) ";
            finishbt.Text = "Finish";
            rubricscore.Text = "Rubric score:";
            title.Location = new Point(90, 50);
            this.Controls.Add(title);
            this.Controls.Add(villainname);
            this.Controls.Add(doctorname);
            this.Controls.Add(one);
            this.Controls.Add(two);
            this.Controls.Add(three);
            this.Controls.Add(four);
            this.Controls.Add(five);
            this.Controls.Add(rubricscore);
            this.Controls.Add(finishbt);
            this.Controls.Add(ansone);
            this.Controls.Add(anstwo);
            this.Controls.Add(ansthree);
            this.Controls.Add(ansfour);
            this.Controls.Add(ansfive);
            this.Controls.Add(ansrs);
        }

        private void newMedicine() //This form is used for change medicine of specific villain problem
        {

        }

        private bool verificateForm(string one, string two, string three, string four, string five)
        {
            if (!string.IsNullOrWhiteSpace(one) && !string.IsNullOrWhiteSpace(two) && !string.IsNullOrWhiteSpace(three) && !string.IsNullOrWhiteSpace(four) && !string.IsNullOrWhiteSpace(five))
            {
                return true;
            }
            else return false;
        }
    }
}
