using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lab9
{
    public class RegistrationModelValidator : AbstractValidator<RegistrationModel>
    {
        public RegistrationModelValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6)
                .Must(x => x != x.ToUpper())
                .WithMessage("Name must contain lower case letters")
                .Must(x => x != x.ToLower())
                .WithMessage("Name must contain at least one upper case letters")
                .Matches(@"(.[!@#$%^&().+].*)+")
                .Matches(@"\d+");

            RuleFor(x => x.Accept)
                .Must(x => x == true)
                .WithMessage("You must accept terms!");
        }
    }
}
