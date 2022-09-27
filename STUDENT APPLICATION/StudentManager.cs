using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_APPLICATION
{
    class StudentManager : IStudentManager
    {
        Random random = new Random();
        private Student[] _selectedSchool = new Student[100];
        private int _noOfStudents = 0;

        public string AdmitStudentByCourse(string course)
        {
            string response = "";
            Student[] students = GetStudentByCourse(course);

            if (students.Length == 0)
            {
                return "No student has chosen this course";
            }

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].GetIsAddmitted() == true)
                {
                    response += $"{i + 1}. {students[i].GetFullName()} Has already been admitted\n";
                }
                else
                {
                    students[i].SetIsAdmitted(true);
                    response += $"{i + 1}. {students[i].GetFullName()} Has been admitted successfully to {students[i].GetSelectedSchool()}\n";
                }
            }

            return response;

        }

       
        public string GenerateRegNo()
        {
            char c1 = (char)('A' + random.Next(0, 26));
            char c2 = (char)('A' + random.Next(0, 26));

            string number = random.Next(1, 10000).ToString("0000");

            return $"{c1}{c2}{number}";
        }

        public bool GetAddmisionStatus(string regNo)
        {
            Student student = GetStudent(regNo);

            if (student == null)
            {
                return false;
            }
            else
            {
                return student.GetIsAddmitted();
            }
        }

      //  public bool GetAdmissionStatus(string regNo)
       // {
            
       // }

        public Student GetStudent(string regNo)
        {

            for (int i = 0; i < _noOfStudents; i++)
            {
                if (_selectedSchool[i].GetRegNo() == regNo)
                {
                    return _selectedSchool[i];
                }
            }

            return null;
        }

        public Student[] GetStudentByCourse(string course)
        {
            int count = 0;
            for (int i = 0; i < _noOfStudents; i++)
            {
                if (_selectedSchool[i].GetSelectedCourse() == course)
                {
                    count++;
                }
            }

            Student[] courseStudents = new Student[count];

            for (int i = 0; i < _noOfStudents; i++)
            {
                if (_selectedSchool[i].GetSelectedCourse() == course)
                {
                    courseStudents[count - 1] = _selectedSchool[i];
                    count--;
                }
            }

            return courseStudents;
        }

      //  public Student[] GetStudentsByCourse(string course)
      //  {
           
      //  }

        public Student RegisterStudent(string firstName, string lastName, string email, string phoneNumber, DateTime dateOfBirth, int genderValue, string selectedSchool, string selectedCourse)
        {
            string regNo = GenerateRegNo();
            Gender gender = (Gender)genderValue;

            Student student = new Student(regNo, firstName, lastName, email, phoneNumber, gender, dateOfBirth, selectedCourse, selectedSchool);

            _selectedSchool[_noOfStudents] = student;
            _noOfStudents++;

            return student;
        }

        
        public string AdmitStudentByRegNo(string regNo)
        {
            Student student = GetStudent(regNo);

            if (student.GetIsAddmitted() == true)
            {
                return "Student is already admitted";
            }

            student.SetIsAdmitted(true);

            return $"{student.GetFullName()} is admitted succesfully to {student.GetSelectedSchool()}";
        }

        public DateTime AdmitByAge(DateTime age , int r)
        {
            Student student = GetAge(age);
            int date = (DateTime.Now) - (student.GetAge()
            if (date <= 18)
            {
            }
            else
            {
                Console.WriteLine(" Congrats you are above 18 and now Admitted");

            }
            if (date < 18)
            {
                Console.WriteLine("Oops! you are not above 18 and cannot be admitted");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        
        }

        private Student GetAge(DateTime age)
        {
            throw new NotImplementedException();
        }

        //public Student[] Get_selectedSchool()
        //{
        //    return _selectedSchool;
        //}

        /*public Student[] GetStudentBySchool(string school)
        {
            int count = 0;
            for (int i = 0; i < _noOfStudents; i++)
            {
                if (_selectedSchool[i].GetSelectedSchool() = school)
                {
                    count++;
                }
            }
            Student[] students = new Student[count];
            for (int i = 0; i < _noOfStudents; i++)
            {
                if (_selectedSchool[i].GetSelectedSchool() == school)
                {
                    school[count - 1] = _selectedSchool[i];
                    count--;
                }
            }

            return school;
        }*/
    }

        private Student GetAge(DateTime age)
        {
            throw new NotImplementedException();
        }
    }
