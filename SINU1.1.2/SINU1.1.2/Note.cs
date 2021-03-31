using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINU1._1._2
{
    public class Note
    {

        private Cours course;
        private double note;
        private int credit;
        private int year;
        private int semester;

        public Cours Course { get => course; set => course = value; }
        public int Credit { get => credit; set => credit = value; }
        public int Year { get => year; set => year = value; }
        public int Semester { get => semester; set => semester = value; }

        public Note(Cours course, int credit, int year, int semester)
        {
            this.Course = course;
            this.note = -1;
            this.Credit = credit;
            this.Year = year;
            this.Semester = semester;
        }

        public Note(Cours course, double note, int credit, int year, int semester)
        {
            this.Course = course;
            this.note = note;
            this.Credit = credit;
            this.Year = year;
            this.Semester = semester;
        }

        public int getYear() {

            return this.Year;
        
        }

        public int getSemester()
        {

            return this.Semester;

        }

        public double getNote()
        {

            return this.note;

        }

        public int getCredit() {

            return this.Credit;
        
        }

        public void setNote(double note)
        {

            this.note = note;

        }


    }
}
