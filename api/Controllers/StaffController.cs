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
        public ActionResult<IEnumerable<StaffModel>> GetStaffName()
        {
            return Ok (StaffRepository.Staff);
        }

        [HttpGet("{id:int}")]
        public ActionResult<StaffModel> GetStaffById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id is not valid");
            }

            var result = StaffRepository.Staff.Where(n => n.StaffId == id).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{name:alpha}")]
        public ActionResult<StaffModel> GetStaffByname(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest(name);
            }
            var result = StaffRepository.Staff.Where(n => n.FirstName == name).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public StaffModel UpdateStaffById(int id)
        {
            return StaffRepository.Staff.Where(n =>n.StaffId == id).FirstOrDefault();
        }

        [HttpDelete("{id:int}")]
        public ActionResult<StaffModel> DeleteStaffById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var result = StaffRepository.Staff.Where(n => n.StaffId == id).FirstOrDefault();

            if (result == null)
            {
                return NotFound();

            }
            StaffRepository.Staff.Remove(result);
            return Ok(result);
        }
    }
}