using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations
{
    public class StaffValiadator:AbstractValidator<Staff>, IStaffValidator
    {
        public StaffValiadator()
        {
            RuleFor(staff => staff.Email).NotEmpty().WithMessage("Email cannot be empty.").EmailAddress().WithMessage("E mail isnot valid");
            RuleFor(staff => staff.FirstName).Length(3, 20).WithMessage("Name length cannot be less than 3 and bigger than 20");
            RuleFor(staff => staff.LastName).Length(3, 20).WithMessage("Lastname length cannot be less than 3 and bigger than 20");

        }
    }
}
