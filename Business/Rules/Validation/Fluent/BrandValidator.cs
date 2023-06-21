using FluentValidation;
using SmartPro.Entities.Concrete;

namespace SmartPro.Business.Rules.Validation.Fluent
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).MinimumLength(2);

        }
    }
}
