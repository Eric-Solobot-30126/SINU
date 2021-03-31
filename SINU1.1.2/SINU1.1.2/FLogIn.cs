using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINU1._1._2
{
    public partial class FLogIn : Form
    {

        SINUInterface sinuInterface = new SINU();

        public FLogIn()
        {
            InitializeComponent();
        }

        private void FLogIn_Load(object sender, EventArgs e)
        {

        }

        private void BSingIn_Click(object sender, EventArgs e)
        {

            if (RadStudent.Checked == true)
            {
                sinuInterface.SelectUser(this);
                MessageBox.Show(sinuInterface.LoggedStudent.Username + "is logged with -" + sinuInterface.LoggedStudent.Password + "- password");
                FMenu fMenu = new FMenu(sinuInterface.LoggedStudent);
                fMenu.Show();
                Visible = false;
            }
            


        }

        private void BSignUp_Click(object sender, EventArgs e)
        {

            FAddNewStudent fAddNewStudent;

            if (this.RadSecretariat.Checked == true)
                fAddNewStudent = new FAddNewStudent(UserType.Secretariat);
            else if (this.RadProfesor.Checked == true)
                fAddNewStudent = new FAddNewStudent(UserType.Profesor);
            else 
                fAddNewStudent = new FAddNewStudent(UserType.Student);

            fAddNewStudent.Show();
            Visible = false;

        }
    }
}
