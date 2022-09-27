using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_APPLICATION
{
     class Student
    {
        private string _regNo;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phoneNumber;
        private DateTime _dateOfBirth;
        private string _selectedCourse;
        private string _selectedSchool;
        private bool _isAddmitted;
        private DateTime? _addmittedDate;
        private Gender _gender;
        private string regNo;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private Gender gender;
        private DateTime dateOfBirth;
        private string selectedCourse;
        private string selectedSchool;

        public Student(string regNo, string firstName, string lastName, string eMail, string phoneNumber, string selectedCourse, string selectedSchool, DateTime dateOfBirth, Gender gender)
        {
            _regNo = regNo;
            _firstName = firstName;
            _lastName = lastName;
            _email = eMail;
            _phoneNumber = phoneNumber;
            _selectedCourse = selectedCourse;
            _selectedSchool = selectedSchool;
            _isAddmitted = false;
            _dateOfBirth = dateOfBirth;
            _addmittedDate = null;
            _gender = gender;


        }
        public DateTime GetAge()
        {
            return _dateOfBirth;
        }

        internal object GetSelectedSchool()
        {
            throw new NotImplementedException();
        }

        public Student(string regNo, string firstName, string lastName, string email, string phoneNumber, Gender gender, DateTime dateOfBirth, string selectedCourse, string selectedSchool)
        {
            this.regNo = regNo;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.selectedCourse = selectedCourse;
            this.selectedSchool = selectedSchool;
        }

        public string GetRegNo()
        {
            return _regNo;
        }
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        internal string GetSelectedCourse()
        {
            throw new NotImplementedException();
        }

        public bool GetIsAddmitted()
        {
            return _isAddmitted;
        }
        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }
        public string GetSelectedSchool(string selectedSchool)
        {
           return _selectedSchool; 
        }
        public void SetIsAdmitted(bool isAdmitted)
        {
            _isAddmitted=isAdmitted;
        }
        public string GetSelectedCourse(string selectedCourse)
        {
            return _selectedCourse;
        }

    }
}
