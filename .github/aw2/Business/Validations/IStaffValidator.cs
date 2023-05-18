using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations
{
    public interface IStaffValidator
    {
        ValidationResult Validate(Staff staff);
    }
}
