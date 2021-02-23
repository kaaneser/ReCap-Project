using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Password).MinimumLength(6).WithMessage("Şifre minimum 6 karakter olmalı");
            RuleFor(u => u.FirstName).MinimumLength(3).WithMessage("İsim min 3 karakterden oluşmalı");
        }
    }
}
