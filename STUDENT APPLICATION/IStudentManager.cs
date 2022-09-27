using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_APPLICATION
{
     interface IStudentManager
    {
        public Student GetStudent(string regNo);

        public Student RegisterStudent(string firstName, string lastName, string eMail, string phoneNumber, DateTime dateOfBirth, int gender, string selectedSchool, string selectedCourse);

        public bool GetAddmisionStatus(string regNo);
        public string AdmitStudentByRegNo(string regNo);
        public Student[] GetStudentByCourse(string course);
            public string AdmitStudentByCourse(string course);
        //public Student[] GetStudentBySchool(string school);
        public DateTime AdmitByAge(DateTime age);
        DateTime AdmitByAge(DateTime age, int r);
    }
}
