using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINU1._1._2
{
    public class Student
    {

        // Acount info

        private string username;
        private string password;

        // Personal Data

        private string firstName;
        private string lastName;
        private string IDCardSeries;
        private string IDCardNumber;
        private string IDCardAdress;
        private string dateOfBirth;
        private string adress;
        private string phoneNumber;
        private string email;
        private string militaryState;
        private string maritalStatus;
        private string nationality;

        // School Status

        private int curentYear;
        private int curentSemester;
        private double beginningYearAverage;
        private double finalAverage;
        private double beginneingYearPonderationAnverage;
        private double finalPonderationAverage;
        private int outstandingNumber;
        private int previousYearsOutstandingNumber;
        private Funding funding;
        private bool stockFirstSemestre;
        private bool stockSecondSemestre;
        private int outstandingCreditsNumber;
        private int previousYearOutstandingCreditsNumber;
        private string observation;

        // Notes

        private List<Note> notes = new List<Note>();


        // Constructors

        public Student(string username, string password, string firstName, string lastName, string iDCardSeries, string iDCardNumber, string iDCardAdress, string dateOfBirth, string adress, string phoneNumber, string email, string militaryState, string maritalStatus, string nationality, int curentYear, int curentSemester , double beginningYearAverage, double finalAverage, double beginneingYearPonderationAnverage, double finalPonderationAverage, int outstandingNumber, int previousYearsOutstandingNumber, Funding funding, bool stockFirstSemestre, bool stockSecondSemestre, int outstandingCreditsNumber, int previousYearOutstandingCreditsNumber, string observation, List<Note> notes)
        {
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IDCardSeries1 = iDCardSeries;
            this.IDCardNumber1 = iDCardNumber;
            this.IDCardAdress1 = iDCardAdress;
            this.DateOfBirth = dateOfBirth;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.MilitaryState = militaryState;
            this.MaritalStatus = maritalStatus;
            this.Nationality = nationality;
            this.curentYear = curentYear;
            this.CurentSemester = curentSemester;
            this.BeginningYearAverage = beginningYearAverage;
            this.FinalAverage = finalAverage;
            this.BeginneingYearPonderationAnverage = beginneingYearPonderationAnverage;
            this.FinalPonderationAverage = finalPonderationAverage;
            this.OutstandingNumber = outstandingNumber;
            this.PreviousYearsOutstandingNumber = previousYearsOutstandingNumber;
            this.Funding = funding;
            this.StockFirstSemestre = stockFirstSemestre;
            this.StockSecondSemestre = stockSecondSemestre;
            this.OutstandingCreditsNumber = outstandingCreditsNumber;
            this.PreviousYearOutstandingCreditsNumber = previousYearOutstandingCreditsNumber;
            this.Observation = observation;
            this.Notes = notes;
        }


        // Methodes

        public void CalculateBeginningYearAverage()
        {

            this.BeginningYearAverage = 0;

            for (int i = 0; i <= this.Notes.Count - 1 ; i++)
                if(!(this.Notes.ElementAt(i).getNote() < 5)) 
                    this.BeginningYearAverage += this.Notes.ElementAt(i).getNote();

            this.BeginningYearAverage = this.BeginningYearAverage / this.Notes.Count;

        }

        public void CalculateFinalAverage()
        {

            this.FinalAverage = 0;

            for (int i = 0; i <= this.Notes.Count - 1 ; i++) {
                
                if (this.CurentSemester == 1){
                    
                    if (this.Notes.ElementAt(i).getYear() == this.curentYear - 1 && this.Notes.ElementAt(i).getSemester() == 2 && !(this.Notes.ElementAt(i).getNote() < 5))
                        this.FinalAverage += this.Notes.ElementAt(i).getNote();
                
                }
                else {

                    if (this.Notes.ElementAt(i).getYear() == this.curentYear && this.Notes.ElementAt(i).getSemester() == 1 && !(this.Notes.ElementAt(i).getNote() < 5))
                        this.FinalAverage += this.Notes.ElementAt(i).getNote();

                }

            }

            this.FinalAverage = this.FinalAverage / this.Notes.Count;

        }

        public void CalucalteBeginneingYearPonderationAnverage()
        {

            this.BeginneingYearPonderationAnverage = 0;
            int numberOfCredits = 0;

            for (int i = 0; i <= this.Notes.Count - 1 ; i++)
            {
                if (!(this.Notes.ElementAt(i).getNote() < 5))
                    this.BeginneingYearPonderationAnverage += (this.Notes.ElementAt(i).getNote() * this.Notes.ElementAt(i).getCredit());
                numberOfCredits += this.Notes.ElementAt(i).getCredit();
            }
            this.BeginneingYearPonderationAnverage = this.BeginneingYearPonderationAnverage / numberOfCredits;

        }

        public void CalucalteFinalPonderationAverage()
        {

            this.FinalPonderationAverage = 0;
            int numberOfCredits = 0;

            for (int i = 0; i <= this.Notes.Count - 1; i++)
            {

                if (this.CurentSemester == 1)
                {

                    if (this.Notes.ElementAt(i).getYear() == this.curentYear - 1 && this.Notes.ElementAt(i).getSemester() == 2)
                    {
                        if(!(this.Notes.ElementAt(i).getNote() < 5))
                            this.FinalPonderationAverage += (this.Notes.ElementAt(i).getNote() * this.Notes.ElementAt(i).getCredit() );
                        numberOfCredits += this.Notes.ElementAt(i).getCredit();
                    
                    }

                }
                else
                {

                    if (this.Notes.ElementAt(i).getYear() == this.curentYear && this.Notes.ElementAt(i).getSemester() == 1)
                    {
                        if (!(this.Notes.ElementAt(i).getNote() < 5))
                            this.FinalPonderationAverage += (this.Notes.ElementAt(i).getNote() * this.Notes.ElementAt(i).getCredit());
                        numberOfCredits += this.Notes.ElementAt(i).getCredit();

                    }

                }
            
            }

            this.FinalPonderationAverage = this.FinalPonderationAverage / numberOfCredits;


        }

        public void CalculateOutstandingNumber()
        {

            this.OutstandingNumber = 0;

            for (int i = 0; i <= this.Notes.Count - 1; i++)
                if (this.Notes.ElementAt(i).getNote() < 5)
                    this.OutstandingNumber++;

        }

        public void CalculatePreviousYearsOutstandingNumber()
        {

            this.PreviousYearsOutstandingNumber = 0;

            for (int i = 0; i <= this.Notes.Count - 1; i++)
                if (this.Notes.ElementAt(i).getNote() < 5 && this.Notes.ElementAt(i).getYear() != this.curentYear)
                    this.PreviousYearsOutstandingNumber++;

        }

        public void CalculateOutstandingCreditsNumber()
        {

            this.OutstandingCreditsNumber = 0;

            for (int i = 0; i <= this.Notes.Count - 1; i++)
                if (this.Notes.ElementAt(i).getNote() < 5)
                    this.OutstandingCreditsNumber += this.Notes.ElementAt(i).getCredit();

        }

        // Gettere|Settere

        public int PreviousYearOutstandingCreditsNumber { get => PreviousYearOutstandingCreditsNumber1; set => PreviousYearOutstandingCreditsNumber1 = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string IDCardSeries1 { get => IDCardSeries; set => IDCardSeries = value; }
        public string IDCardNumber1 { get => IDCardNumber; set => IDCardNumber = value; }
        public string IDCardAdress1 { get => IDCardAdress; set => IDCardAdress = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Adress { get => adress; set => adress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string MilitaryState { get => militaryState; set => militaryState = value; }
        public string MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Observation { get => observation; set => observation = value; }
        public int CurentYear { get => curentYear; set => curentYear = value; }
        internal List<Note> Notes { get => notes; set => notes = value; }
        public double BeginningYearAverage { get => beginningYearAverage; set => beginningYearAverage = value; }
        public double FinalAverage { get => finalAverage; set => finalAverage = value; }
        public double BeginneingYearPonderationAnverage { get => beginneingYearPonderationAnverage; set => beginneingYearPonderationAnverage = value; }
        public double FinalPonderationAverage { get => finalPonderationAverage; set => finalPonderationAverage = value; }
        public int OutstandingNumber { get => outstandingNumber; set => outstandingNumber = value; }
        public int PreviousYearsOutstandingNumber { get => previousYearsOutstandingNumber; set => previousYearsOutstandingNumber = value; }
        public Funding Funding { get => funding; set => funding = value; }
        public bool StockFirstSemestre { get => stockFirstSemestre; set => stockFirstSemestre = value; }
        public bool StockSecondSemestre { get => stockSecondSemestre; set => stockSecondSemestre = value; }
        public int OutstandingCreditsNumber { get => outstandingCreditsNumber; set => outstandingCreditsNumber = value; }
        public int PreviousYearOutstandingCreditsNumber1 { get => previousYearOutstandingCreditsNumber; set => previousYearOutstandingCreditsNumber = value; }
        public int CurentSemester { get => curentSemester; set => curentSemester = value; }
    }
}
