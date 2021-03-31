using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINU1._1._2
{
    interface SINUInterface
    {

        void AddNewStudent(FAddNewStudent fAddNewStudent);

        void SelectUser(FLogIn fLogIn);

        Student LoggedStudent { get; set; }

        void ChangePersonalDataOfStudent(Student loggedStudent, FPersonalData fPersonalData);

        void ClearAllTB(FPersonalData fPersonalData);

        // TODO:

        void ProfesorAddNotes(Profesor curentProfesor, Student student);

        void ProfesorChangeNotes(Profesor curentProfesor , Student student);

        void SecretariatAddSchoolInformationsAboutStudent(Student student);

        void SecretariatAddSchoolInformationsAboutProfesor(Profesor profespr);

        void SecretariatDeleteStudent(Student student);

        void SecretariatDeleteProfesor(Profesor profesor);

        void AddNewProfesor(FAddNewStudent fAddNewStudent);

        void AddNewSecretariat(FAddNewStudent fAddNewStudent);

    }

}
