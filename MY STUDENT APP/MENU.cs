using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_STUDENT_APP
{
   
    public class MENU
    {
        public void Mainmenu()
        {
            Console.WriteLine("-------WELCOME TO MY STUDENT APP------");
            Console.WriteLine("Choose an option from the menu");
            Console.WriteLine("1. Register ");
            Console.WriteLine("2.Get registration number");
            Console.WriteLine("3.Check Addmission Status");
            Console.WriteLine("4.Admit student");
            Console.WriteLine("5.View student details");
            Console.WriteLine("6.Update Details");
            Console.WriteLine("7.Exit");
            Console.WriteLine("Enter an option");
            int option = int.Parse(Console.ReadLine());
            bool returnMenu = false;
            Student student = new Student();
            

            switch (option)
            {
                case 1:
                    Student.RegistrationMenu();
                    Mainmenu();
                    break;
                    case 2:
                    Student.GenerateRegistrationNumber();
                        Mainmenu();
                    break ;
                    case 3:
                    Student.AddmissionStatus();

                    Mainmenu();
                    break;
                case 4:
                    Student.AdmitStudent();
                    Mainmenu();
                    break;
                case 5:
                    Student.ViewStudentDetails();
                    Mainmenu() ;
                    break;
                case 6:
                    Student.UpdateDetails();
                    Mainmenu();
                    break;
                case 7:
                    returnMenu = true;
                    break;
                    
            }
        }
    }
}
