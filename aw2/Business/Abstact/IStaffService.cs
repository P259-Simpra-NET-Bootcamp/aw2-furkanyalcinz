using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstact
{
    public interface IStaffService
    {
        void AddStaff(Staff staff);
        void UpdateStaff(Staff staff);
        Staff GetByMail(string name);
        Staff GetById(int id);
        List<Staff> GetByCountry(string country);
        List<Staff> GetByCity(string city);
        void DeleteStaff(int id);
        List<Staff> GetAll();
    }
}
