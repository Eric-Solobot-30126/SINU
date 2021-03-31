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
    public partial class FMenu : Form
    {

        private Student loggedStudent;

        public FMenu(Student loggedStudent)
        {
            
            this.loggedStudent = loggedStudent;
            InitializeComponent();
        
        }

        private void BPersonalData_Click(object sender, EventArgs e)
        {

            FPersonalData fPersonalData = new FPersonalData(this.loggedStudent);
            fPersonalData.Show();
            Visible = false;

        }

        private void BSchoolSituation_Click(object sender, EventArgs e)
        {

            FSchoolSituation FSchoolSituation = new FSchoolSituation(this.loggedStudent);
            FSchoolSituation.Show();
            Visible = false;

        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void BYear1_Click(object sender, EventArgs e)
        {

            FNotes fNotes = new FNotes(1,this.loggedStudent);
            fNotes.Show();
            Visible = false;

        }

        private void BYear2_Click(object sender, EventArgs e)
        {

            FNotes fNotes = new FNotes(2, this.loggedStudent);
            fNotes.Show();
            Visible = false;

        }

        private void BYear3_Click(object sender, EventArgs e)
        {

            FNotes fNotes = new FNotes(3, this.loggedStudent);
            fNotes.Show();
            Visible = false;

        }

        private void BYear4_Click(object sender, EventArgs e)
        {

            FNotes fNotes = new FNotes(4, this.loggedStudent);
            fNotes.Show();
            Visible = false;

        }

        private void BTDisconect_Click(object sender, EventArgs e)
        {

            SINUInterface sINUInterface = new SINU();
            loggedStudent = null;
            FLogIn fLogIn = new FLogIn();
            fLogIn.Show();
            Visible = false;

        }
    }
}
