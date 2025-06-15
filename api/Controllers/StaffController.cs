using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StaffModel> GetStaffName()
        {
            return StaffRepository.Staff;
        }

        [HttpGet("{id:int}")]
        public StaffModel GetStaffById(int id)
        {
            return StaffRepository.Staff.Where(n =>n.StaffId == id).FirstOrDefault();
        }
        [HttpGet("{name:alpha}")]
        public StaffModel GetStaffByname(string name)
        {
            return StaffRepository.Staff.Where(n =>n.FirstName == name).FirstOrDefault();
        }
        [HttpPut("{id:int}")]
        public StaffModel UpdateStaffById(int id)
        {
            return StaffRepository.Staff.Where(n =>n.StaffId == id).FirstOrDefault();
        }

        [HttpDelete("{id:int}")]
        public StaffModel DeleteStaffById(int id)
        {
            return StaffRepository.Staff.Where(n => n.StaffId == id).FirstOrDefault();
        }
    }
}