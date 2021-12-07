using BatchAssessment.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatchAssessment.Validations
{
    public class BatchModelValidators : AbstractValidator<BatchModel>
    {
        public BatchModelValidators()
        {
            RuleFor(x => x.BusinessUnit).NotEmpty().WithMessage("Business Unit cannot be empty");
        }
    }
}
