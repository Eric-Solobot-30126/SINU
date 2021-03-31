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
    public partial class FNotes : Form
    {

        private int year;
        private Student loggedStudent;

        public FNotes(int year, Student loggedStudent)
        {

            this.loggedStudent = loggedStudent;
            this.year = year;
            InitializeComponent();
            LoadLabelsWithNotes();
            
        }

        private void FNotes_Load(object sender, EventArgs e)
        {



        }

        private void BTBack_Click(object sender, EventArgs e)
        {

            FMenu fMenu = new FMenu(this.loggedStudent);
            fMenu.Show();
            Visible = false;


        }

        private void LoadLabelsWithNotes() {


            List<Note> notesFromThisYear = new List<Note>();

            for (int i = 0; i <= this.loggedStudent.Notes.Count - 1; i++)
                if (this.loggedStudent.Notes.ElementAt(i).Year == year)
                    notesFromThisYear.Add(this.loggedStudent.Notes.ElementAt(i));

            if (notesFromThisYear.Count >= 1)
            {
                LYear1.Text = notesFromThisYear.ElementAt(0).Year.ToString();
                LSemester1.Text = notesFromThisYear.ElementAt(0).Semester.ToString();
                LCours1.Text = notesFromThisYear.ElementAt(0).Course.ToString();
                LCredits1.Text = notesFromThisYear.ElementAt(0).Credit.ToString();
                LNote1.Text = notesFromThisYear.ElementAt(0).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 2)
            {
                LYear2.Text = notesFromThisYear.ElementAt(1).Year.ToString();
                LSemester2.Text = notesFromThisYear.ElementAt(1).Semester.ToString();
                LCours2.Text = notesFromThisYear.ElementAt(1).Course.ToString();
                LCredits2.Text = notesFromThisYear.ElementAt(1).Credit.ToString();
                LNote2.Text = notesFromThisYear.ElementAt(1).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 3)
            {
                LYear3.Text = notesFromThisYear.ElementAt(2).Year.ToString();
                LSemester3.Text = notesFromThisYear.ElementAt(2).Semester.ToString();
                LCours3.Text = notesFromThisYear.ElementAt(2).Course.ToString();
                LCredits3.Text = notesFromThisYear.ElementAt(2).Credit.ToString();
                LNote3.Text = notesFromThisYear.ElementAt(2).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 4)
            {
                LYear4.Text = notesFromThisYear.ElementAt(3).Year.ToString();
                LSemester4.Text = notesFromThisYear.ElementAt(3).Semester.ToString();
                LCours4.Text = notesFromThisYear.ElementAt(3).Course.ToString();
                LCredits4.Text = notesFromThisYear.ElementAt(3).Credit.ToString();
                LNote4.Text = notesFromThisYear.ElementAt(3).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 5)
            {
                LYear5.Text = notesFromThisYear.ElementAt(4).Year.ToString();
                LSemester5.Text = notesFromThisYear.ElementAt(4).Semester.ToString();
                LCours5.Text = notesFromThisYear.ElementAt(4).Course.ToString();
                LCredits5.Text = notesFromThisYear.ElementAt(4).Credit.ToString();
                LNote5.Text = notesFromThisYear.ElementAt(4).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 6)
            {
                LYear6.Text = notesFromThisYear.ElementAt(5).Year.ToString();
                LSemester6.Text = notesFromThisYear.ElementAt(5).Semester.ToString();
                LCours6.Text = notesFromThisYear.ElementAt(5).Course.ToString();
                LCredits6.Text = notesFromThisYear.ElementAt(5).Credit.ToString();
                LNote6.Text = notesFromThisYear.ElementAt(5).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 7)
            {
                LYear7.Text = notesFromThisYear.ElementAt(6).Year.ToString();
                LSemester7.Text = notesFromThisYear.ElementAt(6).Semester.ToString();
                LCours7.Text = notesFromThisYear.ElementAt(6).Course.ToString();
                LCredits7.Text = notesFromThisYear.ElementAt(6).Credit.ToString();
                LNote7.Text = notesFromThisYear.ElementAt(6).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 8)
            {
                LYear8.Text = notesFromThisYear.ElementAt(7).Year.ToString();
                LSemester8.Text = notesFromThisYear.ElementAt(7).Semester.ToString();
                LCours8.Text = notesFromThisYear.ElementAt(7).Course.ToString();
                LCredits8.Text = notesFromThisYear.ElementAt(7).Credit.ToString();
                LNote8.Text = notesFromThisYear.ElementAt(7).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 9)
            {
                LYear9.Text = notesFromThisYear.ElementAt(8).Year.ToString();
                LSemester9.Text = notesFromThisYear.ElementAt(8).Semester.ToString();
                LCours9.Text = notesFromThisYear.ElementAt(8).Course.ToString();
                LCredits9.Text = notesFromThisYear.ElementAt(8).Credit.ToString();
                LNote9.Text = notesFromThisYear.ElementAt(8).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 10)
            {
                LYear10.Text = notesFromThisYear.ElementAt(9).Year.ToString();
                LSemester10.Text = notesFromThisYear.ElementAt(9).Semester.ToString();
                LCours10.Text = notesFromThisYear.ElementAt(9).Course.ToString();
                LCredits10.Text = notesFromThisYear.ElementAt(9).Credit.ToString();
                LNote10.Text = notesFromThisYear.ElementAt(9).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 11)
            {
                LYear11.Text = notesFromThisYear.ElementAt(10).Year.ToString();
                LSemester11.Text = notesFromThisYear.ElementAt(10).Semester.ToString();
                LCours11.Text = notesFromThisYear.ElementAt(10).Course.ToString();
                LCredits11.Text = notesFromThisYear.ElementAt(10).Credit.ToString();
                LNote11.Text = notesFromThisYear.ElementAt(10).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 12)
            {
                LYear12.Text = notesFromThisYear.ElementAt(11).Year.ToString();
                LSemester12.Text = notesFromThisYear.ElementAt(11).Semester.ToString();
                LCours12.Text = notesFromThisYear.ElementAt(11).Course.ToString();
                LCredits12.Text = notesFromThisYear.ElementAt(11).Credit.ToString();
                LNote12.Text = notesFromThisYear.ElementAt(11).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 13)
            {
                LYear13.Text = notesFromThisYear.ElementAt(12).Year.ToString();
                LSemester13.Text = notesFromThisYear.ElementAt(12).Semester.ToString();
                LCours13.Text = notesFromThisYear.ElementAt(12).Course.ToString();
                LCredits13.Text = notesFromThisYear.ElementAt(12).Credit.ToString();
                LNote13.Text = notesFromThisYear.ElementAt(12).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 14)
            {
                LYear14.Text = notesFromThisYear.ElementAt(13).Year.ToString();
                LSemester14.Text = notesFromThisYear.ElementAt(13).Semester.ToString();
                LCours14.Text = notesFromThisYear.ElementAt(13).Course.ToString();
                LCredits14.Text = notesFromThisYear.ElementAt(13).Credit.ToString();
                LNote14.Text = notesFromThisYear.ElementAt(13).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 15)
            {
                LYear15.Text = notesFromThisYear.ElementAt(14).Year.ToString();
                LSemester15.Text = notesFromThisYear.ElementAt(14).Semester.ToString();
                LCours15.Text = notesFromThisYear.ElementAt(14).Course.ToString();
                LCredits15.Text = notesFromThisYear.ElementAt(14).Credit.ToString();
                LNote15.Text = notesFromThisYear.ElementAt(14).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 16)
            {
                LYear16.Text = notesFromThisYear.ElementAt(15).Year.ToString();
                LSemester16.Text = notesFromThisYear.ElementAt(15).Semester.ToString();
                LCours16.Text = notesFromThisYear.ElementAt(15).Course.ToString();
                LCredits16.Text = notesFromThisYear.ElementAt(15).Credit.ToString();
                LNote16.Text = notesFromThisYear.ElementAt(15).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 17)
            {
                LYear17.Text = notesFromThisYear.ElementAt(16).Year.ToString();
                LSemester17.Text = notesFromThisYear.ElementAt(16).Semester.ToString();
                LCours17.Text = notesFromThisYear.ElementAt(16).Course.ToString();
                LCredits17.Text = notesFromThisYear.ElementAt(16).Credit.ToString();
                LNote17.Text = notesFromThisYear.ElementAt(16).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 18)
            {
                LYear18.Text = notesFromThisYear.ElementAt(17).Year.ToString();
                LSemester18.Text = notesFromThisYear.ElementAt(17).Semester.ToString();
                LCours18.Text = notesFromThisYear.ElementAt(17).Course.ToString();
                LCredits18.Text = notesFromThisYear.ElementAt(17).Credit.ToString();
                LNote18.Text = notesFromThisYear.ElementAt(17).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 19)
            {
                LYear19.Text = notesFromThisYear.ElementAt(18).Year.ToString();
                LSemester19.Text = notesFromThisYear.ElementAt(18).Semester.ToString();
                LCours19.Text = notesFromThisYear.ElementAt(18).Course.ToString();
                LCredits19.Text = notesFromThisYear.ElementAt(18).Credit.ToString();
                LNote19.Text = notesFromThisYear.ElementAt(18).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 20)
            {
                LYear20.Text = notesFromThisYear.ElementAt(19).Year.ToString();
                LSemester20.Text = notesFromThisYear.ElementAt(19).Semester.ToString();
                LCours20.Text = notesFromThisYear.ElementAt(19).Course.ToString();
                LCredits20.Text = notesFromThisYear.ElementAt(19).Credit.ToString();
                LNote20.Text = notesFromThisYear.ElementAt(19).getNote().ToString();
            }

            if (notesFromThisYear.Count >= 21)
            {
                LYear21.Text = notesFromThisYear.ElementAt(20).Year.ToString();
                LSemester21.Text = notesFromThisYear.ElementAt(20).Semester.ToString();
                LCours21.Text = notesFromThisYear.ElementAt(20).Course.ToString();
                LCredits21.Text = notesFromThisYear.ElementAt(20).Credit.ToString();
                LNote21.Text = notesFromThisYear.ElementAt(20).getNote().ToString();
            }

        }

    }
}
