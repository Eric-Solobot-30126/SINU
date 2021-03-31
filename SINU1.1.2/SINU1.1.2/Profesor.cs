using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINU1._1._2
{
    public class Profesor
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

        private List<Cours> cours;
        private string observation;


        //Construcotrs


        public Profesor(string username, string password, string firstName, string lastName, string iDCardSeries, string iDCardNumber, string iDCardAdress, string dateOfBirth, string adress, string phoneNumber, string email, string militaryState, string maritalStatus, string nationality, List<Cours> cours, string observation)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            IDCardSeries = iDCardSeries;
            IDCardNumber = iDCardNumber;
            IDCardAdress = iDCardAdress;
            this.dateOfBirth = dateOfBirth;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.militaryState = militaryState;
            this.maritalStatus = maritalStatus;
            this.nationality = nationality;
            this.cours = cours;
            this.observation = observation;
        }


        //Methodes





        //GettereSettere


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
        public List<Cours> Cours { get => cours; set => cours = value; }
        public string Observation { get => observation; set => observation = value; }


    }
}
