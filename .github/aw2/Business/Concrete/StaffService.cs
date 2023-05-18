using Business.Abstact;
using Business.Validations;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository staffRepository;
        private readonly IStaffValidator validator;

        public StaffService(IStaffRepository staffRepository, IStaffValidator validator)
        {
            this.staffRepository = staffRepository;
            this.validator = validator;
        }

        public void AddStaff(Staff staff)
        {
            var validationResult = validator.Validate(staff);
            if (validationResult.IsValid)
            {
                staffRepository.Insert(staff);
                staffRepository.Complete();
            }
            
        }

        public void DeleteStaff(int id)
        {
            staffRepository.Delete(GetById(id));
            staffRepository.Complete();
        }

        public List<Staff> GetAll()
        {
            return staffRepository.GetAll();    
        }

        public List<Staff> GetByCity(string city)
        {
            return staffRepository.GetAll(x=>x.City == city);
        }

        public List<Staff> GetByCountry(string country)
        {
            return staffRepository.GetAll(x=>x.Country == country);

        }

        public Staff GetById(int id)
        {
            return staffRepository.GetById(id);
        }

        public Staff GetByMail(string mail)
        {
            return staffRepository.Get(x => x.Email == mail);
        }


        public void UpdateStaff(Staff staff)
        {
            var validatorResult = validator.Validate(staff);
            if (validatorResult.IsValid)
            {
                staffRepository.Update(staff);
                staffRepository.Complete();
            }
        }


    }
}
