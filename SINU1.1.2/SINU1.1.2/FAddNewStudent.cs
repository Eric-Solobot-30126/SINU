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
    public partial class FAddNewStudent : Form
    {

        UserType userType;

        public FAddNewStudent(UserType userType)
        {

            this.userType = userType;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FAddNewStudent_Load(object sender, EventArgs e)
        {

        }

        private void BCreate_Click(object sender, EventArgs e)
        {

            SINUInterface sINUInterface = new SINU();
            
            if(userType.ToString() == UserType.Student.ToString())
                sINUInterface.AddNewStudent(this);

            if (userType.ToString() == UserType.Profesor.ToString())
                sINUInterface.AddNewProfesor(this);

            if (userType.ToString() == UserType.Secretariat.ToString())
                sINUInterface.AddNewSecretariat(this);

        }
    }
}
