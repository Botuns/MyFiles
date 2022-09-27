using System;

namespace MY_STUDENT_APP
{

    public class Student
    {
        
        private string FirstName;
        private string Lastname;
        private string Email;
        private string Phonenumber;
        // private DateTime? AddmissionDate;
        private string _selectedCourse;
        private string SelectedSchool;
        private static string RegNo;
        static Student[] Students = new Student[100];
        static int Count = 0;
        private Geender _Gender;
        private bool Addmitted;
        private string _RegNo;
        /*public Student()
        {

        }
*/

        public  Student(string firstname, string lastname, string email, string phonenumber, string selectedschool, string selectedcourse, string RegNo, Geender Gender)
        {
            Addmitted = false;
            FirstName = firstname;
            Lastname = lastname;
            Email = email;
            Phonenumber = phonenumber;
            _Gender = Gender;
            _selectedCourse = selectedcourse;
            SelectedSchool = selectedschool;
            _RegNo = RegNo; //GenerateRegistrationNumber();
            


        }
        public static Student[]students=new Student[100];
        public static int numberofstudents = 0;

        public Student()
        {
        }
        
        public static string GenerateRegistrationNumber()
        {
            char[] array = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y', };
            string RegNoo = "";
            Random num =new Random();
            for (int i = 1; i < 5; i++)
            {
                RegNoo+=num.Next(0,10).ToString();
            }
            for (int y = 5; y < 8; y++)
{
                string n = num.Next(0, 25).ToString();
                RegNoo += array[int.Parse(n)];
            }
            Console.WriteLine($" Your reg no is {RegNoo}");
            return RegNoo;
        }

        public static string GetRegisternumber()
        {
            return RegNo;
        }
        public static void ViewStudentDetails()
        {
            
            Console.WriteLine("Enter your reg no to show details");
            string g =Console.ReadLine();
            if (g == GenerateRegistrationNumber())
            {
                Console.WriteLine(students.Length);
            }
            else
            {
                Console.WriteLine("Details not found");
            }
        }
        public static void UpdateDetails()
        {
           // bool m = true;
            Console.WriteLine("pls enter reg no");
            string d = Console.ReadLine();
            if (d == GenerateRegistrationNumber()) //{ m = false; }
            {
                Console.WriteLine("Enter what you want to update");
                int update = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter an option");
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. E Mail");
                Console.WriteLine("4. School of preference");

                switch (update)
                {
                    case 1:
                        Console.WriteLine("Enter your new first name");
                        string firstname = Console.ReadLine();
                        break;
                        case 2:
                        Console.WriteLine("Enter your new last name");
                        string lastname = Console.ReadLine();
                        break ;
                        case 3:
                        Console.WriteLine("Enter your new email");
                        string email = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter your new school of preference");
                        string school = Console.ReadLine() ;
                        break;
                        default:
                        Console.WriteLine("Invalid input");
                        break;

                }

                bool m = true;
                Console.WriteLine("Do you want to continue press YES or NO");
                string tell = Console.ReadLine();
                if(tell.ToLower() == "no")
                {
                    m = false;
                }
            }
            if (d != RegNo)
            {
                Console.WriteLine(" Pls register first");
            }
        }
        public static void RegistrationMenu()
        {
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
            Console.WriteLine("Enter your  school of study");
            string selectedSchool = Console.ReadLine();
            Console.Write("Choose your gender : ");
            Console.WriteLine("\t1. Male");
            Console.WriteLine("\t2. FeMale");
            byte genderValue = byte.Parse(Console.ReadLine());

            Geender gender = (Geender)genderValue;
            Student stud = new Student(firstname, lastname, email, phone, selectedcourse, selectedSchool, RegNo, (Geender)genderValue);
            Students[Count] = stud;
            Count++;
            Console.WriteLine($" your name is {firstname} {lastname}");
           // GenerateRegistrationNumber();
            
            PrintStudentInfo();
        }
        public static void PrintStudentInfo()
        {
            
            
        }
        public static  void AdmitStudent()
        {
            Console.WriteLine("Enter your reg no to know if admitted");
            string reg = Console.ReadLine();
            if (reg == RegNo)
            {
                Console.WriteLine("Congratulations you are now a student ! ");
            }
            else if (reg != RegNo)
            {
                Console.WriteLine("You are yet to be addmitted(REG NO not found!)");
                Console.WriteLine("Please enter an option to get admitted ");
                Console.WriteLine("1. Admit by reg no");
                Console.WriteLine("2.Admit by course of study");
                int enter = int.Parse(Console.ReadLine());
                switch (enter)
                {
                    case 1:
                        Student.AdmitByRegNo();
                        break;
                        case 2:
                        Student.AdmitByCourse();
                        break;
                        default:
                        break;

                }

            }
        }
        public static void AdmitByRegNo()
        {
            Console.WriteLine("Enter your RegNo");
            string no = Console.ReadLine();
            if (no == GenerateRegistrationNumber())
            {
                Console.WriteLine("You are now admitted");
            }
            else if (no != GenerateRegistrationNumber())
            {
                Console.WriteLine("Get RegNo first Thanks!");
            }

        }
        public static void AdmitByCourse()
        {
            Console.WriteLine("Enter your course of study when you registered");
            string co = Console.ReadLine();
            Console.WriteLine("you are now registered");
        }
        public  static void AddmissionStatus()
        {
            Console.WriteLine("Enter your registration number");
            string reg = Console.ReadLine();
            for(int i = 0; i < 100; i++)
            {
                if (Students.Length != 0)
                {
                    if(GetRegisternumber() == reg)
                    {
                        if (Students[i].Addmitted == true)
                        {
                            Console.WriteLine("Congrats you are now admitted !");
                            Console.Beep();
                        }
                        else
                        {
                            Console.WriteLine("Not admitted, check back later");
                        }
                    }
                    else
                    {
                        Console.WriteLine($" student with registration number {reg} not found");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Hey! not yet registered ");
                }
            }
        }

    }
    
}
