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
    public partial class FPersonalData : Form
    {

        Student loggedStudent;

        public FPersonalData(Student loggedStudent)
        {

            this.loggedStudent = loggedStudent;
            InitializeComponent();
            TBFirstName.Text = loggedStudent.FirstName;
            TBLastName.Text = loggedStudent.LastName;
            TBIDCardSeries.Text = loggedStudent.IDCardSeries1;
            TBCardNumber.Text = loggedStudent.IDCardNumber1;
            TBIDCardAdress.Text = loggedStudent.IDCardAdress1;
            TBDateOfBirth.Text = loggedStudent.DateOfBirth;
            TBAdress.Text = loggedStudent.Adress;
            TBPhoneNumber.Text = loggedStudent.PhoneNumber;
            TBEmail.Text = loggedStudent.Email;
            TBMilitaryState.Text = loggedStudent.MilitaryState;
            TBMaritalState.Text = loggedStudent.MaritalStatus;
            TBNationality.Text = loggedStudent.Nationality;

        }

        private void FPersonalData_Load(object sender, EventArgs e)
        {

        }

        private void BTBack_Click(object sender, EventArgs e)
        {

            FMenu fMenu = new FMenu(this.loggedStudent);
            fMenu.Show();
            Visible = false;

        }

        private void BTChange_Click(object sender, EventArgs e)
        {

            SINUInterface sINUInterface = new SINU();
            sINUInterface.ChangePersonalDataOfStudent(this.loggedStudent,this);

        }

        private void BTClear_Click(object sender, EventArgs e)
        {

            SINUInterface sINUInterface = new SINU();
            sINUInterface.ClearAllTB(this);

        }
    }

}
