using System.Collections.Generic;
using System.Linq;

namespace WebApplication3.Entities
{
    public class StudentRepo
    {
        List<Student> students = new List<Student>()
        {
            new Student{Id = 1, Name = "Olajide", Age = 12, Email = "abdul@gfmail.com" },
            new Student{Id = 2, Name = "Rolake", Age = 11, Email = "rolake@gfmail.com" },
            new Student{Id = 3, Name = "David", Age = 15, Email = "david@gfmail.com" },
            new Student{Id = 4, Name = "Akin", Age = 14, Email = "akin@gfmail.com" }
        };
        public List<Student> Students()
        {
            var student = students.ToList();
            return student;
        }
        public Student GetStudentById(int id)
        {
            var student = students.Where(x => x.Id == id).FirstOrDefault();
            return student;
        }
    }
}
