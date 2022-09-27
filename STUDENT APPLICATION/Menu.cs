using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_APPLICATION
{
     class Menu
    {
        IStudentManager studentManager = new StudentManager();


        
        public void ShowMainMenu()
        {

            bool continueApp = true;
            do
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2.Check Addmission Status");
                Console.WriteLine("3.List Students");
                Console.WriteLine("4. Admit Students");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ShowRegisterMenu();
                        break;
                        case 2:
                        ShowAddmissionStatusMenu();
                        break;
                    case 3:
                        ShowAdmitStudentMenu();
                        break;
                }

            } while (continueApp);
        }
        private void ShowAdmitStudentMenu()
        {
            Console.WriteLine("1. By Reg No");
            Console.WriteLine("2.By Course");
            Console.WriteLine("3. By School");
            int option =Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                Console.WriteLine("Enter student reg number");
                string regNo =Console.ReadLine();
                if(studentManager.GetStudent(regNo) == null)
                {
                    Console.WriteLine("Student not found");
                }
                else
                {
                    Console.WriteLine(studentManager.AdmitStudentByRegNo(regNo));

                }
                

            }
            else if (option == 2)
            {
                Console.WriteLine("Enter Course Name: ");
                string course = Console.ReadLine();
                string response = studentManager.AdmitStudentByCourse(course);
                Console.WriteLine(response);

            }
            else
            {
                if()
            }

        }
        private void ShowAddmissionStatusMenu()
        {
            Console.WriteLine("Enter your regristration number");
             string regNo = Console.ReadLine();
            if (studentManager.GetStudent(regNo) == null)
            {
                Console.WriteLine("student not found");
            }
            else
            {
                if (studentManager.GetAddmisionStatus(regNo) == true)
                {
                    Console.WriteLine( "Congratulations you have been addmitted");
                }
                else
                {
                    Console.WriteLine("You are yet to be Addmitted, pls check back later");
                }
            }
        }
        private void ShowRegisterMenu()
        {
            Console.Write("Enter your first Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your phone number");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter your course: ");
            string selectedCourse = Console.ReadLine();

            Console.Write("Enter your school of preference: ");
            string selectedSchool = Console.ReadLine();

            Console.Write("Enter Date of Birth");
             DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Select Gender: ");
            Console.WriteLine("\t1. Male");
            Console.WriteLine("\t2. Female");
            int gender = Convert.ToInt32(Console.ReadLine());

            Student newStudent = studentManager.RegisterStudent(firstName, lastName, email, phoneNumber, dateOfBirth, gender, selectedSchool, selectedCourse);

            Console.WriteLine($"Dear {newStudent.GetFullName()}, your registration is successful. Your Registaration number is {newStudent.GetRegNo()}");



        }

    }
}
