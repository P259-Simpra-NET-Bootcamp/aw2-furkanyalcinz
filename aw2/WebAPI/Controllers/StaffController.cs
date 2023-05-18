using Business.Abstact;
using DataAccess.Abstact;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpPost]
        public void Post([FromBody] Staff staff)
        {
            _staffService.AddStaff(staff);
        }
        [HttpGet("GetAll")]
        public List<Staff> GetAll()
        {
            return _staffService.GetAll();
        }
        [HttpGet("GetById")]
        public Staff Get([FromQuery] int id)
        {
            return _staffService.GetById(id);
        }
        [HttpDelete("DeleteStaff")]
        public void Delete(int id)
        {
            _staffService.DeleteStaff(id);
        }
        [HttpPut("UpdateStaff")]
        public void Put([FromBody] Staff staff)
        {

            _staffService.UpdateStaff(staff);
        }
        [HttpGet("GetByMail")]
        public Staff GetByMail([FromBody] string mail) 
        { 
            return _staffService.GetByMail(mail);
        }
        [HttpGet("GetByCountry")]
        public List<Staff> GetByCountry([FromQuery] string country)
        {
            return _staffService.GetByCountry(country);
        }
        [HttpGet("GetByCity")]
        public List<Staff> GetByCity([FromQuery] string city)
        {
            return _staffService.GetByCity(city);
        }

    }
}
