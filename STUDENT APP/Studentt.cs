using System;

namespace STUDENT_APP
{
    public void  Registration()
    {
        Console.WriteLine("--------WELCOME TO ADDMISSION PORTAL--------");

        Console.WriteLine("Enter your first name");
        string firstname = Console.ReadLine();
        Console.WriteLine("Enter your last name");
        string lastname = Console.ReadLine();
        Console.WriteLine("Enter your email");
        string email = Console.ReadLine();
        Console.WriteLine("Enter your phone number");
        string phone = Console.ReadLine();
        Console.WriteLine("Enter your preffered course of study");
        string selectedcourse = Console.ReadLine();
        Console.WriteLine("Enter your  course of study code");
        string selectedcoursecode = Console.ReadLine();
        Console.Write("Choose your gender : ");
        Console.WriteLine("\t1. Male");
        Console.WriteLine("\t2. FeMale");
        byte genderValue = byte.Parse(Console.ReadLine());

        Gender gender = (Gender)genderValue;
        var student = new Studentt(firstname, lastname, email, /*phone,*/ selectedcourse, selectedcoursecode /*genderValue*/);

    }

    internal class Studentt
    {
        
                

            private string firstname { get; set; }
       private string lastname { get; set; }
        private string email { get; set; }
        private string selectedcourse { get; set; }
        private string selectedcoursecode { get; set; }
         bool addmitted;
        
        public class Student
        {
            private string _firstname;
            private string _lastname;
            private string _email;
            private string _phone;
            private bool addmitted;
            private DateTime? _addmissionDate;
            private string _selectedcourse;
            private string _selectedcoursecode;

            public  Student(string firstname , string lastname ,string email , string phone , string selectedCourse , string selectedCoursecode)
            {
                _firstname = firstname;
                _lastname = lastname;
                _email = email;
                _phone = phone;
                _selectedcourse = selectedCourse;
                _selectedcoursecode = selectedCoursecode;
                addmitted = false;
                _addmissionDate = DateTime.Now; 

            }
        }
        
        static void Main(string[] args)
        {
                
               
            }
        }
    }
}
