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
    public partial class FSchoolSituation : Form
    {

        Student loggedStudent;

        public FSchoolSituation(Student loggedStudent)
        {

            InitializeComponent();
            this.loggedStudent = loggedStudent;
            LCurentYearValue.Text = loggedStudent.CurentYear.ToString();
            LBeginningYearAverageValue.Text = loggedStudent.BeginningYearAverage.ToString();
            LFinalAverageValue.Text = loggedStudent.FinalAverage.ToString();
            LBeginneingYearPonderationAnverageValue.Text = loggedStudent.BeginneingYearPonderationAnverage.ToString();
            LFinalPonderationAverageValue.Text = loggedStudent.FinalPonderationAverage.ToString();
            LOutstandingNumberValue.Text = loggedStudent.OutstandingNumber.ToString();
            LPreviousYearsOutstandingNumberValue.Text = loggedStudent.PreviousYearsOutstandingNumber.ToString();
            LFundingValue.Text = loggedStudent.Funding.ToString();
            LStockFirstSemestreValue.Text = loggedStudent.StockFirstSemestre.ToString();
            LStockSecondSemestreValue.Text = loggedStudent.StockSecondSemestre.ToString();
            LOutstandingCreditsNumberValue.Text = loggedStudent.OutstandingCreditsNumber.ToString();
            LPreviousYearOutstandingCreditsNumberValue.Text = loggedStudent.PreviousYearOutstandingCreditsNumber.ToString();
            LObservationValue.Text = loggedStudent.Observation.ToString();

        }

        private void FSchoolSituation_Load(object sender, EventArgs e)
        {

        }

        private void BTBack_Click(object sender, EventArgs e)
        {

            FMenu fMenu = new FMenu(this.loggedStudent);
            fMenu.Show();
            Visible = false;

        }
    }
}
