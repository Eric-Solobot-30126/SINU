using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SINU1._1._2
{
    class SINU : SINUInterface
    {

        private Student loggedStudent;
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Eric\Faculta\An 3 Sem 2\II\Laborator\Lab2\Proiect Lab2\SINU1.1.2\SINU1.1.2\Database1.mdf;Integrated Security=True";

        public void AddNewStudent(FAddNewStudent fAddNewStudent) 
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("procAddNewStudent", sqlConnection);
                if (TestIfAllInformationsIsCompletedCorectly(sqlCommand,fAddNewStudent) && !UserExists(fAddNewStudent.TBUsername.Text))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Username", fAddNewStudent.TBUsername.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Pass", fAddNewStudent.TBPassword.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@FirstName", fAddNewStudent.TBFirstName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@LastName", fAddNewStudent.TBLastName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@IDCardSeries", fAddNewStudent.TBIDCardSeries.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@IDCardNumber", fAddNewStudent.TBCardNumber.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@IDCardAdress", fAddNewStudent.TBIDCardAdress.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@DateOfBirth", fAddNewStudent.TBDateOfBirth.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Adress", fAddNewStudent.TBAdress.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", fAddNewStudent.TBPhoneNumber.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Email", fAddNewStudent.TBEmail.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@MilitaryState", fAddNewStudent.TBMilitaryState.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@MaritalStatus", fAddNewStudent.TBMartialState.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Nationality", fAddNewStudent.TBNationality.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@CurentYear", "4");
                    sqlCommand.Parameters.AddWithValue("@CurentSemester", "2");
                    sqlCommand.Parameters.AddWithValue("@BeginningYearAverage", "-1");
                    sqlCommand.Parameters.AddWithValue("@FinalAverage", "-1");
                    sqlCommand.Parameters.AddWithValue("@BeginneingYearPonderationAnverage", "-1");
                    sqlCommand.Parameters.AddWithValue("@FinalPonderationAverage", "-1");
                    sqlCommand.Parameters.AddWithValue("@OutstandingNumber", "-1");
                    sqlCommand.Parameters.AddWithValue("@PreviousYearsOutstandingNumber", "-1");
                    sqlCommand.Parameters.AddWithValue("@Funding", "-1");
                    sqlCommand.Parameters.AddWithValue("@StockFirstSemestre", "-1");
                    sqlCommand.Parameters.AddWithValue("@StockSecondSemestre", "-1");
                    sqlCommand.Parameters.AddWithValue("@OutstandingCreditsNumber", "-1");
                    sqlCommand.Parameters.AddWithValue("@PreviousYearOutstandingCreditsNumber", "-1");
                    sqlCommand.Parameters.AddWithValue("@Observation", "-1");
                    sqlCommand.ExecuteNonQuery();
                }

            }
        }
        
        public void SelectUser(FLogIn fLogIn) 
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("procSelectStudent", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Username", fLogIn.TBUsername.Text.Trim());

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        string username = reader["Username"].ToString();
                        string password = reader["Pass"].ToString();

                        if (String.Equals(password, fLogIn.TBPassword.Text) )
                        {
                            
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            string IDCardSeries = reader["IDCardSeries"].ToString();
                            string IDCardNumber = reader["IDCardNumber"].ToString();
                            string IDCardAdress = reader["IDCardAdress"].ToString();
                            string dateOfBirth = reader["DateOfBirth"].ToString();
                            string adress = reader["Adress"].ToString();
                            string phoneNumber = reader["PhoneNumber"].ToString();
                            string email = reader["Email"].ToString();
                            string militaryState = reader["MilitaryState"].ToString();
                            string maritalStatus = reader["MaritalStatus"].ToString();
                            string nationality = reader["Nationality"].ToString();
                            int curentYear = Int32.Parse(reader["CurentYear"].ToString());
                            int curentSemester = Int32.Parse(reader["CurentSemester"].ToString());
                            double beginningYearAverage = Int32.Parse(reader["BeginningYearAverage"].ToString());
                            double finalAverage = Int32.Parse(reader["FinalAverage"].ToString());
                            double beginneingYearPonderationAnverage = Int32.Parse(reader["BeginneingYearPonderationAnverage"].ToString());
                            double finalPonderationAverage = Int32.Parse(reader["FinalPonderationAverage"].ToString());
                            int outstandingNumber = Int32.Parse(reader["OutstandingNumber"].ToString());
                            int previousYearsOutstandingNumber = Int32.Parse(reader["PreviousYearsOutstandingNumber"].ToString());
                            Funding funding;
                            
                            if (String.Equals(reader["Funding"].ToString() , "buget"))
                                funding = Funding.Budget;
                            else
                                funding = Funding.Tax;
                            
                            bool stockFirstSemestre = String.Equals(reader["StockFirstSemestre"].ToString(),true);
                            bool stockSecondSemestre = String.Equals(reader["StockSecondSemestre"].ToString(), true);
                            int outstandingCreditsNumber = Int32.Parse(reader["OutstandingCreditsNumber"].ToString());
                            int previousYearOutstandingCreditsNumber = Int32.Parse(reader["PreviousYearOutstandingCreditsNumber"].ToString());
                            string observation = reader["Observation"].ToString();
                            List<Note> note = new List<Note>();
                            
                            this.loggedStudent = new Student(username, password, firstName, lastName, IDCardSeries, IDCardNumber, IDCardAdress, dateOfBirth, adress, phoneNumber, email, militaryState, maritalStatus, nationality, curentYear, curentSemester, beginningYearAverage, finalAverage, beginneingYearPonderationAnverage, finalPonderationAverage, outstandingNumber, previousYearsOutstandingNumber, funding, stockFirstSemestre, stockSecondSemestre, outstandingCreditsNumber, previousYearOutstandingCreditsNumber, observation, note);

                        }

                        AddNotesToLoggedStudent(fLogIn);

                    }

                }
                    
            }            

        }
        
        public void AddNotesToLoggedStudent(FLogIn fLogIn)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("procSelectNote", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Username", fLogIn.TBUsername.Text.Trim());

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        while (reader.Read())
                        {

                            string findCours = reader["Note"].ToString();

                            string c = reader["Note"].ToString();

                            Cours cours = (Cours)Enum.Parse(typeof(Cours), c, true);
                            double note = Double.Parse(reader["Note"].ToString());
                            int credit = Int32.Parse(reader["Credit"].ToString());
                            int year = Int32.Parse(reader["Year"].ToString());
                            int semster = Int32.Parse(reader["Semester"].ToString());

                            this.LoggedStudent.Notes.Add(new Note(cours, note, credit, year, semster));

                        }

                    }
                    else {

                        List<Note> note = new List<Note>();

                        int controlNumber = this.loggedStudent.CurentYear * 10 + this.loggedStudent.CurentSemester;

                        if (controlNumber >= 11)
                            note.AddRange(getY1S1Notes());
                        if (controlNumber >= 12)
                            note.AddRange(getY1S2Notes());
                        if (controlNumber >= 21)
                            note.AddRange(getY2S1Notes());
                        if (controlNumber >= 22)
                            note.AddRange(getY2S2Notes());
                        if (controlNumber >= 31)
                            note.AddRange(getY3S1Notes());
                        if (controlNumber >= 32)
                            note.AddRange(getY3S2Notes());
                        if (controlNumber >= 41)
                            note.AddRange(getY4S1Notes());
                        if (controlNumber >= 42)
                            note.AddRange(getY4S2Notes());

                        for (int i = 0; i <= note.Count - 1; i++)
                            note.ElementAt(i).setNote(-1);

                        this.LoggedStudent.Notes = note;

                    }

                }
            }
        
        }

        public Student getLoggedStudent()
        {

            return this.LoggedStudent;
        
        }

        public bool TestIfAllInformationsIsCompletedCorectly(SqlCommand sqlCommand , FAddNewStudent fAddNewStudent) {

            int number;
            bool statement = true;
            string username = fAddNewStudent.LUsername.Text;
            string password = fAddNewStudent.LPassword.Text;
            string firstName = fAddNewStudent.LFirstName.Text;
            string lastName = fAddNewStudent.LLastName.Text;
            string IDCardSeries = fAddNewStudent.LIDCardSeries.Text;
            string dateOfBirth = fAddNewStudent.LDateOfBirth.Text;
            string phoneNumber = fAddNewStudent.LPhoneNumber.Text;
            string email = fAddNewStudent.LEmail.Text;
            string militaryState = fAddNewStudent.LMilitaryState.Text;

            if (username.Length < 6) 
                return false;

            if (username.Length > 60)
                return false;

            if (password.Length < 6)
                return false;

            if (password.Length > 60)
                return false;

            number = (int)Convert.ToChar(firstName.ElementAt(0));
            
            if (number < 60 || number > 90)
                return false;

            for (int i = 1; i <= firstName.Length; i++) {

                number = (int)Convert.ToChar(firstName.ElementAt(i));

                if ( (number < 60 || number > 90) && (number < 97 || number > 122))
                    return false;

            }

            number = (int)Convert.ToChar(firstName.ElementAt(0));

            if (number < 60 || number > 90)
                return false;

            for (int i = 1; i <= lastName.Length; i++)
            {

                number = (int)Convert.ToChar(firstName.ElementAt(i));

                if ((number < 60 || number > 90) && (number < 97 || number > 122))
                    return false;

            }

            if (IDCardSeries.Length != 8)
                return false;

            if (dateOfBirth.Length != 10)
                return false;

            for (int i = 1; i <= dateOfBirth.Length; i++)
            {

                if (i != 2 || i != 5)
                {

                    if (dateOfBirth.ElementAt(0) < 48 || dateOfBirth.ElementAt(0) > 57)
                        return false;

                }
                else
                {
                
                    if (dateOfBirth.ElementAt(i) == 46)
                        return false;
                
                }

            }

            if (phoneNumber.Length != 10)
                return false;

            if( !(String.Equals(phoneNumber.ElementAt(0), "0") && String.Equals(phoneNumber.ElementAt(1), "7")))
                return false;

            statement = true;

            for (int i = 1; i <= email.Length; i++)
            {

                if (String.Equals(email.ElementAt(i), "@"))
                    statement = false;
                    
                if(String.Equals(email.ElementAt(email.Length), "@"))
                    statement = false;

                if (String.Equals(email.ElementAt(email.Length), "m"))
                    statement = false;

                if (String.Equals(email.ElementAt(email.Length - 1), "o"))
                    statement = false;

                if (String.Equals(email.ElementAt(email.Length - 2), "c"))
                    statement = false;

                if (String.Equals(email.ElementAt(email.Length - 3), "."))
                    statement = false;

            }

            if(!statement)
                return false;

            if (!(String.Equals(militaryState, "incorporabil") || String.Equals(militaryState, "corporabil")))
                return false;
            
            return true;
        
        }

        public bool UserExists(string username)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("procUserExists", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Username", username);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {

                    if (reader.Read())
                        return false;
                    else 
                        return true;

                }
            
            }
        
        }

        public void ChangePersonalDataOfStudent(Student loggedStudent, FPersonalData fPersonalData)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("procChangeStudent", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Username", loggedStudent.Username);
                sqlCommand.Parameters.AddWithValue("@FirstName", fPersonalData.TBFirstName.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@LastName", fPersonalData.TBLastName.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@IDCardSeries", fPersonalData.TBIDCardSeries.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@IDCardNumber", fPersonalData.TBCardNumber.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@IDCardAdress", fPersonalData.TBIDCardAdress.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", fPersonalData.TBDateOfBirth.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Adress", fPersonalData.TBAdress.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", fPersonalData.TBPhoneNumber.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Email", fPersonalData.TBEmail.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@MilitaryState", fPersonalData.TBMilitaryState.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@MaritalStatus", fPersonalData.TBMaritalState.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Nationality", fPersonalData.TBNationality.Text.Trim());
                sqlCommand.ExecuteNonQuery();

            }

        }

        public void ClearAllTB(FPersonalData fPersonalData)
        {

            fPersonalData.TBFirstName.Text = "";
            fPersonalData.TBLastName.Text = "";
            fPersonalData.TBIDCardSeries.Text = "";
            fPersonalData.TBIDCardAdress.Text = "";
            fPersonalData.TBIDCardAdress.Text = "";
            fPersonalData.TBDateOfBirth.Text = "";
            fPersonalData.TBAdress.Text = "";
            fPersonalData.TBPhoneNumber.Text = "";
            fPersonalData.TBEmail.Text = "";
            fPersonalData.TBMilitaryState.Text = "";
            fPersonalData.TBMaritalState.Text = "";
            fPersonalData.TBNationality.Text = "";
        
        }
      
        public Student LoggedStudent { get => loggedStudent; set => loggedStudent = value; }

        public List<Note> getY1S1Notes()
        {

            List<Note> note = new List<Note>();

            note.Add(new Note(Cours.ALGA, 5, 1, 1));
            note.Add(new Note(Cours.AM1, 4, 1, 1));
            note.Add(new Note(Cours.AC, 5, 1, 1));
            note.Add(new Note(Cours.BCE, 5, 1, 1));
            note.Add(new Note(Cours.PC, 5, 1, 1));
            note.Add(new Note(Cours.FIZICA, 4, 1, 1));
            note.Add(new Note(Cours.LS1, 2, 1, 1));

            return note;

        }

        public List<Note> getY1S2Notes()
        {

            List<Note> note = new List<Note>();

            note.Add(new Note(Cours.AM2, 5, 1, 2));
            note.Add(new Note(Cours.MSI, 5, 1, 2));
            note.Add(new Note(Cours.ET, 5, 1, 2));
            note.Add(new Note(Cours.GAC, 5, 1, 2));
            note.Add(new Note(Cours.IA, 3, 1, 2));
            note.Add(new Note(Cours.CHIMIE, 3, 1, 2));
            note.Add(new Note(Cours.LS2, 2, 1, 2));
            note.Add(new Note(Cours.SPORT1, 2, 1, 2));

            return note;

        }

        public List<Note> getY2S1Notes()
        {

            List<Note> note = new List<Note>();

            note.Add(new Note(Cours.CN, 4, 2, 1));
            note.Add(new Note(Cours.MT, 4, 2, 1));
            note.Add(new Note(Cours.ET, 5, 2, 1));
            note.Add(new Note(Cours.PA, 5, 2, 1));
            note.Add(new Note(Cours.ASDN, 4, 2, 1));
            note.Add(new Note(Cours.MP, 4, 2, 1));
            note.Add(new Note(Cours.LS3, 2, 2, 1));
            note.Add(new Note(Cours.SPORT2, 2, 2, 1));

            return note;

        }

        public List<Note> getY2S2Notes()
        {

            List<Note> note = new List<Note>();

            note.Add(new Note(Cours.TS1, 5, 2, 2));
            note.Add(new Note(Cours.SS, 4, 2, 2));
            note.Add(new Note(Cours.ISP, 5, 2, 2));
            note.Add(new Note(Cours.BD, 5, 2, 2));
            note.Add(new Note(Cours.EIM, 4, 2, 2));
            note.Add(new Note(Cours.SM, 5, 2, 2));
            note.Add(new Note(Cours.LS4, 2, 2, 2));

            return note;

        }

        public List<Note> getY3S1Notes()
        {

            List<Note> note = new List<Note>();

            note.Add(new Note(Cours.TS2, 6, 3, 1));
            note.Add(new Note(Cours.IRA1, 5, 3, 1));
            note.Add(new Note(Cours.SED, 5, 3, 1));
            note.Add(new Note(Cours.IS, 5, 3, 1));
            note.Add(new Note(Cours.EP, 5, 3, 1));
            note.Add(new Note(Cours.LE, 2, 3, 1));
            note.Add(new Note(Cours.MC, 2, 3, 1));

            return note;

        }

        public List<Note> getY3S2Notes()
        {

            List<Note> note = new List<Note>();

            note.Add(new Note(Cours.IRA2, 5, 3, 2));
            note.Add(new Note(Cours.STR, 4, 3, 2));
            note.Add(new Note(Cours.II, 5, 3, 2));
            note.Add(new Note(Cours.EAEE, 5, 3, 2));
            note.Add(new Note(Cours.EAHP, 5, 3, 2));
            note.Add(new Note(Cours.TD, 4, 3, 2));
            note.Add(new Note(Cours.PD, 2, 3, 2));
            note.Add(new Note(Cours.PS, 2, 3, 2));

            return note;

        }

        public List<Note> getY4S1Notes()
        {

            List<Note> note = new List<Note>();

            note.Add(new Note(Cours.SCD, 5, 4, 1));
            note.Add(new Note(Cours.SCR, 5, 4, 1));
            note.Add(new Note(Cours.SCPC, 5, 4, 1));
            note.Add(new Note(Cours.FD, 5, 4, 1));
            note.Add(new Note(Cours.MEA, 4, 4, 1));
            note.Add(new Note(Cours.RC, 4, 4, 1));
            note.Add(new Note(Cours.MAD, 4, 4, 1));
            note.Add(new Note(Cours.MANAGEMENTULPROIECTELOR, 4, 4, 1));
            note.Add(new Note(Cours.MARKETING, 2, 4, 1));
            note.Add(new Note(Cours.DPP, 2, 4, 1));

            return note;

        }

        public List<Note> getY4S2Notes()
        {

            List<Note> note = new List<Note>();

            note.Add(new Note(Cours.CPI, 5, 4, 2));
            note.Add(new Note(Cours.CNMU, 5, 4, 2));
            note.Add(new Note(Cours.SFI, 5, 4, 2));
            note.Add(new Note(Cours.OPTIMIZARE, 5, 4, 2));
            note.Add(new Note(Cours.TW, 5, 4, 2));
            note.Add(new Note(Cours.ECSD, 5, 4, 2));
            note.Add(new Note(Cours.AUTOMATIZAREACLADIRILOR, 5, 4, 2));
            note.Add(new Note(Cours.SD, 5, 4, 2));
            note.Add(new Note(Cours.GD, 5, 4, 2));
            note.Add(new Note(Cours.MIP, 2, 4, 2));
            note.Add(new Note(Cours.EPD, 4, 4, 2));
            note.Add(new Note(Cours.PPD, 4, 4, 2));
            note.Add(new Note(Cours.SPD, 10, 4, 2));

            return note;

        }

        public void AddNewProfesor(FAddNewStudent fAddNewStudent) 
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("procAddNewProfesor", sqlConnection);
                    if (TestIfAllInformationsIsCompletedCorectly(sqlCommand, fAddNewStudent) && !UserExists(fAddNewStudent.TBUsername.Text))
                    {

                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@Username", fAddNewStudent.TBUsername.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@Pass", fAddNewStudent.TBPassword.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@FirstName", fAddNewStudent.TBFirstName.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@LastName", fAddNewStudent.TBLastName.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@IDCardSeries", fAddNewStudent.TBIDCardSeries.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@IDCardNumber", fAddNewStudent.TBCardNumber.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@IDCardAdress", fAddNewStudent.TBIDCardAdress.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@DateOfBirth", fAddNewStudent.TBDateOfBirth.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@Adress", fAddNewStudent.TBAdress.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@PhoneNumber", fAddNewStudent.TBPhoneNumber.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@Email", fAddNewStudent.TBEmail.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@MilitaryState", fAddNewStudent.TBMilitaryState.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@MaritalStatus", fAddNewStudent.TBMartialState.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@Nationality", fAddNewStudent.TBNationality.Text.Trim());
                        sqlCommand.ExecuteNonQuery();

                    }

                }
            
        }

        public void AddNewSecretariat(FAddNewStudent fAddNewStudent)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("procAddNewSecretariat", sqlConnection);
                if (TestIfAllInformationsIsCompletedCorectly(sqlCommand, fAddNewStudent) && !UserExists(fAddNewStudent.TBUsername.Text))
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Username", fAddNewStudent.TBUsername.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Pass", fAddNewStudent.TBPassword.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@FirstName", fAddNewStudent.TBFirstName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@LastName", fAddNewStudent.TBLastName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@IDCardSeries", fAddNewStudent.TBIDCardSeries.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@IDCardNumber", fAddNewStudent.TBCardNumber.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@IDCardAdress", fAddNewStudent.TBIDCardAdress.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@DateOfBirth", fAddNewStudent.TBDateOfBirth.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Adress", fAddNewStudent.TBAdress.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", fAddNewStudent.TBPhoneNumber.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Email", fAddNewStudent.TBEmail.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@MilitaryState", fAddNewStudent.TBMilitaryState.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@MaritalStatus", fAddNewStudent.TBMartialState.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Nationality", fAddNewStudent.TBNationality.Text.Trim());
                    sqlCommand.ExecuteNonQuery();

                }

            }

        }

        public void ProfesorAddNotes(Profesor curentProfesor, Student student)
        {
            


        }

        public void ProfesorChangeNotes(Profesor curentProfesor, Student student)
        {



        }

        public void SecretariatAddSchoolInformationsAboutStudent(Student student)
        {



        }

        public void SecretariatAddSchoolInformationsAboutProfesor(Profesor profespr)
        {



        }

        public void SecretariatDeleteStudent(Student student)
        {



        }

        public void SecretariatDeleteProfesor(Profesor profesor)
        {



        }

    }

}
