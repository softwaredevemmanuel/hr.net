using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
   [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            var students = new List<Student>
            {
                new Student
                {
                    UserId = 1,
                    FirstName = "Emmanuel",
                    LastName = "Okereke",
                    Email = "eokereke47@gmail.com",
                    Password = "1234",  // Note: In production, never store plain passwords
                    IsVerified = true,
                    Location = true,
                    CreatedAt = DateTime.UtcNow,  // Using UtcNow instead of Now
                    UpdatedAt = DateTime.UtcNow
                },
                new Student
                {
                    UserId = 2,  // Changed from 1 to 2 for unique IDs
                    FirstName = "Caleb",
                    LastName = "Nathan",
                    Email = "caleb@gmail.com",
                    Password = "123479",
                    IsVerified = true,
                    Location = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };

            return Ok(students);  // Wrapping in Ok() for proper HTTP response
        }

   
    }
}