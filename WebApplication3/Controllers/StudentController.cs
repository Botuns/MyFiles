using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebApplication3.Entities;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentRepo repo = new StudentRepo();
        
        [HttpGet("GetAllStudents")]
        
        public IActionResult GetAllStudents()
        {
            var students = repo.Students();
            if (students == null)
            {
                return NotFound(students);
            }
            return Ok(students);
        }
        [HttpGet("GetStudent")]
        public IActionResult GetStudent(int id)
        {
            var student = repo.GetStudentById(id);
            if (student == null) { return NotFound(); }
            return Ok(student);
        }
    }
}
