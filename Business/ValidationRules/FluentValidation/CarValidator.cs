using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("Araç adı minimum 2 karakter olmalı.");
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(150).WithMessage("Aracın fiyatı min 150 lira olmalı");
        }
    }
}
